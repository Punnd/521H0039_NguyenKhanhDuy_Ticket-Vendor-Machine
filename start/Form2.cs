using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace start
{
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection("initial catalog = ticket; data source = LAPTOP-90QEEVDN; integrated security = true");
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable tb;
        SqlCommand cm;
        SqlDataReader dr;
        public static string destination;
        public static string price;

        public Form2()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = ticket; data source = LAPTOP-90QEEVDN; integrated security = true";
            //sql = "server = <ten sever>; database = <ten database>; uid = ; pwd = ";
            cn = new SqlConnection(sql);
            cn.Open();
            //showHT();
            showHT1();

            start form1 = new start();

            form1.ShowDialog();

        }

        void showHT()
        {
            des.Items.Add("Vũng Tàu");
            des.Items.Add("Tây Ninh");
            des.Items.Add("Thủ Đức");
            des.Items.Add("Quận 12");

        }

        void showHT1()
        {
            string sql = "select distinct place from destination";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            des.DataSource = tb;
            des.ValueMember = "place";
            des.DisplayMember = "place";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            destination = des.Text;
            price = txtprice.Text;

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select * from destination where place = @des";
            cm = new SqlCommand(s, conn);
            cm.Parameters.AddWithValue("@des", des.Text);

            conn.Open();
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                string price = dr["price"].ToString() + " VND ";
                txtprice.Text = price;
            }

            conn.Close();

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
