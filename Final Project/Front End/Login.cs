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
    public partial class Login : Form
    {
        Form1 main = new Form1();
        Register register = new Register();
        public Login()
        {
            InitializeComponent();
            lblWelcome1.Parent = pictureBox1;
            lblWelcome2.Parent = pictureBox1;
            lblWelcome1.BackColor = Color.Transparent;
            lblWelcome2.BackColor = Color.Transparent;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            main.Show();
        }

        private void btnKeRegister_Click(object sender, EventArgs e)
        {
            register.Show();
        }
    }
}
