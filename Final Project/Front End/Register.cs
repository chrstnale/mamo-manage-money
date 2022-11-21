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
using System.Xml.Linq;

namespace Front_End
{
    public partial class Register : Form
    {
        //Login login = new Login();
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=4321;Username=postgres;Password=A15p12D15;Database=mamo;";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        public Register()
        {
            InitializeComponent();
            lblWelcome1.Parent = pictureBox1;
            lblWelcome2.Parent = pictureBox1;
            lblWelcome1.BackColor = Color.Transparent;
            lblWelcome2.BackColor = Color.Transparent;
        }

        private void btnKeRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {
            conn.Open();
            sql = @"select * from user_insert(:_name,:_email,:_password)";
            cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("_name", tbNama.Text);
            cmd.Parameters.AddWithValue("_email", tbEmail.Text);
            cmd.Parameters.AddWithValue("_password", tbPassword.Text);
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Selamat Datang " + tbNama.Text + "!", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                this.Hide();
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
