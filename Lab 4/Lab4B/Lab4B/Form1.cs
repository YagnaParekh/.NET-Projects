using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Lab4B
{
    public partial class Form1 : Form
    {
        string file_Path = string.Empty;
        string file_Name = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void loadFileMenu_Click(object sender, EventArgs e)
        {
            if(openHtmlfile1.ShowDialog() == DialogResult.OK)
            {
                file_Path = openHtmlfile1.FileName;
                file_Name = file_Path.Split('\\')[file_Path.Split('\\').Length - 1];
                ChangeFileStatus($"Loaded : {file_Name}", Color.Black);
                checkTags.Enabled = true;
            }
            else
            {
                ChangeFileStatus("Failed Loading File", Color.Red);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeFileStatus (string text, Color color)
        {
            fileStatus.ForeColor = color;
            fileStatus.Text = text;
        }

        private void processToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkTags_Click(object sender, EventArgs e)
        {
            Stack<string> htmlTags = new Stack<string>();

            string tabs = "";

            if(File.Exists(file_Path))
            {
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(file_Path, FileMode.Open);
                    sr = new StreamReader(fs);

                    while(!sr.EndOfStream)
                    {
                        string input = sr.ReadLine();
                        if(input != "")
                        {
                            string[] values = input.Split('<');

                            foreach(string value in values)
                            {
                                if(!string.IsNullOrWhiteSpace(value))
                                {
                                    string htmlEntity = value.Split('>')[0];
                                    string tag = htmlEntity.Split(' ')[0].ToLower();

                                    if(tag != "")
                                    {
                                        if(value.StartsWith("img") || value.StartsWith("hr") || value.StartsWith("br"))
                                        {
                                            htmlLB.Items.Add($"{tabs}Found non-conatiner tag: <{tag}>");
                                        }
                                        else if (tag.StartsWith("/"))
                                        {
                                            tabs = tabs.Substring(0, tabs.Length - 2);

                                            if(htmlTags.Peek() != tag.Substring(1))
                                            {
                                                ChangeFileStatus($"{file_Name} does not have proper balanced tags", Color.Red);
                                                return;
                                            }
                                            else
                                            {
                                                htmlTags.Pop();
                                            }

                                            htmlLB.Items.Add($"{tabs}Found closing tag: <{ tag}>");
                                        }
                                        else
                                        {
                                            htmlLB.Items.Add($"{tabs}Found opening tag: <{tag}>");
                                            tabs += " ";
                                            htmlTags.Push(tag);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch(Exception ae)
                {
                    ChangeFileStatus("Failed Reading File", Color.Red);
                    MessageBox.Show($"Failed Reading File due to : \n{ae.Message}");
                    checkTags.Enabled = false;
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                    if (sr != null)
                        sr.Close();
                }
            }
            else
            {
                ChangeFileStatus("No file Selected", Color.Red);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
