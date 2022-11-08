using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;


namespace modul_7
{
    public partial class Transaksi : Form
    {

        public Transaksi()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=mamodb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void Transaksi_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblJenis_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_type,:_nominal,:_category,:_notes,:_date,:_source)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_type", cbJenis.Text);
                cmd.Parameters.AddWithValue("_nominal", tbNominal.Text);
                cmd.Parameters.AddWithValue("_category", cbKategori.Text);
                cmd.Parameters.AddWithValue("_notes", tbCatatan.Text);
                cmd.Parameters.AddWithValue("_date", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("_source", cbSumber.Text);


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Transaksi Berhasil Masuk!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbCatatan.Text = tbNominal.Text = cbJenis.Text = cbKategori.Text = cbSumber.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
