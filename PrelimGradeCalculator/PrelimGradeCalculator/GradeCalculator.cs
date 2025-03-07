using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;

namespace PrelimGradeCalculator
{
    public partial class GradeCalculator: Form
    {
       

        public GradeCalculator()
        {
            InitializeComponent();
        }
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //declaration
            double assignment = double.Parse(txtAssignment.Text);
            double quiz1 = double.Parse(txtQuiz1.Text);
            double quiz2 = double.Parse(txtQuiz2.Text);
            double lab1 = double.Parse(txtLab1.Text);
            double lab2 = double.Parse(txtLab2.Text);
            double prelimExam = double.Parse(txtPrelim.Text);
            
            //formula
            double quizAverage = quiz1 + quiz2;
            double prelimExamAverage = (prelimExam / 60) * 100;
            double labAverage = (lab1 + lab2) / 2;
            double classStanding = assignment + 10;

            //Final Prelim Grade
            double prelimGrade = (quizAverage * 0.25) + (prelimExam * 0.30) + (labAverage * 0.25) + (classStanding * 0.20) + 10;

            //display results
            txtResults.Text = prelimGrade.ToString("");

            //Display if Passed or Not
            lbVerdict.Text = prelimGrade >= 70 ? "Passed" : "Failed";
            txtResults.ForeColor = prelimGrade >= 70 ? Color.Green : Color.Red;
            lbVerdict.ForeColor = prelimGrade >= 70 ? Color.Green : Color.Red;
            lbVerdict.Visible = true;
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        //to clear all textboxes fields
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        // to clear all text boxes 
       private void lbClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            lbVerdict.Visible = false;
        }
        
        // so that only numbers are allowed 
        private void txtLab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
    }

}
