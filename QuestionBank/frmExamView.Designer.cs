namespace QuestionBank
{
    partial class frmExamView
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
            this.dgvQuestion = new System.Windows.Forms.DataGridView();
            this.dgvLession = new System.Windows.Forms.DataGridView();
            this.dgvTestQuestion = new System.Windows.Forms.DataGridView();
            this.dgvQuestionDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxTwelfthGrade = new System.Windows.Forms.CheckBox();
            this.cboxEleventhGrade = new System.Windows.Forms.CheckBox();
            this.cboxTenthGrade = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDQuestionDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDQuestionFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionDetailText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTestQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDQuestionDetailFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextTestQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuestion
            // 
            this.dgvQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuestion.ColumnHeadersHeight = 29;
            this.dgvQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDQuestion,
            this.QuestionText,
            this.DifficultyLevel,
            this.QuestionType,
            this.Session,
            this.Grade});
            this.dgvQuestion.Location = new System.Drawing.Point(542, 210);
            this.dgvQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQuestion.Name = "dgvQuestion";
            this.dgvQuestion.RowHeadersWidth = 51;
            this.dgvQuestion.RowTemplate.Height = 24;
            this.dgvQuestion.Size = new System.Drawing.Size(772, 394);
            this.dgvQuestion.TabIndex = 0;
            this.dgvQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestion_CellContentClick);
            // 
            // dgvLession
            // 
            this.dgvLession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLession.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLession.ColumnHeadersHeight = 29;
            this.dgvLession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLession,
            this.name});
            this.dgvLession.Location = new System.Drawing.Point(1322, 210);
            this.dgvLession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLession.Name = "dgvLession";
            this.dgvLession.RowHeadersWidth = 51;
            this.dgvLession.RowTemplate.Height = 24;
            this.dgvLession.Size = new System.Drawing.Size(172, 394);
            this.dgvLession.TabIndex = 1;
            this.dgvLession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLession_CellContentClick);
            // 
            // dgvTestQuestion
            // 
            this.dgvTestQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestQuestion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTestQuestion.ColumnHeadersHeight = 29;
            this.dgvTestQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTestQuestion,
            this.IDQuestionDetailFK,
            this.TextTestQuestion,
            this.Priority});
            this.dgvTestQuestion.Location = new System.Drawing.Point(13, 210);
            this.dgvTestQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTestQuestion.Name = "dgvTestQuestion";
            this.dgvTestQuestion.RowHeadersWidth = 51;
            this.dgvTestQuestion.RowTemplate.Height = 24;
            this.dgvTestQuestion.Size = new System.Drawing.Size(257, 394);
            this.dgvTestQuestion.TabIndex = 0;
            // 
            // dgvQuestionDetails
            // 
            this.dgvQuestionDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestionDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvQuestionDetails.ColumnHeadersHeight = 29;
            this.dgvQuestionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDQuestionDetails,
            this.IDQuestionFK,
            this.QuestionDetailText});
            this.dgvQuestionDetails.Location = new System.Drawing.Point(278, 210);
            this.dgvQuestionDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQuestionDetails.Name = "dgvQuestionDetails";
            this.dgvQuestionDetails.RowHeadersWidth = 51;
            this.dgvQuestionDetails.RowTemplate.Height = 24;
            this.dgvQuestionDetails.Size = new System.Drawing.Size(256, 394);
            this.dgvQuestionDetails.TabIndex = 1;
            this.dgvQuestionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestionDetails_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxTwelfthGrade);
            this.groupBox1.Controls.Add(this.cboxEleventhGrade);
            this.groupBox1.Controls.Add(this.cboxTenthGrade);
            this.groupBox1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1163, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(328, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پایه";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboxTwelfthGrade
            // 
            this.cboxTwelfthGrade.AutoSize = true;
            this.cboxTwelfthGrade.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.cboxTwelfthGrade.Location = new System.Drawing.Point(6, 28);
            this.cboxTwelfthGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxTwelfthGrade.Name = "cboxTwelfthGrade";
            this.cboxTwelfthGrade.Size = new System.Drawing.Size(99, 36);
            this.cboxTwelfthGrade.TabIndex = 0;
            this.cboxTwelfthGrade.Text = "دوازدهم";
            this.cboxTwelfthGrade.UseVisualStyleBackColor = true;
            this.cboxTwelfthGrade.CheckedChanged += new System.EventHandler(this.cboxTwelfthGrade_CheckedChanged);
            // 
            // cboxEleventhGrade
            // 
            this.cboxEleventhGrade.AutoSize = true;
            this.cboxEleventhGrade.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.cboxEleventhGrade.Location = new System.Drawing.Point(119, 28);
            this.cboxEleventhGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxEleventhGrade.Name = "cboxEleventhGrade";
            this.cboxEleventhGrade.Size = new System.Drawing.Size(88, 36);
            this.cboxEleventhGrade.TabIndex = 0;
            this.cboxEleventhGrade.Text = "یازدهم";
            this.cboxEleventhGrade.UseVisualStyleBackColor = true;
            this.cboxEleventhGrade.CheckedChanged += new System.EventHandler(this.cboxTwelfthGrade_CheckedChanged);
            // 
            // cboxTenthGrade
            // 
            this.cboxTenthGrade.AutoSize = true;
            this.cboxTenthGrade.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Bold);
            this.cboxTenthGrade.Location = new System.Drawing.Point(210, 28);
            this.cboxTenthGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxTenthGrade.Name = "cboxTenthGrade";
            this.cboxTenthGrade.Size = new System.Drawing.Size(71, 36);
            this.cboxTenthGrade.TabIndex = 0;
            this.cboxTenthGrade.Text = "دهم";
            this.cboxTenthGrade.UseVisualStyleBackColor = true;
            this.cboxTenthGrade.CheckedChanged += new System.EventHandler(this.cboxTwelfthGrade_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(891, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "سوال ها";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "زیر مجموعه سوالات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1373, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "دروس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "گزینه های تستی";
            // 
            // IDQuestion
            // 
            this.IDQuestion.HeaderText = "ID";
            this.IDQuestion.MinimumWidth = 6;
            this.IDQuestion.Name = "IDQuestion";
            this.IDQuestion.Visible = false;
            // 
            // QuestionText
            // 
            this.QuestionText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuestionText.HeaderText = "متن سوال";
            this.QuestionText.MinimumWidth = 6;
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.ReadOnly = true;
            this.QuestionText.Width = 108;
            // 
            // DifficultyLevel
            // 
            this.DifficultyLevel.HeaderText = "درجه سختی";
            this.DifficultyLevel.MinimumWidth = 6;
            this.DifficultyLevel.Name = "DifficultyLevel";
            this.DifficultyLevel.ReadOnly = true;
            // 
            // QuestionType
            // 
            this.QuestionType.HeaderText = "نوع سوال";
            this.QuestionType.MinimumWidth = 6;
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.ReadOnly = true;
            // 
            // Session
            // 
            this.Session.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Session.HeaderText = "فصل/پودمان";
            this.Session.MinimumWidth = 6;
            this.Session.Name = "Session";
            this.Session.ReadOnly = true;
            this.Session.Width = 128;
            // 
            // Grade
            // 
            this.Grade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Grade.HeaderText = "پایه";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 66;
            // 
            // IDQuestionDetails
            // 
            this.IDQuestionDetails.HeaderText = "ID";
            this.IDQuestionDetails.MinimumWidth = 6;
            this.IDQuestionDetails.Name = "IDQuestionDetails";
            this.IDQuestionDetails.ReadOnly = true;
            this.IDQuestionDetails.Visible = false;
            // 
            // IDQuestionFK
            // 
            this.IDQuestionFK.HeaderText = "IDQuestion";
            this.IDQuestionFK.MinimumWidth = 6;
            this.IDQuestionFK.Name = "IDQuestionFK";
            this.IDQuestionFK.ReadOnly = true;
            this.IDQuestionFK.Visible = false;
            // 
            // QuestionDetailText
            // 
            this.QuestionDetailText.HeaderText = "متن سوال";
            this.QuestionDetailText.MinimumWidth = 6;
            this.QuestionDetailText.Name = "QuestionDetailText";
            this.QuestionDetailText.ReadOnly = true;
            // 
            // IDTestQuestion
            // 
            this.IDTestQuestion.HeaderText = "ID";
            this.IDTestQuestion.MinimumWidth = 6;
            this.IDTestQuestion.Name = "IDTestQuestion";
            this.IDTestQuestion.ReadOnly = true;
            this.IDTestQuestion.Visible = false;
            // 
            // IDQuestionDetailFK
            // 
            this.IDQuestionDetailFK.HeaderText = "IDquestionDetail";
            this.IDQuestionDetailFK.MinimumWidth = 6;
            this.IDQuestionDetailFK.Name = "IDQuestionDetailFK";
            this.IDQuestionDetailFK.ReadOnly = true;
            this.IDQuestionDetailFK.Visible = false;
            // 
            // TextTestQuestion
            // 
            this.TextTestQuestion.HeaderText = "متن تست";
            this.TextTestQuestion.MinimumWidth = 6;
            this.TextTestQuestion.Name = "TextTestQuestion";
            this.TextTestQuestion.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "اولویت";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // IDLession
            // 
            this.IDLession.HeaderText = "IDLession";
            this.IDLession.MinimumWidth = 6;
            this.IDLession.Name = "IDLession";
            this.IDLession.ReadOnly = true;
            this.IDLession.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "نام درس";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // frmExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 617);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQuestionDetails);
            this.Controls.Add(this.dgvLession);
            this.Controls.Add(this.dgvTestQuestion);
            this.Controls.Add(this.dgvQuestion);
            this.Font = new System.Drawing.Font("Vazir", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExamView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.frmExamView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuestion;
        private System.Windows.Forms.DataGridView dgvLession;
        private System.Windows.Forms.DataGridView dgvTestQuestion;
        private System.Windows.Forms.DataGridView dgvQuestionDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxTwelfthGrade;
        private System.Windows.Forms.CheckBox cboxEleventhGrade;
        private System.Windows.Forms.CheckBox cboxTenthGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Session;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLession;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTestQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuestionDetailFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextTestQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuestionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuestionFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionDetailText;
    }
}