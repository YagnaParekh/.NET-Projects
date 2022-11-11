using System;
using System.Drawing;
using System.Windows.Forms;


/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 * 
 */
namespace Lab5A
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen p;
        private SolidBrush b;
        private SolidBrush b2;
        private Color c = Color.Aqua;

        private int fillamount = 0;
        private int max_water = 275;

        Rectangle water;
        Rectangle flow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.White);
            b = new SolidBrush(c);
            b2 = new SolidBrush(Color.Black);

            g = CreateGraphics();

            Reset();
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            colorDialog.Color = c;
            colorDialog.ShowDialog();
            c = colorDialog.Color;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            fillamount++;
            water.Y = 100 + max_water - fillamount;
            water.Height = fillamount;
            g.FillRectangle(b, water);
            g.FillRectangle(b, flow);

            if(fillamount > 100)
            {
                fillamount = 0;
                trackBar.Value = 0;
                g.FillRectangle(b2, flow);
                g.FillRectangle(b, water);
                timer.Stop();
            }
        }

        public void Reset()
        {
            g.Clear(Color.Black);


            g.DrawLine(p, 74, 250, 74, 375);
            g.DrawLine(p, 300, 250, 300, 375);
            g.DrawLine(p, 74, 375, 300, 375);

            flow = new Rectangle(137, 150, 25, 225);
            water = new Rectangle(75, 100 + max_water - fillamount, 225, fillamount);
            g.FillRectangle(b, water);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if(trackBar.Value == 0)
            {
                timer.Stop();
                g.FillRectangle(b2, flow);
                g.FillRectangle(b, water);
            }
            else if(trackBar.Value >= 1)
            {
                Reset();
                timer.Interval = (11 - trackBar.Value) * 50;
                timer.Start();
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
