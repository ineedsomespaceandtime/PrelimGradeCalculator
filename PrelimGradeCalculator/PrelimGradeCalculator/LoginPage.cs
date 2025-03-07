using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PrelimGradeCalculator
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "1" && txtPassword.Text == "1")
            {
                new GradeCalculator().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }
        }

       
    }
}
