using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Front_End
{
    public partial class Form_Transaksi : UserControl
    {
        Tambah_Transaksi addTransaksi = new Tambah_Transaksi();
        public Form_Transaksi()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=mamodb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addTransaksi.Show();
        }

        private void Form_Transaksi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnRefreshTrans_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            Tambah_Transaksi newTrans = new Tambah_Transaksi();
            newTrans.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Tambah_Transaksi editTrans = new Tambah_Transaksi();
            editTrans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvTransaction.DataSource = null;
            sql = "select * from transactions_select()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvTransaction.DataSource = dt;
            conn.Close();
        }

        private void btnEditTrans_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvTransaction.DataSource = null;
            sql = "select * from transactions_delete(:_id)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvTransaction.DataSource = dt;
            conn.Close();
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvTransaction.Rows[e.RowIndex];
            }
        }
    }
}
