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
    public partial class Form_Transaksi : UserControl
    {
        Tambah_Transaksi addTransaksi = new Tambah_Transaksi();
        public Form_Transaksi()
        {
            InitializeComponent();
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            addTransaksi.Show();
        }

        private void Form_Transaksi_Load(object sender, EventArgs e)
        {

        }
    }
}
