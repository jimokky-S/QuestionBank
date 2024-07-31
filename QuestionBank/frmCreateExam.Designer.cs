namespace QuestionBank
{
    partial class frmCreateExam
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
            this.nudNumberQuestion = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDifficultyLevel = new System.Windows.Forms.Label();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnEsay = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnTwelfthGrade = new System.Windows.Forms.RadioButton();
            this.rbtnEleventhGrade = new System.Windows.Forms.RadioButton();
            this.rbtnTenthGrade = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmboxLession = new System.Windows.Forms.ComboBox();
            this.cboxDescriptive = new System.Windows.Forms.CheckBox();
            this.cboxShortAnswer = new System.Windows.Forms.CheckBox();
            this.cboxTestQuestion = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cmboxPodeman = new System.Windows.Forms.ComboBox();
            this.pnlSession = new System.Windows.Forms.Panel();
            this.nudSession = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxPodeman = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreateExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberQuestion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.pnlSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumberQuestion
            // 
            this.nudNumberQuestion.Location = new System.Drawing.Point(6, 34);
            this.nudNumberQuestion.Name = "nudNumberQuestion";
            this.nudNumberQuestion.Size = new System.Drawing.Size(109, 35);
            this.nudNumberQuestion.TabIndex = 0;
            this.nudNumberQuestion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberQuestion.ValueChanged += new System.EventHandler(this.nudNumberQuestion_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDifficultyLevel);
            this.groupBox4.Controls.Add(this.rbtnHard);
            this.groupBox4.Controls.Add(this.rbtnEsay);
            this.groupBox4.Controls.Add(this.rbtnMedium);
            this.groupBox4.Location = new System.Drawing.Point(374, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(114, 147);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "درچه سختی";
            // 
            // lblDifficultyLevel
            // 
            this.lblDifficultyLevel.AutoSize = true;
            this.lblDifficultyLevel.ForeColor = System.Drawing.Color.Red;
            this.lblDifficultyLevel.Location = new System.Drawing.Point(13, 87);
            this.lblDifficultyLevel.Name = "lblDifficultyLevel";
            this.lblDifficultyLevel.Size = new System.Drawing.Size(0, 27);
            this.lblDifficultyLevel.TabIndex = 3;
            this.lblDifficultyLevel.Visible = false;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(17, 94);
            this.rbtnHard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(73, 31);
            this.rbtnHard.TabIndex = 2;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "سخت";
            this.rbtnHard.UseVisualStyleBackColor = true;
            this.rbtnHard.CheckedChanged += new System.EventHandler(this.rbtnHard_CheckedChanged);
            // 
            // rbtnEsay
            // 
            this.rbtnEsay.AutoSize = true;
            this.rbtnEsay.Location = new System.Drawing.Point(24, 34);
            this.rbtnEsay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnEsay.Name = "rbtnEsay";
            this.rbtnEsay.Size = new System.Drawing.Size(66, 31);
            this.rbtnEsay.TabIndex = 0;
            this.rbtnEsay.TabStop = true;
            this.rbtnEsay.Text = "آسان";
            this.rbtnEsay.UseVisualStyleBackColor = true;
            this.rbtnEsay.CheckedChanged += new System.EventHandler(this.rbtnEsay_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(9, 64);
            this.rbtnMedium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(81, 31);
            this.rbtnMedium.TabIndex = 1;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "متوسط";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudNumberQuestion);
            this.groupBox2.Location = new System.Drawing.Point(491, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تعداد سوالات";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnTwelfthGrade);
            this.groupBox3.Controls.Add(this.rbtnEleventhGrade);
            this.groupBox3.Controls.Add(this.rbtnTenthGrade);
            this.groupBox3.Location = new System.Drawing.Point(614, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 148);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "پایه";
            // 
            // rbtnTwelfthGrade
            // 
            this.rbtnTwelfthGrade.AutoSize = true;
            this.rbtnTwelfthGrade.Location = new System.Drawing.Point(6, 108);
            this.rbtnTwelfthGrade.Name = "rbtnTwelfthGrade";
            this.rbtnTwelfthGrade.Size = new System.Drawing.Size(87, 31);
            this.rbtnTwelfthGrade.TabIndex = 5;
            this.rbtnTwelfthGrade.TabStop = true;
            this.rbtnTwelfthGrade.Text = "دوازدهم";
            this.rbtnTwelfthGrade.UseVisualStyleBackColor = true;
            this.rbtnTwelfthGrade.CheckedChanged += new System.EventHandler(this.rbtnTwelfthGrade_CheckedChanged);
            // 
            // rbtnEleventhGrade
            // 
            this.rbtnEleventhGrade.AutoSize = true;
            this.rbtnEleventhGrade.Location = new System.Drawing.Point(15, 71);
            this.rbtnEleventhGrade.Name = "rbtnEleventhGrade";
            this.rbtnEleventhGrade.Size = new System.Drawing.Size(78, 31);
            this.rbtnEleventhGrade.TabIndex = 4;
            this.rbtnEleventhGrade.TabStop = true;
            this.rbtnEleventhGrade.Text = "یازدهم";
            this.rbtnEleventhGrade.UseVisualStyleBackColor = true;
            this.rbtnEleventhGrade.CheckedChanged += new System.EventHandler(this.rbtnEleventhGrade_CheckedChanged);
            // 
            // rbtnTenthGrade
            // 
            this.rbtnTenthGrade.AutoSize = true;
            this.rbtnTenthGrade.Location = new System.Drawing.Point(30, 34);
            this.rbtnTenthGrade.Name = "rbtnTenthGrade";
            this.rbtnTenthGrade.Size = new System.Drawing.Size(63, 31);
            this.rbtnTenthGrade.TabIndex = 3;
            this.rbtnTenthGrade.TabStop = true;
            this.rbtnTenthGrade.Tag = "";
            this.rbtnTenthGrade.Text = "دهم";
            this.rbtnTenthGrade.UseVisualStyleBackColor = true;
            this.rbtnTenthGrade.CheckedChanged += new System.EventHandler(this.rbtnTenthGrade_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmboxLession);
            this.groupBox6.Location = new System.Drawing.Point(129, 4);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(239, 147);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "درس";
            // 
            // cmboxLession
            // 
            this.cmboxLession.FormattingEnabled = true;
            this.cmboxLession.Location = new System.Drawing.Point(31, 36);
            this.cmboxLession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxLession.Name = "cmboxLession";
            this.cmboxLession.Size = new System.Drawing.Size(187, 35);
            this.cmboxLession.TabIndex = 0;
            this.cmboxLession.SelectedIndexChanged += new System.EventHandler(this.cmboxLession_SelectedIndexChanged);
            // 
            // cboxDescriptive
            // 
            this.cboxDescriptive.AutoSize = true;
            this.cboxDescriptive.Location = new System.Drawing.Point(23, 95);
            this.cboxDescriptive.Name = "cboxDescriptive";
            this.cboxDescriptive.Size = new System.Drawing.Size(90, 31);
            this.cboxDescriptive.TabIndex = 1;
            this.cboxDescriptive.Text = "تشریحی";
            this.cboxDescriptive.UseVisualStyleBackColor = true;
            this.cboxDescriptive.CheckedChanged += new System.EventHandler(this.cboxDescriptive_CheckedChanged);
            // 
            // cboxShortAnswer
            // 
            this.cboxShortAnswer.AutoSize = true;
            this.cboxShortAnswer.Location = new System.Drawing.Point(8, 62);
            this.cboxShortAnswer.Name = "cboxShortAnswer";
            this.cboxShortAnswer.Size = new System.Drawing.Size(105, 31);
            this.cboxShortAnswer.TabIndex = 9;
            this.cboxShortAnswer.Text = "کوتاه پاسخ";
            this.cboxShortAnswer.UseVisualStyleBackColor = true;
            this.cboxShortAnswer.CheckedChanged += new System.EventHandler(this.cboxShortAnswer_CheckedChanged);
            // 
            // cboxTestQuestion
            // 
            this.cboxTestQuestion.AutoSize = true;
            this.cboxTestQuestion.Location = new System.Drawing.Point(2, 28);
            this.cboxTestQuestion.Name = "cboxTestQuestion";
            this.cboxTestQuestion.Size = new System.Drawing.Size(111, 31);
            this.cboxTestQuestion.TabIndex = 10;
            this.cboxTestQuestion.Text = "سوال تستی";
            this.cboxTestQuestion.UseVisualStyleBackColor = true;
            this.cboxTestQuestion.CheckedChanged += new System.EventHandler(this.cboxTestQuestion_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboxTestQuestion);
            this.groupBox5.Controls.Add(this.cboxDescriptive);
            this.groupBox5.Controls.Add(this.cboxShortAnswer);
            this.groupBox5.Location = new System.Drawing.Point(8, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(119, 147);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نوع سوالات";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cmboxPodeman);
            this.groupBox8.Controls.Add(this.pnlSession);
            this.groupBox8.Controls.Add(this.cboxPodeman);
            this.groupBox8.Location = new System.Drawing.Point(419, 157);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 178);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "سفارشی سازی آزمون";
            // 
            // cmboxPodeman
            // 
            this.cmboxPodeman.Enabled = false;
            this.cmboxPodeman.FormattingEnabled = true;
            this.cmboxPodeman.Items.AddRange(new object[] {
            "پودمان 1",
            "پودمان 2",
            "پودمان 3",
            "پودمان 4",
            "پودمان 5"});
            this.cmboxPodeman.Location = new System.Drawing.Point(143, 109);
            this.cmboxPodeman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxPodeman.Name = "cmboxPodeman";
            this.cmboxPodeman.Size = new System.Drawing.Size(151, 35);
            this.cmboxPodeman.TabIndex = 1;
            this.cmboxPodeman.SelectedIndexChanged += new System.EventHandler(this.cmboxPodeman_SelectedIndexChanged);
            // 
            // pnlSession
            // 
            this.pnlSession.Controls.Add(this.nudSession);
            this.pnlSession.Controls.Add(this.label3);
            this.pnlSession.Controls.Add(this.label2);
            this.pnlSession.Location = new System.Drawing.Point(6, 71);
            this.pnlSession.Name = "pnlSession";
            this.pnlSession.Size = new System.Drawing.Size(131, 88);
            this.pnlSession.TabIndex = 1;
            // 
            // nudSession
            // 
            this.nudSession.Location = new System.Drawing.Point(11, 37);
            this.nudSession.Name = "nudSession";
            this.nudSession.Size = new System.Drawing.Size(61, 35);
            this.nudSession.TabIndex = 2;
            this.nudSession.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSession.ValueChanged += new System.EventHandler(this.nudSession_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "فصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "فصل";
            // 
            // cboxPodeman
            // 
            this.cboxPodeman.AutoSize = true;
            this.cboxPodeman.Location = new System.Drawing.Point(163, 71);
            this.cboxPodeman.Name = "cboxPodeman";
            this.cboxPodeman.Size = new System.Drawing.Size(131, 31);
            this.cboxPodeman.TabIndex = 0;
            this.cboxPodeman.Text = "دروس پودمانی";
            this.cboxPodeman.UseVisualStyleBackColor = true;
            this.cboxPodeman.CheckedChanged += new System.EventHandler(this.cboxPodeman_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(7, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 68);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "انصراف";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.Location = new System.Drawing.Point(129, 377);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(114, 68);
            this.btnCreateExam.TabIndex = 6;
            this.btnCreateExam.Text = "ساخت آزمون";
            this.btnCreateExam.UseVisualStyleBackColor = true;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // frmCreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 452);
            this.Controls.Add(this.btnCreateExam);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCreateExam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCreateExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberQuestion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.pnlSession.ResumeLayout(false);
            this.pnlSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudNumberQuestion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblDifficultyLevel;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnEsay;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnTwelfthGrade;
        private System.Windows.Forms.RadioButton rbtnEleventhGrade;
        private System.Windows.Forms.RadioButton rbtnTenthGrade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmboxLession;
        private System.Windows.Forms.CheckBox cboxDescriptive;
        private System.Windows.Forms.CheckBox cboxShortAnswer;
        private System.Windows.Forms.CheckBox cboxTestQuestion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cboxPodeman;
        private System.Windows.Forms.Panel pnlSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSession;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.ComboBox cmboxPodeman;
    }
}