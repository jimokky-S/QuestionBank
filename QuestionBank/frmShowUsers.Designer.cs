namespace QuestionBank
{
    partial class frmShowUsers
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
            this.dgvShowUser = new System.Windows.Forms.DataGridView();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowUser
            // 
            this.dgvShowUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvShowUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShowUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShowUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowUser.Location = new System.Drawing.Point(12, 50);
            this.dgvShowUser.Name = "dgvShowUser";
            this.dgvShowUser.RowHeadersWidth = 51;
            this.dgvShowUser.RowTemplate.Height = 24;
            this.dgvShowUser.Size = new System.Drawing.Size(776, 388);
            this.dgvShowUser.TabIndex = 0;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Enabled = false;
            this.btnAddUsers.Location = new System.Drawing.Point(12, 12);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(130, 32);
            this.btnAddUsers.TabIndex = 1;
            this.btnAddUsers.Text = "اضافه کردن کاربر";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(658, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 32);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "بارگذاری مجدد";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.frmShowUsers_Load);
            // 
            // frmShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddUsers);
            this.Controls.Add(this.dgvShowUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowUsers";
            this.Load += new System.EventHandler(this.frmShowUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowUser;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnRefresh;
    }
}