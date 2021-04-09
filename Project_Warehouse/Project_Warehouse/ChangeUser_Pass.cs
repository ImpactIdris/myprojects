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
    public partial class ChangeUser_Pass : Form
    {
        public ChangeUser_Pass()
        {
            InitializeComponent();
        }

        private void btnClearCl_Click(object sender, EventArgs e)
        {
            txtOldPassword.Clear();
            txtNewUsername.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
        }

        private void btnCancelCl_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void txtOldPassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "Enter your old password")
            {
                txtOldPassword.Text = "";
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            try
            {

            if ((txtOldPassword.Text == "") || (txtNewUsername.Text == "") || (txtNewPassword.Text == "") || (txtConfirmNewPassword.Text == ""))
            {
                MessageBox.Show("Field(s) is empty! Complete your information.", "Login information");
            }
            
            if ((txtNewPassword.Text != "") && (txtNewPassword.Text == txtConfirmNewPassword.Text) && (txtNewUsername.Text != "") && (txtOldPassword.Text == Properties.Settings.Default.Password))
            {

                Properties.Settings.Default.Username = txtNewUsername.Text;
                Properties.Settings.Default.Password = txtConfirmNewPassword.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Login information is saved", "Login Message");
                this.Hide();
                new Login().ShowDialog();
            }
            else if ((txtOldPassword.Text != "") && (txtOldPassword.Text != "Enter your old password") && (txtOldPassword.Text != Properties.Settings.Default.Password))
            {
                MessageBox.Show("You have entered an incorrect Old password, try again!", "Login information");
            }
            else if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Your new password confirmation is incorrect, try again!", "Login information");

            }
          /*  
            else
            {
                MessageBox.Show("Change is incomplete");
            } */
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
