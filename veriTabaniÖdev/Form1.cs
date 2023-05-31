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
    public partial class Form1 : Form
    {
        SqlCommand command;

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-KJPATGFL\\MSSQLSERVER2;Initial Catalog=mertcan;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = textBox1.Text;
            password = textBox2.Text;

            string query = "SELECT Kullanıcı_Ad, Şifre FROM Kullanıcı where Kullanıcı_Ad = '" + textBox1.Text + "' AND  Şifre = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);


            if (dtable.Rows.Count > 0)
            {
                username = textBox1.Text;
                password = textBox2.Text;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Yanlış Şifre veya Kullanıcı Adı girdiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();

                textBox1.Focus();
            }
        }
    }
}
