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
    public partial class Data_outlet : Form
    {
        db_helper dh = new db_helper(connection.con);

        public Data_outlet()
        {
            InitializeComponent();
            Record();

        }
        public void Record()
        {
            dh.LoadGrid(dh.ResultDataTable(@"Select * FROM outlet"), dataGridView1);
        }
        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


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
            dh.Execute(@"DELETE FROM outlet WHERE id_outlet='" + textBox1.Text + "'");
            MessageBox.Show("Data Berhasil Di Hapus!");
            Record();
            reset();
        }

        private void Data_outlet_Load(object sender, EventArgs e)
        {
            Record();

        }
        public int idoutlet;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idoutlet = Convert.ToInt32(row.Cells["id_outlet"].Value.ToString());
                textBox1.Text = row.Cells["id_outlet"].Value.ToString();
                textBox2.Text = row.Cells["NAMA"].Value.ToString();
                textBox3.Text = row.Cells["Alamat"].Value.ToString();
                textBox4.Text = row.Cells["No_Hp"].Value.ToString();
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
                dh.Execute(@"UPDATE outlet SET nama='" + textBox2.Text + "',alamat='" + textBox3.Text + "'" + ",no_HP='" + textBox4.Text + "' WHERE id_outlet='" + textBox1.Text + "'");

                MessageBox.Show("Data Berhasil Diubah");
                Record();
                reset();
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

                dh.Execute(@"INSERT INTO outlet (nama,alamat,no_hp)
            VALUES ('" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "')");

                MessageBox.Show("Data Berhasil Disimpan");
                Record();
                reset();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.ResultDataTable(@"SELECT * FROM outlet WHERE nama LIKE '%" + textBox6.Text + "%' or alamat LIKE '%" + textBox6.Text + "%'");
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Record();
        }
    }
}
