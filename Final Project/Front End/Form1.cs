﻿using System;
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
            form_Transaksi1.Visible = true;
            form_Anggaran1.Visible = false;
            if (btnTransaksi.Focused == true)
            {
                btnTransaksi.BackColor = Color.ForestGreen;
                btnAnggaran.BackColor = panel1.BackColor;
            }
        }

        private void btnAnggaran_Click(object sender, EventArgs e)
        {
            form_Transaksi1.Visible = false;
            form_Anggaran1.Visible = true;
            if (btnAnggaran.Focused == true)
            {
                btnAnggaran.BackColor = Color.ForestGreen;
                btnTransaksi.BackColor = panel1.BackColor;
            }
        }
    }
}