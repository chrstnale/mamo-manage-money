using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            form_Home1.Visible = false;
            form_Transaksi1.Visible = true;
            form_Anggaran1.Visible = false;
            if (btnTransaksi.Focused == true)
            {
                btnTransaksi.BackColor = Color.DarkGreen;
                btnHome.BackColor = panel1.BackColor;
                btnAnggaran.BackColor = panel1.BackColor;
            }
        }

        private void btnAnggaran_Click(object sender, EventArgs e)
        {
            form_Home1.Visible =false;
            form_Transaksi1.Visible = false;
            form_Anggaran1.Visible = true;
            if (btnAnggaran.Focused == true)
            {
                btnAnggaran.BackColor = Color.DarkGreen;
                btnHome.BackColor = panel1.BackColor;
                btnTransaksi.BackColor = panel1.BackColor;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            form_Home1.Visible = true;
            form_Transaksi1.Visible = false;
            form_Anggaran1.Visible = false;
            if (btnHome.Focused == true)
            {
                btnHome.BackColor = Color.DarkGreen;
                btnTransaksi.BackColor = panel1.BackColor;
                btnAnggaran.BackColor = panel1.BackColor;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.DarkGreen;
            btnTransaksi.BackColor = panel1.BackColor;
            btnAnggaran.BackColor = panel1.BackColor;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void form_Home1_Load(object sender, EventArgs e)
        {

        }
    }
}
