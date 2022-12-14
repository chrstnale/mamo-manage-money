using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_End
{
    public partial class Form_Anggaran : UserControl
    {
        public Form_Anggaran()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=mamodb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void btnRefreshBudget_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvBudget.DataSource = null;
            sql = "select * from budget_select()";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvBudget.DataSource = dt;
            conn.Close();
        }

        private void btnAddBudget_Click(object sender, EventArgs e)
        {
            Tambah_Anggaran addAnggaran = new Tambah_Anggaran();
            addAnggaran.Show();
        }

        private void Form_Anggaran_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnDeleteBudget_Click(object sender, EventArgs e)
        {
            conn.Open();
            dgvBudget.DataSource = null;
            sql = "select * from budget_delete(:_id_budget)";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("_id_budget", r.Cells["_id_budget"].Value.ToString());
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dgvBudget.DataSource = dt;
            conn.Close();
        }

        private void dgvBudget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvBudget.Rows[e.RowIndex];

            }
        }
    }
}
