namespace QuestionBank
{
    partial class frmMain
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
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.btnAddLession = new System.Windows.Forms.Button();
            this.pnlAddLession = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameLession = new System.Windows.Forms.TextBox();
            this.btnTwelfthGrade = new System.Windows.Forms.Button();
            this.btnEleventhGrade = new System.Windows.Forms.Button();
            this.btnTenthGrade = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTenthGrade = new System.Windows.Forms.Label();
            this.lblEleventhGrade = new System.Windows.Forms.Label();
            this.lblTwelfthGrade = new System.Windows.Forms.Label();
            this.btnShowExam = new System.Windows.Forms.Button();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gboxUser = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pnlAddLession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gboxUser.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Location = new System.Drawing.Point(12, 36);
            this.btnAddQuestions.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(199, 42);
            this.btnAddQuestions.TabIndex = 0;
            this.btnAddQuestions.Text = "اضافه کردن سوال";
            this.btnAddQuestions.UseVisualStyleBackColor = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.lblAddQuestions_Click);
            // 
            // btnAddLession
            // 
            this.btnAddLession.Location = new System.Drawing.Point(11, 86);
            this.btnAddLession.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddLession.Name = "btnAddLession";
            this.btnAddLession.Size = new System.Drawing.Size(199, 42);
            this.btnAddLession.TabIndex = 1;
            this.btnAddLession.Text = "اضافه کردن درس";
            this.btnAddLession.UseVisualStyleBackColor = true;
            this.btnAddLession.Click += new System.EventHandler(this.btnAddLession_Click);
            // 
            // pnlAddLession
            // 
            this.pnlAddLession.Controls.Add(this.btnSave);
            this.pnlAddLession.Controls.Add(this.label1);
            this.pnlAddLession.Controls.Add(this.txtNameLession);
            this.pnlAddLession.Location = new System.Drawing.Point(12, 192);
            this.pnlAddLession.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlAddLession.Name = "pnlAddLession";
            this.pnlAddLession.Size = new System.Drawing.Size(199, 158);
            this.pnlAddLession.TabIndex = 2;
            this.pnlAddLession.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Vazir Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(57, 149);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 24);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.TextChanged += new System.EventHandler(this.lblWarning_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 98);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "اضافه کردن درس";
            // 
            // txtNameLession
            // 
            this.txtNameLession.Location = new System.Drawing.Point(25, 50);
            this.txtNameLession.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNameLession.Name = "txtNameLession";
            this.txtNameLession.Size = new System.Drawing.Size(149, 40);
            this.txtNameLession.TabIndex = 2;
            // 
            // btnTwelfthGrade
            // 
            this.btnTwelfthGrade.Location = new System.Drawing.Point(158, 187);
            this.btnTwelfthGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTwelfthGrade.Name = "btnTwelfthGrade";
            this.btnTwelfthGrade.Size = new System.Drawing.Size(106, 42);
            this.btnTwelfthGrade.TabIndex = 6;
            this.btnTwelfthGrade.Text = "دوازدهم";
            this.btnTwelfthGrade.UseVisualStyleBackColor = true;
            this.btnTwelfthGrade.Click += new System.EventHandler(this.btnTwelfthGrade_Click);
            // 
            // btnEleventhGrade
            // 
            this.btnEleventhGrade.Location = new System.Drawing.Point(158, 139);
            this.btnEleventhGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEleventhGrade.Name = "btnEleventhGrade";
            this.btnEleventhGrade.Size = new System.Drawing.Size(106, 42);
            this.btnEleventhGrade.TabIndex = 6;
            this.btnEleventhGrade.Text = "یازدهم";
            this.btnEleventhGrade.UseVisualStyleBackColor = true;
            this.btnEleventhGrade.Click += new System.EventHandler(this.btnEleventhGrade_Click);
            // 
            // btnTenthGrade
            // 
            this.btnTenthGrade.Location = new System.Drawing.Point(158, 94);
            this.btnTenthGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTenthGrade.Name = "btnTenthGrade";
            this.btnTenthGrade.Size = new System.Drawing.Size(106, 42);
            this.btnTenthGrade.TabIndex = 6;
            this.btnTenthGrade.Text = "دهم";
            this.btnTenthGrade.UseVisualStyleBackColor = true;
            this.btnTenthGrade.Click += new System.EventHandler(this.btnTenthGrade_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "تعداد سوالات";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "پایه";
            // 
            // lblTenthGrade
            // 
            this.lblTenthGrade.AutoSize = true;
            this.lblTenthGrade.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenthGrade.ForeColor = System.Drawing.Color.Red;
            this.lblTenthGrade.Location = new System.Drawing.Point(50, 99);
            this.lblTenthGrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenthGrade.Name = "lblTenthGrade";
            this.lblTenthGrade.Size = new System.Drawing.Size(26, 32);
            this.lblTenthGrade.TabIndex = 8;
            this.lblTenthGrade.Text = "0";
            // 
            // lblEleventhGrade
            // 
            this.lblEleventhGrade.AutoSize = true;
            this.lblEleventhGrade.BackColor = System.Drawing.SystemColors.Control;
            this.lblEleventhGrade.ForeColor = System.Drawing.Color.Red;
            this.lblEleventhGrade.Location = new System.Drawing.Point(50, 144);
            this.lblEleventhGrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEleventhGrade.Name = "lblEleventhGrade";
            this.lblEleventhGrade.Size = new System.Drawing.Size(26, 32);
            this.lblEleventhGrade.TabIndex = 9;
            this.lblEleventhGrade.Text = "0";
            // 
            // lblTwelfthGrade
            // 
            this.lblTwelfthGrade.AutoSize = true;
            this.lblTwelfthGrade.BackColor = System.Drawing.SystemColors.Control;
            this.lblTwelfthGrade.ForeColor = System.Drawing.Color.Red;
            this.lblTwelfthGrade.Location = new System.Drawing.Point(50, 192);
            this.lblTwelfthGrade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTwelfthGrade.Name = "lblTwelfthGrade";
            this.lblTwelfthGrade.Size = new System.Drawing.Size(26, 32);
            this.lblTwelfthGrade.TabIndex = 10;
            this.lblTwelfthGrade.Text = "0";
            // 
            // btnShowExam
            // 
            this.btnShowExam.Location = new System.Drawing.Point(8, 40);
            this.btnShowExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowExam.Name = "btnShowExam";
            this.btnShowExam.Size = new System.Drawing.Size(263, 50);
            this.btnShowExam.TabIndex = 8;
            this.btnShowExam.Text = "نمایش سوالات";
            this.btnShowExam.UseVisualStyleBackColor = true;
            this.btnShowExam.Click += new System.EventHandler(this.btnShowExam_Click);
            // 
            // btnShowUser
            // 
            this.btnShowUser.Location = new System.Drawing.Point(8, 40);
            this.btnShowUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(263, 50);
            this.btnShowUser.TabIndex = 8;
            this.btnShowUser.Text = "نمایش کاربران";
            this.btnShowUser.UseVisualStyleBackColor = true;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(8, 40);
            this.btnCreateExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(203, 50);
            this.btnCreateExam.TabIndex = 8;
            this.btnCreateExam.Text = "ساخت آزمون";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWarning);
            this.groupBox1.Controls.Add(this.btnAddQuestions);
            this.groupBox1.Controls.Add(this.btnAddLession);
            this.groupBox1.Controls.Add(this.pnlAddLession);
            this.groupBox1.Location = new System.Drawing.Point(298, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 362);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateExam);
            this.groupBox2.Location = new System.Drawing.Point(298, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "آزمون";
            // 
            // gboxUser
            // 
            this.gboxUser.Controls.Add(this.btnShowUser);
            this.gboxUser.Location = new System.Drawing.Point(13, 380);
            this.gboxUser.Name = "gboxUser";
            this.gboxUser.Size = new System.Drawing.Size(278, 125);
            this.gboxUser.TabIndex = 14;
            this.gboxUser.TabStop = false;
            this.gboxUser.Text = "کاربران";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTwelfthGrade);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblEleventhGrade);
            this.groupBox4.Controls.Add(this.btnTwelfthGrade);
            this.groupBox4.Controls.Add(this.lblTenthGrade);
            this.groupBox4.Controls.Add(this.btnEleventhGrade);
            this.groupBox4.Controls.Add(this.btnTenthGrade);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 240);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تعداد سوالات";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnShowExam);
            this.groupBox5.Location = new System.Drawing.Point(13, 258);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 116);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "سوالات";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gboxUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Vazir Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAddLession.ResumeLayout(false);
            this.pnlAddLession.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gboxUser.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestions;
        private System.Windows.Forms.Button btnAddLession;
        private System.Windows.Forms.Panel pnlAddLession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameLession;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnTwelfthGrade;
        private System.Windows.Forms.Button btnEleventhGrade;
        private System.Windows.Forms.Button btnTenthGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTenthGrade;
        private System.Windows.Forms.Label lblEleventhGrade;
        private System.Windows.Forms.Label lblTwelfthGrade;
        private System.Windows.Forms.Button btnShowExam;
        private System.Windows.Forms.Button btnShowUser;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gboxUser;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

