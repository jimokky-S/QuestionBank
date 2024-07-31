namespace QuestionBank
{
    partial class frmTestQuestionAdd
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
            this.gboxTestQuestion = new System.Windows.Forms.GroupBox();
            this.btnSaveandCloseTestQuestion = new System.Windows.Forms.Button();
            this.btnInsertTestQuestion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTestQuestion = new System.Windows.Forms.TextBox();
            this.lblMessageQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxTestQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxTestQuestion
            // 
            this.gboxTestQuestion.Controls.Add(this.btnSaveandCloseTestQuestion);
            this.gboxTestQuestion.Controls.Add(this.btnInsertTestQuestion);
            this.gboxTestQuestion.Controls.Add(this.label8);
            this.gboxTestQuestion.Controls.Add(this.txtOption4);
            this.gboxTestQuestion.Controls.Add(this.label7);
            this.gboxTestQuestion.Controls.Add(this.txtOption3);
            this.gboxTestQuestion.Controls.Add(this.label6);
            this.gboxTestQuestion.Controls.Add(this.txtOption2);
            this.gboxTestQuestion.Controls.Add(this.label5);
            this.gboxTestQuestion.Controls.Add(this.txtOption1);
            this.gboxTestQuestion.Controls.Add(this.label4);
            this.gboxTestQuestion.Controls.Add(this.txtTestQuestion);
            this.gboxTestQuestion.Controls.Add(this.lblMessageQuestion);
            this.gboxTestQuestion.Controls.Add(this.label2);
            this.gboxTestQuestion.Location = new System.Drawing.Point(1, 0);
            this.gboxTestQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gboxTestQuestion.Name = "gboxTestQuestion";
            this.gboxTestQuestion.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gboxTestQuestion.Size = new System.Drawing.Size(915, 369);
            this.gboxTestQuestion.TabIndex = 0;
            this.gboxTestQuestion.TabStop = false;
            this.gboxTestQuestion.Text = "سوال تستی";
            this.gboxTestQuestion.Enter += new System.EventHandler(this.gboxTestQuestion_Enter);
            // 
            // btnSaveandCloseTestQuestion
            // 
            this.btnSaveandCloseTestQuestion.Location = new System.Drawing.Point(318, 257);
            this.btnSaveandCloseTestQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveandCloseTestQuestion.Name = "btnSaveandCloseTestQuestion";
            this.btnSaveandCloseTestQuestion.Size = new System.Drawing.Size(111, 44);
            this.btnSaveandCloseTestQuestion.TabIndex = 6;
            this.btnSaveandCloseTestQuestion.Text = "ذخیره نهایی";
            this.btnSaveandCloseTestQuestion.UseVisualStyleBackColor = true;
            this.btnSaveandCloseTestQuestion.Click += new System.EventHandler(this.btnSaveandCloseTestQuestion_Click);
            // 
            // btnInsertTestQuestion
            // 
            this.btnInsertTestQuestion.Location = new System.Drawing.Point(435, 257);
            this.btnInsertTestQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertTestQuestion.Name = "btnInsertTestQuestion";
            this.btnInsertTestQuestion.Size = new System.Drawing.Size(88, 44);
            this.btnInsertTestQuestion.TabIndex = 5;
            this.btnInsertTestQuestion.Text = "ثبت سوال";
            this.btnInsertTestQuestion.UseVisualStyleBackColor = true;
            this.btnInsertTestQuestion.Click += new System.EventHandler(this.btnInsertTestQuestion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(837, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "گزینه ها";
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(54, 219);
            this.txtOption4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(707, 28);
            this.txtOption4.TabIndex = 4;
            this.txtOption4.TextChanged += new System.EventHandler(this.txtOption4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "د:";
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(54, 181);
            this.txtOption3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(707, 28);
            this.txtOption3.TabIndex = 3;
            this.txtOption3.TextChanged += new System.EventHandler(this.txtOption3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(783, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "ج:";
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(54, 143);
            this.txtOption2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(707, 28);
            this.txtOption2.TabIndex = 2;
            this.txtOption2.TextChanged += new System.EventHandler(this.txtOption2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "ب:";
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(54, 105);
            this.txtOption1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(707, 28);
            this.txtOption1.TabIndex = 1;
            this.txtOption1.TextChanged += new System.EventHandler(this.txtOption1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "الف:";
            // 
            // txtTestQuestion
            // 
            this.txtTestQuestion.Location = new System.Drawing.Point(54, 67);
            this.txtTestQuestion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTestQuestion.Name = "txtTestQuestion";
            this.txtTestQuestion.Size = new System.Drawing.Size(707, 28);
            this.txtTestQuestion.TabIndex = 0;
            this.txtTestQuestion.TextChanged += new System.EventHandler(this.txtTestQuestion_TextChanged);
            // 
            // lblMessageQuestion
            // 
            this.lblMessageQuestion.AutoSize = true;
            this.lblMessageQuestion.Location = new System.Drawing.Point(395, 320);
            this.lblMessageQuestion.Name = "lblMessageQuestion";
            this.lblMessageQuestion.Size = new System.Drawing.Size(0, 21);
            this.lblMessageQuestion.TabIndex = 11;
            this.lblMessageQuestion.Click += new System.EventHandler(this.lblMessageQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "متن سوال";
            // 
            // frmTestQuestionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 372);
            this.Controls.Add(this.gboxTestQuestion);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTestQuestionAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmTestQuestionAdd_Load);
            this.gboxTestQuestion.ResumeLayout(false);
            this.gboxTestQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTestQuestion;
        private System.Windows.Forms.Button btnSaveandCloseTestQuestion;
        private System.Windows.Forms.Button btnInsertTestQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTestQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessageQuestion;
    }
}