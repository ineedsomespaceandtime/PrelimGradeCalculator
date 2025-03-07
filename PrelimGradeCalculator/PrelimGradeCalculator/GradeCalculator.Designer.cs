namespace PrelimGradeCalculator
{
    partial class GradeCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeCalculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrelim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lbClear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbVerdict = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnReturnToMenu = new PrelimGradeCalculator.CustomButton();
            this.btnCompute = new PrelimGradeCalculator.CustomButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAssignment);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(121, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(355, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Standing";
            // 
            // txtAssignment
            // 
            this.txtAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignment.Location = new System.Drawing.Point(180, 35);
            this.txtAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAssignment.MaxLength = 3;
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.Size = new System.Drawing.Size(147, 34);
            this.txtAssignment.TabIndex = 3;
            this.txtAssignment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLab2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtLab1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(121, 252);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(355, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laboratory Activities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Laboratory Activity 2";
            // 
            // txtLab2
            // 
            this.txtLab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab2.Location = new System.Drawing.Point(244, 74);
            this.txtLab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLab2.MaxLength = 3;
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(89, 34);
            this.txtLab2.TabIndex = 1;
            this.txtLab2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Laboratory Activity 1";
            // 
            // txtLab1
            // 
            this.txtLab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLab1.Location = new System.Drawing.Point(244, 29);
            this.txtLab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLab1.MaxLength = 3;
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(89, 34);
            this.txtLab1.TabIndex = 3;
            this.txtLab1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtQuiz2);
            this.groupBox3.Controls.Add(this.txtQuiz1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(121, 374);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(355, 113);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quizzes";
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz2.Location = new System.Drawing.Point(180, 68);
            this.txtQuiz2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuiz2.MaxLength = 3;
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(147, 34);
            this.txtQuiz2.TabIndex = 1;
            this.txtQuiz2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz1.Location = new System.Drawing.Point(180, 30);
            this.txtQuiz1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuiz1.MaxLength = 3;
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(147, 34);
            this.txtQuiz1.TabIndex = 3;
            this.txtQuiz1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPrelim);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox4.Location = new System.Drawing.Point(121, 491);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(355, 80);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prelim Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Exam Score";
            // 
            // txtPrelim
            // 
            this.txtPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelim.Location = new System.Drawing.Point(186, 33);
            this.txtPrelim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrelim.MaxLength = 3;
            this.txtPrelim.Name = "txtPrelim";
            this.txtPrelim.Size = new System.Drawing.Size(147, 34);
            this.txtPrelim.TabIndex = 6;
            this.txtPrelim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLab2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MidnightBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 36);
            this.label9.TabIndex = 13;
            this.label9.Text = "Your Grade:";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.ForeColor = System.Drawing.Color.White;
            this.txtResults.Location = new System.Drawing.Point(81, 376);
            this.txtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(292, 62);
            this.txtResults.TabIndex = 10;
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClear.ForeColor = System.Drawing.Color.White;
            this.lbClear.Location = new System.Drawing.Point(349, 579);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(127, 24);
            this.lbClear.TabIndex = 12;
            this.lbClear.Text = "Clear Fields";
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(157, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "X STUDENT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(81, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "\tB.S. INFORMATION TECHNOLOGY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVerdict
            // 
            this.lbVerdict.AutoSize = true;
            this.lbVerdict.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbVerdict.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVerdict.ForeColor = System.Drawing.Color.White;
            this.lbVerdict.Location = new System.Drawing.Point(177, 453);
            this.lbVerdict.Name = "lbVerdict";
            this.lbVerdict.Size = new System.Drawing.Size(110, 35);
            this.lbVerdict.TabIndex = 17;
            this.lbVerdict.Text = "label11";
            this.lbVerdict.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtResults);
            this.panel1.Controls.Add(this.lbVerdict);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReturnToMenu);
            this.panel1.Controls.Add(this.btnCompute);
            this.panel1.Location = new System.Drawing.Point(577, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 661);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(76, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quiz 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quiz 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Assignment";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReturnToMenu.FlatAppearance.BorderSize = 0;
            this.btnReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReturnToMenu.Location = new System.Drawing.Point(234, 497);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(162, 76);
            this.btnReturnToMenu.TabIndex = 9;
            this.btnReturnToMenu.Text = "Return to Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCompute.Location = new System.Drawing.Point(70, 497);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(158, 76);
            this.btnCompute.TabIndex = 8;
            this.btnCompute.Text = "Compute Grades";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // GradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1021, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GradeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradeCalculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz1;
        private CustomButton btnCompute;
        private CustomButton btnReturnToMenu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrelim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lbClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lbVerdict;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}