/*
 * I, Yagna Parekh, 000846481 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Services_Enter(object sender, EventArgs e)
        {

        }

        private void ClientVisits_Enter(object sender, EventArgs e)
        {

        }

        private void Hairdresser_Enter(object sender, EventArgs e)
        {

        }

        private void Calculte_Click(object sender, EventArgs e)
        {
            /*
             * Checked if the button is selected or not
             */
            if (!Cut_box.Checked && !Color_box.Checked && !Highlight_box.Checked && Extension_box.Checked)
            {
                price_label.Text = "Total Price: ";
                MessageBox.Show("You must select at least one sevice, Missing Service(s)");
            }

            /*
             * Validating number of clients must not be negative or false value
             */

            int visit = 0;

            if(!int.TryParse(visit.ToString(), out visit) || visit < 0)
            {
                price_label.Text =  " Total Price :";
                MessageBox.Show("Number of visits should be an integer or greater than 0.");
                return;
            }

         
            /*
             * Calculate as per the selection of hair dresser and apply charges respectively
             */
            decimal rate = 0;

            if(Jan_button.Checked)
            {
                rate = 30;
            }
            else if(Pat_button.Checked)
            {
                rate = 45;
            }
            else if(Ron_button.Checked)
            {
                rate = 40;
            }
            else if (Sue_button.Checked)
            {
                rate = 50;
            }
            else if(Laura_button.Checked)
            {
                rate = 55;
            }


            /*
             * Charges of all services which keeps increasing as we select them
             */
            decimal services = 0;

            if (Cut_box.Checked)
                services += 30;
            else if (Color_box.Checked)
                services += 40;
            else if (Highlight_box.Checked)
                services += 50;
            else if (Extension_box.Checked)
                services += 200;


            // Can get discount as per people category 
            double discount = 0.00;

            if (Standard_button.Checked)
                discount = 0.00;
            else if (Child_button.Checked)
                discount = 0.10;
            else if (Student_button.Checked)
                discount = 0.05;
            else if (Senior_button.Checked)
                discount = 0.15;


            // Will increse discount as more visitors come
            double visit_discount = 0.00;

            if (visit > 1 && visit < 3)
                visit_discount = 0.00;
            else if (visit > 4 && visit < 8)
                visit_discount = 0.05;
            else if (visit > 9 && visit < 13)
                visit_discount = 0.10;
            else if (visit >= 14)
                visit_discount = 0.15;

            decimal total_price = (rate + services) * (1 - (decimal)discount) * (1 - (decimal)visit_discount);

            price_label.Text = "Total Price = " + total_price.ToString("$00.00");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Jan_button.Checked = true;
            Jan_button.Focus();
            Cut_box.Checked = false;
            Color_box.Checked = false;
            Highlight_box.Checked = false;
            Extension_box.Checked = false;
            Standard_button.Checked = true;
            visit.Clear();
            price_label.Text = "Total Price :";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
