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
    public partial class Tambah_Transaksi : Form
    {
        public Tambah_Transaksi()
        {
            InitializeComponent();
        }

        private void btnBatalTrans_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
