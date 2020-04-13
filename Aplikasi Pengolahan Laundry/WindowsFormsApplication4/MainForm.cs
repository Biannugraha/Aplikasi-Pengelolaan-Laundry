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
    public partial class MainForm : Form
    {
        public MainForm(string role)
        {

            InitializeComponent();
            label8.Text = role;
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Owner" || label8.Text == "Kasir")
            {
                MessageBox.Show("Harap Hubungi Admin!");
            }
            else
            {
                Data_User us = new Data_User();
                us.Show();
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Owner")
            {
                MessageBox.Show("Harap Hubungi Admin!");
            }
            else
            {
                Data_Member mem = new Data_Member();
                mem.Show();

            }
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Owner" || label8.Text == "Kasir")
            {
                MessageBox.Show("Harap Hubungi Admin!");
            }
            else
            {
                Data_outlet ot = new Data_outlet();
                ot.Show();
            }

        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Owner" || label8.Text == "Kasir")
            {
                MessageBox.Show("Harap Hubungi Admin!");
            }
            else
            {
                Data_Paket pt = new Data_Paket();
                pt.Show();
            }

        }

        private void gunaImageButton6_Click(object sender, EventArgs e)
        {
            {
                if (label8.Text == "Owner" || label8.Text == "Kasir")
                {
                    MessageBox.Show("Harap Hubungi Admin!");
                }
                else
                {
                    Transaksi trs = new Transaksi();
                    trs.Show();
                }

            }
        }

        private void gunaImageButton7_Click(object sender, EventArgs e)
        {
            Data_Laporan lap = new Data_Laporan();
            lap.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Akan Keluar?", "Sukses", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {

                Data_login log = new Data_login();
                log.Show();
                this.Hide();
            }
            else
            {
                //Nothing
            }

        }
    }
}
