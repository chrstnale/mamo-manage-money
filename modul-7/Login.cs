using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul_7
{
    public partial class Login : Form
    {

        Transaksi transaksi = new Transaksi();
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user= new User(tbEmail.Text, tbPassword.Text);
            if (user.Login(user.LoginName, user.Password))
            {
                transaksi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
