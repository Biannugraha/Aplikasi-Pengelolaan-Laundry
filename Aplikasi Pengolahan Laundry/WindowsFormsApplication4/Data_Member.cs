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
    public partial class Data_Member : Form
    {
        db_helper dh = new db_helper(connection.con);

        public Data_Member()
        {
            InitializeComponent();
            Record();

        }
        public void Record()
        {
            dh.LoadGrid(dh.ResultDataTable(@"Select * FROM member"), dataGridView1);
        }
        public void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Data_Member_Load(object sender, EventArgs e)
        {
            Record();

        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            dh.Execute(@"DELETE FROM member WHERE id_member='" + textBox1.Text + "'");
            MessageBox.Show("Data Berhail Di Hapus!");
            Record();
            Reset();

        }

        public int idmember;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idmember = Convert.ToInt32(row.Cells["id_member"].Value.ToString());
                textBox1.Text = row.Cells["id_member"].Value.ToString();
                textBox2.Text = row.Cells["nama"].Value.ToString();
                textBox3.Text = row.Cells["alamat"].Value.ToString();
                textBox4.Text = row.Cells["jenis_kelamin"].Value.ToString();
                textBox5.Text = row.Cells["no_hp"].Value.ToString();

            }

        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {
                dh.Execute(@"UPDATE member SET nama='" + textBox2.Text + "', alamat= '" + textBox3.Text + "', jenis_kelamin= '" + textBox4.Text + "', no_hp= '" + textBox5.Text + "' WHERE id_member= '" + textBox1.Text + "'");

                MessageBox.Show("Data Berhasil diubah");
                Record();
                Reset();
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {

                dh.Execute(@"INSERT INTO member (nama,alamat,jenis_kelamin,no_hp)
            VALUES('" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "')");


                MessageBox.Show("Data Berhasil Disimpan");
                Record();
                Reset();

            }
       }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.ResultDataTable(@"SELECT * FROM member WHERE nama LIKE '%" + textBox6.Text + "%' or alamat LIKE '%" + textBox6.Text + "%'");
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Record();
        }
    }
}