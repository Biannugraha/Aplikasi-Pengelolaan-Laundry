using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Data_User : Form
    {
        db_helper dh = new db_helper(connection.con);
        public Data_User()
        {
            InitializeComponent();
            Record();
        }
        public void Record()
        {
            dh.LoadGrid(dh.ResultDataTable(@"Select * FROM [user]"), dataGridView1);
        }
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void Data_admin_Load(object sender, EventArgs e)
        {
            dh.setCombobox("SELECT * FROM outlet", comboBox1, "id_outlet", "nama");
            Record();
        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            dh.Execute(@"DELETE FROM [user] WHERE id_user='" + textBox1.Text + "'");
            MessageBox.Show("Data Berhasil Di Hapus!");

            Record();
            reset();
        }
        public int iduser;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                iduser = Convert.ToInt32(row.Cells["id_user"].Value.ToString());

                textBox1.Text = row.Cells["id_user"].Value.ToString();
                textBox2.Text = row.Cells["nama"].Value.ToString();
                textBox3.Text = row.Cells["username"].Value.ToString();
                textBox4.Text = row.Cells["password"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["id_outlet"].Value.ToString();
                comboBox2.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {
                dh.Execute(@"INSERT INTO [user] (nama,username,password,id_outlet,role)
            VALUES('" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + comboBox1.SelectedValue + "','" + comboBox2.Text + "')");

                MessageBox.Show("Data Berhasil Disimpan");
                Record();
                reset();
            }
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {
                dh.Execute(@"UPDATE [user]  SET nama='" + textBox2.Text + "', username= '" + textBox3.Text + "', password= '" + textBox4.Text + "', id_outlet= '" + comboBox1.SelectedValue + "', role= '" + comboBox1.Text + "' WHERE id_user = '" + textBox1.Text + "'");

                MessageBox.Show("Data Berhasil diubah");

                Record();
                reset();



            }

        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.ResultDataTable(@"SELECT * FROM [user] WHERE nama LIKE '%" + textBox6.Text + "%' or username LIKE '%" + textBox6.Text + "%'");
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Record();
        }
    }
}
 
    
                

