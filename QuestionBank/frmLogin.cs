using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAcsept_Click(object sender, EventArgs e)
        {
            UsersBL usersBL = new UsersBL();
            var result = usersBL.SelectUsersbyUsernameAndPassword(txtUsername.Text, txtPassword.Text);
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    frmMain frmMain = new frmMain(item);
                    frmMain.ShowDialog();
                    LogBL logBL = new LogBL();
                    LogModel logModel = new LogModel()
                    { IdUser = item.ID };
                    logBL.InsertLog(logModel);
                    break;
                }
               
            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
