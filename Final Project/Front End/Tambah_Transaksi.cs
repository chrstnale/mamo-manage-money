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
    public partial class Tambah_Transaksi : Form
    {
        public Tambah_Transaksi()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=mamodb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void btnBatalTrans_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTransBaru_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                sql = @"select * from transactions_insert(:_type,:_category,:_notes,:_source,:_nominal,:_date)";
                cmd = new NpgsqlCommand(sql, conn);
                if (rbPendapatan.Checked)
                    cmd.Parameters.AddWithValue("_type", "Pendapatan");
                else if(rbPengeluaran.Checked)
                    cmd.Parameters.AddWithValue("_type", "Pengeluaran");
                cmd.Parameters.AddWithValue("_nominal", tbNominalTrans.Text);
                cmd.Parameters.AddWithValue("_category", cbKategoriTrans.Text);
                cmd.Parameters.AddWithValue("_notes", tbNoteTrans.Text);
                cmd.Parameters.AddWithValue("_date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("_source", cbSumberTrans.Text);


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Transaksi Berhasil Masuk!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNoteTrans.Text = tbNominalTrans.Text = cbSumberTrans.Text = cbKategoriTrans.Text  = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tambah_Transaksi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
