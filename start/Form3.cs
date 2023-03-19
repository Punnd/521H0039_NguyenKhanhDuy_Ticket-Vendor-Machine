using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace start
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            

            form2.ShowDialog();

        }



        private void button1_Click(object sender, EventArgs e)
        {

         

        }

        private void button2_Click(object sender, EventArgs e)
        {

          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox6.Visible = false;
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox3.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string destination = Form2.destination;
            string price = Form2.price;
            bill.Clear();
            bill.Text += "***********************************************\n\n";
            bill.Text += "************         TICKET        ************\n\n";
            bill.Text += "***********************************************\n\n";
            bill.Text += "Date: " + DateTime.Now + "\n\n";

            bill.Text += "Destination: " + destination + "\n\n";
            bill.Text += "Price: " + price + "\n\n";





            bill.Text += "**************************************************\n\n"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(bill.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
    }
}
