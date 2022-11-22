using Npgsql;
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
using System.Globalization;

namespace Front_End
{
    public partial class Tambah_Anggaran : Form
    {
        public Tambah_Anggaran()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=mamodb";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private void Tambah_Anggaran_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnAddTransBaru_Click(object sender, EventArgs e)
        {
            try
            {
                var date= DateTime.Now;
                var datewotime = date.Date;
                var dateoneweek = datewotime.AddDays(6);
                var dateonemonth = datewotime.AddMonths(1);
                var dateoneyear = datewotime.AddYears(1);
                conn.Open();
                sql = @"select * from budget_insert(:_category,:_nominal,:_tanggalawal,:_tanggalakhir);";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_category", cbKategoriBudget.Text);
                cmd.Parameters.AddWithValue("_nominal", float.Parse(tbNominalBudget.Text, CultureInfo.InvariantCulture.NumberFormat));
                if (cbOpsiBudget.Text == "Mingguan")
                {
                    cmd.Parameters.AddWithValue("_tanggalawal", datewotime.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("_tanggalakhir", dateoneweek.ToString("dd/MM/yyyy"));
                    //sql = @"insert into tb_budget(_tanggalawal,_tanggalakhir) values (date_trunc('week', current_date), date_trunc('week', current_date) + interval '1 WEEK' - interval '1 DAY');";
                }
                else if (cbOpsiBudget.Text == "Bulanan")
                {
                    cmd.Parameters.AddWithValue("_tanggalawal", datewotime.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("_tanggalakhir", dateonemonth.ToString("dd/MM/yyyy"));
                    //sql = @"insert into tb_budget (_tanggalawal, _tanggalakhir) values (date_trunc('month',  current_date), date_trunc('month', current_date) + interval '1 MONTH' - interval '1 DAY');";
                }
                else if (cbOpsiBudget.Text == "Tahunan")
                {
                    cmd.Parameters.AddWithValue("_tanggalawal", datewotime.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("_tanggalakhir", dateoneyear.ToString("dd/MM/yyyy"));
                    //sql = @"insert into tb_budget (_tanggalawal, _tanggalakhir) values (date_trunc('year',  current_date), date_trunc('year', current_date) + interval '1 YEAR' - interval '1 DAY');";
                }
                    
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Anggaran Berhasil Masuk!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNominalBudget.Text = cbKategoriBudget.Text = cbOpsiBudget.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
