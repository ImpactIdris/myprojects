using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Warehouse
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string LUsername = txtUsername.Text;
            string LPassword = txtPassword.Text;
            if ((LUsername == Properties.Settings.Default.Username) && (LPassword == Properties.Settings.Default.Password))
            {
                try
                {
                    MessageBox.Show("You are logged in. Welcome Admin", "Login Message");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                    new ProjectMenu().ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username & Password. Try again","Login Message");
                txtUsername.Text = "Enter your username";
                txtUsername.ForeColor = SystemColors.ActiveBorder;
                txtPassword.ForeColor = SystemColors.ActiveBorder;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Gray;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
            }
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void lnkChangepass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ChangeUser_Pass().ShowDialog();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            exitToolStripMenuItem.ForeColor = Color.Red;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 10.0f, FontStyle.Bold, GraphicsUnit.Point);
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            exitToolStripMenuItem.ForeColor = SystemColors.ControlText;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular, GraphicsUnit.Point);
        }

    }
}
