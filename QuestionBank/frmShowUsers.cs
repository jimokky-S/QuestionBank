using BLL;
using BLL.QuestionBank;
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
    public partial class frmShowUsers : Form
    {
        string per = "";
        public frmShowUsers(Tbl_User user)
        {
            if (user.Permission == "admin"|| user.Permission == "owner")
            {
                InitializeComponent();
                btnAddUsers.Enabled = true;
            }
            else
            {
                InitializeComponent();
            }
            per = user.Permission;
            
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            frmAddUsers frmAddUsers = new frmAddUsers(per);
            frmAddUsers.ShowDialog();
            frmShowUsers_Load(sender, e);

        }

        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            LessionBL lessionBL = new LessionBL();
            var lession =  lessionBL.SelectLession();
            UsersBL usersBL = new UsersBL();
            var result = usersBL.SelectUsers();
            DataTable dt = new DataTable();
            dt.Columns.Add("نام");
            dt.Columns.Add("نام خانوادگی");
            dt.Columns.Add("نام کاربری");
            dt.Columns.Add("کذرواژه");
            dt.Columns.Add("دسترسی");
            dt.Columns.Add("درس مربوطه");

            int i = 0;
            foreach ( var item in result.Data ) 
            {
             
                foreach (var itemles in lession.Data)
                {
                    if (itemles.ID == item.LessionId)
                    {
                        dt.Rows.Add(item.Firstname, item.Lastname,item.Username, item.Password, item.Permission ,itemles.Name);

                    }
                }

            }
            dgvShowUser.DataSource = dt;
            dgvShowUser.Columns["نام"].HeaderText = "نام";
            dgvShowUser.Columns["نام خانوادگی"].HeaderText = "نام";
            dgvShowUser.Columns["کذرواژه"].HeaderText = "نام خانوادگی";
            dgvShowUser.Columns["نام کاربری"].HeaderText = "نام کاربری";
            dgvShowUser.Columns["دسترسی"].HeaderText = "دسترسی";
            dgvShowUser.Columns["درس مربوطه"].HeaderText = "درس مربوطه";

        }
    }
}
