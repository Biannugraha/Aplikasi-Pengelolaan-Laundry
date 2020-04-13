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
    public partial class Data_Paket : Form
    {
        db_helper dh = new db_helper(connection.con);

        public Data_Paket()
        {
            InitializeComponent();
            Record();
        }
        public void Record()
        {
            dh.LoadGrid(dh.ResultDataTable(@"SELECT * FROM paket"), dataGridView1);
        }
        public void reset()
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            dh.Execute(@"DELETE FROM paket WHERE id_paket='" + textBox1.Text + "'");
            MessageBox.Show("Data Berhasil Di Hapus!");

            Record();
            reset();


        }
        public int id_paket;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id_paket = Convert.ToInt32(row.Cells["id_paket"].Value.ToString());
                textBox1.Text = row.Cells["id_paket"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["id_outlet"].Value.ToString();
                comboBox2.Text = row.Cells["jenis"].Value.ToString();
                textBox4.Text = row.Cells["nama_paket"].Value.ToString();
                textBox5.Text = row.Cells["harga"].Value.ToString();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Data_Paket_Load(object sender, EventArgs e)
        {
            dh.setCombobox("SELECT * FROM outlet", comboBox1, "id_outlet", "nama");
            Record();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {
                dh.Execute(@"INSERT INTO paket (id_outlet,jenis,nama_paket,harga)
            VALUES('" + comboBox1.SelectedValue + "','" + comboBox2.Text + "' , '" + textBox4.Text + "','" + textBox5.Text + "')");

                MessageBox.Show("Data Berhasil Disimpan");
                Record();
                reset();
            }

        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Pastikan Semua Data Terisi !");

            }
            else
            {

                dh.Execute(@"UPDATE paket  SET id_outlet='" + comboBox1.SelectedValue + "', jenis= '" + comboBox2.Text + "', nama_paket= '" + textBox4.Text + "', harga= '" + textBox5.Text + "' WHERE id_paket= '" + textBox1.Text + "'");

                MessageBox.Show("Data Berhasil diubah");
                Record();
                reset();

            }
        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.ResultDataTable(@"SELECT * FROM paket WHERE id_outlet LIKE '%" + textBox6.Text + "%' or nama_paket LIKE '%" + textBox6.Text + "%'");
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Record();
        }

        
    }
}
