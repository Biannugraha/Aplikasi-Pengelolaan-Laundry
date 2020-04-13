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

namespace WindowsFormsApplication4
{
    public partial class Data_login : Form
    {
        public Data_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.log.Open();
            SqlCommand com = new SqlCommand("SELECT COUNT (*) FROM [user] WHERE username='" + textBox1.Text + "'", connection.log);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            connection.log.Close();
            if (temp == 1)
            {
                connection.log.Open();
                SqlCommand com2 = new SqlCommand("SELECT COUNT (*) FROM [user] WHERE Password='" + textBox2.Text + "'",
                    connection.log);
                int temp2 = Convert.ToInt32(com2.ExecuteScalar().ToString());
                connection.log.Close();
                if (temp2 == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT role FROM [user] WHERE username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", connection.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        MainForm ds = new MainForm(dt.Rows[0][0].ToString());
                        ds.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password Salah! Mohon Periksa Ulang");

                }
            }
            else
            {
                MessageBox.Show("username Salah! Mohon Periksa Ulang");
            }
        }

        private void Data_login_Load(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }
    }

}
       