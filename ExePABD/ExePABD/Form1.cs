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

namespace ExePABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sanada = new SqlConnection(@"Data Source=ANDY-DAFFA;Initial Catalog=login;Integrated Security=True");
            SqlDataAdapter rush = new SqlDataAdapter("select count(*) from LogPABD where Nama = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", sanada);
            DataTable xs = new DataTable();
            rush.Fill(xs);
            if (xs.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 clash = new Form2();
                clash.Show();

            }
            else
            {
                MessageBox.Show("Nama atau password salah !", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
