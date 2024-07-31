namespace QuestionBank
{
    partial class frmShortAwmserAdd
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
            this.gboxShortAnswer = new System.Windows.Forms.GroupBox();
            this.btnSaveandCloseShortAnswer = new System.Windows.Forms.Button();
            this.btnInsertShortAnswer = new System.Windows.Forms.Button();
            this.txtShortAnwser = new System.Windows.Forms.TextBox();
            this.lblMessageQuestion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gboxShortAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxShortAnswer
            // 
            this.gboxShortAnswer.Controls.Add(this.btnSaveandCloseShortAnswer);
            this.gboxShortAnswer.Controls.Add(this.btnInsertShortAnswer);
            this.gboxShortAnswer.Controls.Add(this.txtShortAnwser);
            this.gboxShortAnswer.Controls.Add(this.lblMessageQuestion);
            this.gboxShortAnswer.Controls.Add(this.label9);
            this.gboxShortAnswer.Location = new System.Drawing.Point(12, 14);
            this.gboxShortAnswer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gboxShortAnswer.Name = "gboxShortAnswer";
            this.gboxShortAnswer.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gboxShortAnswer.Size = new System.Drawing.Size(941, 136);
            this.gboxShortAnswer.TabIndex = 0;
            this.gboxShortAnswer.TabStop = false;
            this.gboxShortAnswer.Text = "سوال کوتاه پاسخ";
            this.gboxShortAnswer.Enter += new System.EventHandler(this.gboxShortAnswer_Enter);
            // 
            // btnSaveandCloseShortAnswer
            // 
            this.btnSaveandCloseShortAnswer.Location = new System.Drawing.Point(6, 19);
            this.btnSaveandCloseShortAnswer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSaveandCloseShortAnswer.Name = "btnSaveandCloseShortAnswer";
            this.btnSaveandCloseShortAnswer.Size = new System.Drawing.Size(105, 44);
            this.btnSaveandCloseShortAnswer.TabIndex = 2;
            this.btnSaveandCloseShortAnswer.Text = "ذخیره نهایی";
            this.btnSaveandCloseShortAnswer.UseVisualStyleBackColor = true;
            this.btnSaveandCloseShortAnswer.Click += new System.EventHandler(this.btnSaveandCloseShortAnswer_Click);
            // 
            // btnInsertShortAnswer
            // 
            this.btnInsertShortAnswer.Location = new System.Drawing.Point(125, 19);
            this.btnInsertShortAnswer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertShortAnswer.Name = "btnInsertShortAnswer";
            this.btnInsertShortAnswer.Size = new System.Drawing.Size(102, 44);
            this.btnInsertShortAnswer.TabIndex = 1;
            this.btnInsertShortAnswer.Text = "ثبت سوال";
            this.btnInsertShortAnswer.UseVisualStyleBackColor = true;
            this.btnInsertShortAnswer.Click += new System.EventHandler(this.btnInsertShortAnswer_Click);
            // 
            // txtShortAnwser
            // 
            this.txtShortAnwser.Location = new System.Drawing.Point(233, 35);
            this.txtShortAnwser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtShortAnwser.Name = "txtShortAnwser";
            this.txtShortAnwser.Size = new System.Drawing.Size(599, 28);
            this.txtShortAnwser.TabIndex = 0;
            // 
            // lblMessageQuestion
            // 
            this.lblMessageQuestion.AutoSize = true;
            this.lblMessageQuestion.Location = new System.Drawing.Point(468, 86);
            this.lblMessageQuestion.Name = "lblMessageQuestion";
            this.lblMessageQuestion.Size = new System.Drawing.Size(0, 21);
            this.lblMessageQuestion.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(828, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "متن سوال";
            // 
            // frmShortAwmserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 154);
            this.Controls.Add(this.gboxShortAnswer);
            this.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmShortAwmserAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmShortAwmserAdd_Load);
            this.gboxShortAnswer.ResumeLayout(false);
            this.gboxShortAnswer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxShortAnswer;
        private System.Windows.Forms.Button btnSaveandCloseShortAnswer;
        private System.Windows.Forms.Button btnInsertShortAnswer;
        private System.Windows.Forms.TextBox txtShortAnwser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMessageQuestion;
    }
}