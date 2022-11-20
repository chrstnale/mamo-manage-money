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
            lblWelcome1.Parent = pb1;
            lblWelcome2.Parent = pb1;
            lblWelcome1.BackColor = Color.Transparent;
            lblWelcome2.BackColor = Color.Transparent;
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

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
