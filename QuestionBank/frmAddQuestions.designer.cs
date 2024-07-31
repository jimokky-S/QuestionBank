namespace QuestionBank
{
    partial class frmAddQuestions
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
            this.gboxTypeQuestions = new System.Windows.Forms.GroupBox();
            this.rbtnDescriptive = new System.Windows.Forms.RadioButton();
            this.rbtnTestQuestion = new System.Windows.Forms.RadioButton();
            this.rbtnShortAnswer = new System.Windows.Forms.RadioButton();
            this.gboxQuestions = new System.Windows.Forms.GroupBox();
            this.lblMessageQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTypeQuestion = new System.Windows.Forms.Label();
            this.gboxSession = new System.Windows.Forms.GroupBox();
            this.nudSession = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxPodeman = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmboxLession = new System.Windows.Forms.ComboBox();
            this.gboxPodeman = new System.Windows.Forms.GroupBox();
            this.cmboxPodeman = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.rbtnTwelfthGrade = new System.Windows.Forms.RadioButton();
            this.rbtnTenthGrade = new System.Windows.Forms.RadioButton();
            this.rbtnEleventhGrade = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDifficultyLevel = new System.Windows.Forms.Label();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnEsay = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnInsertDescriptive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxTypeQuestions.SuspendLayout();
            this.gboxQuestions.SuspendLayout();
            this.gboxSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gboxPodeman.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxTypeQuestions
            // 
            this.gboxTypeQuestions.Controls.Add(this.rbtnDescriptive);
            this.gboxTypeQuestions.Controls.Add(this.rbtnTestQuestion);
            this.gboxTypeQuestions.Controls.Add(this.rbtnShortAnswer);
            this.gboxTypeQuestions.Location = new System.Drawing.Point(1082, 4);
            this.gboxTypeQuestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxTypeQuestions.Name = "gboxTypeQuestions";
            this.gboxTypeQuestions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxTypeQuestions.Size = new System.Drawing.Size(159, 201);
            this.gboxTypeQuestions.TabIndex = 0;
            this.gboxTypeQuestions.TabStop = false;
            this.gboxTypeQuestions.Text = "نوع سوال";
            this.gboxTypeQuestions.Enter += new System.EventHandler(this.gboxTypeQuestions_Enter);
            // 
            // rbtnDescriptive
            // 
            this.rbtnDescriptive.AutoSize = true;
            this.rbtnDescriptive.Location = new System.Drawing.Point(32, 123);
            this.rbtnDescriptive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnDescriptive.Name = "rbtnDescriptive";
            this.rbtnDescriptive.Size = new System.Drawing.Size(100, 36);
            this.rbtnDescriptive.TabIndex = 2;
            this.rbtnDescriptive.TabStop = true;
            this.rbtnDescriptive.Text = "تشریحی";
            this.rbtnDescriptive.UseVisualStyleBackColor = true;
            this.rbtnDescriptive.CheckedChanged += new System.EventHandler(this.rbtnDescriptive_CheckedChanged);
            // 
            // rbtnTestQuestion
            // 
            this.rbtnTestQuestion.AutoSize = true;
            this.rbtnTestQuestion.Location = new System.Drawing.Point(6, 35);
            this.rbtnTestQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnTestQuestion.Name = "rbtnTestQuestion";
            this.rbtnTestQuestion.Size = new System.Drawing.Size(126, 36);
            this.rbtnTestQuestion.TabIndex = 0;
            this.rbtnTestQuestion.TabStop = true;
            this.rbtnTestQuestion.Text = "سوال تستی";
            this.rbtnTestQuestion.UseVisualStyleBackColor = true;
            this.rbtnTestQuestion.CheckedChanged += new System.EventHandler(this.rbtnTestQuestion_CheckedChanged);
            // 
            // rbtnShortAnswer
            // 
            this.rbtnShortAnswer.AutoSize = true;
            this.rbtnShortAnswer.Location = new System.Drawing.Point(13, 79);
            this.rbtnShortAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnShortAnswer.Name = "rbtnShortAnswer";
            this.rbtnShortAnswer.Size = new System.Drawing.Size(119, 36);
            this.rbtnShortAnswer.TabIndex = 1;
            this.rbtnShortAnswer.TabStop = true;
            this.rbtnShortAnswer.Text = "کوتاه پاسخ";
            this.rbtnShortAnswer.UseVisualStyleBackColor = true;
            this.rbtnShortAnswer.CheckedChanged += new System.EventHandler(this.rbtnShortAnswer_CheckedChanged);
            // 
            // gboxQuestions
            // 
            this.gboxQuestions.Controls.Add(this.lblMessageQuestion);
            this.gboxQuestions.Controls.Add(this.label3);
            this.gboxQuestions.Controls.Add(this.lblTypeQuestion);
            this.gboxQuestions.Controls.Add(this.gboxSession);
            this.gboxQuestions.Controls.Add(this.cboxPodeman);
            this.gboxQuestions.Controls.Add(this.groupBox6);
            this.gboxQuestions.Controls.Add(this.gboxPodeman);
            this.gboxQuestions.Controls.Add(this.groupBox5);
            this.gboxQuestions.Controls.Add(this.groupBox4);
            this.gboxQuestions.Controls.Add(this.txtQuestion);
            this.gboxQuestions.Controls.Add(this.btnInsertDescriptive);
            this.gboxQuestions.Controls.Add(this.label1);
            this.gboxQuestions.Enabled = false;
            this.gboxQuestions.Location = new System.Drawing.Point(11, 4);
            this.gboxQuestions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxQuestions.Name = "gboxQuestions";
            this.gboxQuestions.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxQuestions.Size = new System.Drawing.Size(1065, 532);
            this.gboxQuestions.TabIndex = 1;
            this.gboxQuestions.TabStop = false;
            this.gboxQuestions.Text = "سوال ";
            this.gboxQuestions.Enter += new System.EventHandler(this.gboxQuestions_Enter);
            // 
            // lblMessageQuestion
            // 
            this.lblMessageQuestion.AutoSize = true;
            this.lblMessageQuestion.ForeColor = System.Drawing.Color.Red;
            this.lblMessageQuestion.Location = new System.Drawing.Point(640, 468);
            this.lblMessageQuestion.Name = "lblMessageQuestion";
            this.lblMessageQuestion.Size = new System.Drawing.Size(0, 32);
            this.lblMessageQuestion.TabIndex = 9;
            this.lblMessageQuestion.TextChanged += new System.EventHandler(this.lblMessageQuestion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع سوال :";
            // 
            // lblTypeQuestion
            // 
            this.lblTypeQuestion.AutoSize = true;
            this.lblTypeQuestion.Location = new System.Drawing.Point(415, 35);
            this.lblTypeQuestion.Name = "lblTypeQuestion";
            this.lblTypeQuestion.Size = new System.Drawing.Size(0, 32);
            this.lblTypeQuestion.TabIndex = 4;
            // 
            // gboxSession
            // 
            this.gboxSession.Controls.Add(this.nudSession);
            this.gboxSession.Controls.Add(this.label2);
            this.gboxSession.Location = new System.Drawing.Point(475, 256);
            this.gboxSession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxSession.Name = "gboxSession";
            this.gboxSession.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxSession.Size = new System.Drawing.Size(277, 189);
            this.gboxSession.TabIndex = 4;
            this.gboxSession.TabStop = false;
            this.gboxSession.Text = "فصل";
            // 
            // nudSession
            // 
            this.nudSession.Location = new System.Drawing.Point(49, 75);
            this.nudSession.Name = "nudSession";
            this.nudSession.Size = new System.Drawing.Size(120, 40);
            this.nudSession.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "فصل";
            // 
            // cboxPodeman
            // 
            this.cboxPodeman.AutoSize = true;
            this.cboxPodeman.Location = new System.Drawing.Point(902, 464);
            this.cboxPodeman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxPodeman.Name = "cboxPodeman";
            this.cboxPodeman.Size = new System.Drawing.Size(139, 36);
            this.cboxPodeman.TabIndex = 6;
            this.cboxPodeman.Text = "درس پودمانی";
            this.cboxPodeman.UseVisualStyleBackColor = true;
            this.cboxPodeman.CheckedChanged += new System.EventHandler(this.cboxPodeman_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmboxLession);
            this.groupBox6.Location = new System.Drawing.Point(475, 57);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(316, 191);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "درس";
            // 
            // cmboxLession
            // 
            this.cmboxLession.FormattingEnabled = true;
            this.cmboxLession.Location = new System.Drawing.Point(20, 64);
            this.cmboxLession.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxLession.Name = "cmboxLession";
            this.cmboxLession.Size = new System.Drawing.Size(187, 40);
            this.cmboxLession.TabIndex = 0;
            // 
            // gboxPodeman
            // 
            this.gboxPodeman.Controls.Add(this.cmboxPodeman);
            this.gboxPodeman.Enabled = false;
            this.gboxPodeman.Location = new System.Drawing.Point(756, 256);
            this.gboxPodeman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxPodeman.Name = "gboxPodeman";
            this.gboxPodeman.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboxPodeman.Size = new System.Drawing.Size(303, 189);
            this.gboxPodeman.TabIndex = 3;
            this.gboxPodeman.TabStop = false;
            this.gboxPodeman.Text = "پودمان";
            this.gboxPodeman.Enter += new System.EventHandler(this.gboxPodeman_Enter);
            // 
            // cmboxPodeman
            // 
            this.cmboxPodeman.FormattingEnabled = true;
            this.cmboxPodeman.Items.AddRange(new object[] {
            "پودمان 1",
            "پودمان 2 ",
            "پودمان 3",
            "پودمان 4",
            "پودمان 5"});
            this.cmboxPodeman.Location = new System.Drawing.Point(7, 67);
            this.cmboxPodeman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmboxPodeman.Name = "cmboxPodeman";
            this.cmboxPodeman.Size = new System.Drawing.Size(290, 40);
            this.cmboxPodeman.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblGrade);
            this.groupBox5.Controls.Add(this.rbtnTwelfthGrade);
            this.groupBox5.Controls.Add(this.rbtnTenthGrade);
            this.groupBox5.Controls.Add(this.rbtnEleventhGrade);
            this.groupBox5.Location = new System.Drawing.Point(797, 57);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(133, 189);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "پایه";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.ForeColor = System.Drawing.Color.Red;
            this.lblGrade.Location = new System.Drawing.Point(24, 75);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(0, 32);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Visible = false;
            // 
            // rbtnTwelfthGrade
            // 
            this.rbtnTwelfthGrade.AutoSize = true;
            this.rbtnTwelfthGrade.Location = new System.Drawing.Point(8, 131);
            this.rbtnTwelfthGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnTwelfthGrade.Name = "rbtnTwelfthGrade";
            this.rbtnTwelfthGrade.Size = new System.Drawing.Size(98, 36);
            this.rbtnTwelfthGrade.TabIndex = 3;
            this.rbtnTwelfthGrade.TabStop = true;
            this.rbtnTwelfthGrade.Text = "دوازدهم";
            this.rbtnTwelfthGrade.UseVisualStyleBackColor = true;
            this.rbtnTwelfthGrade.CheckedChanged += new System.EventHandler(this.rbtnTwelfthGrade_CheckedChanged);
            // 
            // rbtnTenthGrade
            // 
            this.rbtnTenthGrade.AutoSize = true;
            this.rbtnTenthGrade.Location = new System.Drawing.Point(36, 41);
            this.rbtnTenthGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnTenthGrade.Name = "rbtnTenthGrade";
            this.rbtnTenthGrade.Size = new System.Drawing.Size(70, 36);
            this.rbtnTenthGrade.TabIndex = 0;
            this.rbtnTenthGrade.TabStop = true;
            this.rbtnTenthGrade.Text = "دهم";
            this.rbtnTenthGrade.UseVisualStyleBackColor = true;
            this.rbtnTenthGrade.CheckedChanged += new System.EventHandler(this.rbtnTenthGrade_CheckedChanged);
            // 
            // rbtnEleventhGrade
            // 
            this.rbtnEleventhGrade.AutoSize = true;
            this.rbtnEleventhGrade.Location = new System.Drawing.Point(17, 86);
            this.rbtnEleventhGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnEleventhGrade.Name = "rbtnEleventhGrade";
            this.rbtnEleventhGrade.Size = new System.Drawing.Size(87, 36);
            this.rbtnEleventhGrade.TabIndex = 1;
            this.rbtnEleventhGrade.TabStop = true;
            this.rbtnEleventhGrade.Text = "یازدهم";
            this.rbtnEleventhGrade.UseVisualStyleBackColor = true;
            this.rbtnEleventhGrade.CheckedChanged += new System.EventHandler(this.rbtnEleventhGrade_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDifficultyLevel);
            this.groupBox4.Controls.Add(this.rbtnHard);
            this.groupBox4.Controls.Add(this.rbtnEsay);
            this.groupBox4.Controls.Add(this.rbtnMedium);
            this.groupBox4.Location = new System.Drawing.Point(927, 57);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(132, 189);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "درچه سختی";
            // 
            // lblDifficultyLevel
            // 
            this.lblDifficultyLevel.AutoSize = true;
            this.lblDifficultyLevel.ForeColor = System.Drawing.Color.Red;
            this.lblDifficultyLevel.Location = new System.Drawing.Point(13, 87);
            this.lblDifficultyLevel.Name = "lblDifficultyLevel";
            this.lblDifficultyLevel.Size = new System.Drawing.Size(0, 32);
            this.lblDifficultyLevel.TabIndex = 3;
            this.lblDifficultyLevel.Visible = false;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(13, 127);
            this.rbtnHard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(81, 36);
            this.rbtnHard.TabIndex = 2;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "سخت";
            this.rbtnHard.UseVisualStyleBackColor = true;
            this.rbtnHard.CheckedChanged += new System.EventHandler(this.rbtnHard_CheckedChanged);
            // 
            // rbtnEsay
            // 
            this.rbtnEsay.AutoSize = true;
            this.rbtnEsay.Location = new System.Drawing.Point(13, 39);
            this.rbtnEsay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnEsay.Name = "rbtnEsay";
            this.rbtnEsay.Size = new System.Drawing.Size(74, 36);
            this.rbtnEsay.TabIndex = 1;
            this.rbtnEsay.TabStop = true;
            this.rbtnEsay.Text = "آسان";
            this.rbtnEsay.UseVisualStyleBackColor = true;
            this.rbtnEsay.CheckedChanged += new System.EventHandler(this.rbtnEsay_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(9, 83);
            this.rbtnMedium.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(91, 36);
            this.rbtnMedium.TabIndex = 1;
            this.rbtnMedium.TabStop = true;
            this.rbtnMedium.Text = "متوسط";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(0, 71);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(470, 443);
            this.txtQuestion.TabIndex = 5;
            // 
            // btnInsertDescriptive
            // 
            this.btnInsertDescriptive.Location = new System.Drawing.Point(475, 455);
            this.btnInsertDescriptive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsertDescriptive.Name = "btnInsertDescriptive";
            this.btnInsertDescriptive.Size = new System.Drawing.Size(101, 63);
            this.btnInsertDescriptive.TabIndex = 7;
            this.btnInsertDescriptive.Text = "ثبت سوال";
            this.btnInsertDescriptive.UseVisualStyleBackColor = true;
            this.btnInsertDescriptive.Click += new System.EventHandler(this.btnInsertDescriptive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "متن سوال";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1082, 382);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 154);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1247, 553);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gboxQuestions);
            this.Controls.Add(this.gboxTypeQuestions);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmAddQuestions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmAddQuestions_Load);
            this.gboxTypeQuestions.ResumeLayout(false);
            this.gboxTypeQuestions.PerformLayout();
            this.gboxQuestions.ResumeLayout(false);
            this.gboxQuestions.PerformLayout();
            this.gboxSession.ResumeLayout(false);
            this.gboxSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSession)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.gboxPodeman.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTypeQuestions;
        private System.Windows.Forms.GroupBox gboxQuestions;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnInsertDescriptive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDescriptive;
        private System.Windows.Forms.RadioButton rbtnShortAnswer;
        private System.Windows.Forms.RadioButton rbtnTestQuestion;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnEsay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbtnTwelfthGrade;
        private System.Windows.Forms.RadioButton rbtnTenthGrade;
        private System.Windows.Forms.RadioButton rbtnEleventhGrade;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmboxLession;
        private System.Windows.Forms.GroupBox gboxPodeman;
        private System.Windows.Forms.GroupBox gboxSession;
        private System.Windows.Forms.CheckBox cboxPodeman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTypeQuestion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmboxPodeman;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblDifficultyLevel;
        private System.Windows.Forms.Label lblMessageQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSession;
    }
}