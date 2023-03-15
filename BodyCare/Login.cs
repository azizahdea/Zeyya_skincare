using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BodyCare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin")
            {
                new Form1().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username atau Password Salah!");
                username.Clear();
                password.Clear();
                username.Focus();
            }
        }
    }
}
