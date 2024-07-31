using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace QuestionBank
{
    public partial class frmAddUsers : Form
    {
        Lession lession = new Lession();
        
        public frmAddUsers(string per)
        {
            InitializeComponent();
            cmboxPermissions.Items.Add("teacher");
            cmboxPermissions.Items.Add("student");
            if (per == "owner")
            {
                cmboxPermissions.Items.Add("admin");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lessionID = 0;
            var resultLession = lession.SelectLession();
            foreach (var item in resultLession.Data)
            {
                if (item.Name == cmboxLession.Text)
                {
                    lessionID = item.ID;    
                }
            }
            UsersBL usersBL = new UsersBL();
            UserModel userModel = new UserModel()
            {
                lessionID = lessionID,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                LastName = txtLastName.Text,
                FirstName = txtfirestName.Text,
                Permission = cmboxPermissions.Text,
                PhoneNumber = txtPhoneNumber.Text,
            };
            var result = usersBL.InsertUsers(userModel);
            if (result.Success)
            {
                MessageBox.Show("ذخیره شد");
            }
            else
            {
                MessageBox.Show("ذخیره نشد");
            }
            clear();
        }

        private void frmAddUsers_Load(object sender, EventArgs e)
        {
            var resultLession = lession.SelectLession();
            foreach (var item in resultLession.Data) { cmboxLession.Items.Add(item.Name); }
        }
        private void clear()
        { 
            txtfirestName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtUsername.Clear();
            cmboxLession.Text = string.Empty;
            cmboxPermissions.Text = string.Empty;
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
