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

namespace veriTabaniÖdev
{
    public partial class Form2 : Form
    {
        SqlCommand command;

        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-KJPATGFL\\MSSQLSERVER2;Initial Catalog=mertcan;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from view1";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string sorgu = "exec procedure1";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            baglanti.Open();
            string sorgu = "exec procedure2";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urun_ad;
            urun_ad = textBox1.Text;
            baglanti.Open();
            string sorgu = "SELECT * From Urun where Urun.Ürün_Ad = '" + urun_ad + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dataGridView1.DataSource = dtable;
            baglanti.Close();
        }
    }
}
