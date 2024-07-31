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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using QuestionBankApp;

namespace QuestionBank
{
    public partial class frmMain : Form
    {
        List<Tbl_Question> listQuestions;
        Tbl_User User;
        public frmMain(Tbl_User user)
        {
            User = new Tbl_User();
            User = user;
            listQuestions = new List<Tbl_Question>();
            InitializeComponent();

            if (user.Permission == "owner"|| user.Permission == "admin")
            {
                gboxUser.Visible = true;
                btnAddLession.Visible = true;
            }
            else { gboxUser.Visible = false; btnAddLession.Visible = false; }
            LogModel model = new LogModel();
            model.IdUser = user.ID;
            LogBL logBL = new LogBL();
            logBL.InsertLog(model);
            
        }

        private void lblAddQuestions_Click(object sender, EventArgs e)
        {
            if (User.Permission == "admin" || User.Permission == "owner")
            {
                frmAddQuestions frmAddQuestions = new frmAddQuestions();
                frmAddQuestions.ShowDialog();
            }
            else
            {
                frmAddQuestions frmAddQuestions = new frmAddQuestions(User.LessionId);
                frmAddQuestions.ShowDialog();
            }
        }

        private void btnAddLession_Click(object sender, EventArgs e)
        {
            pnlAddLession.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            LessionBL lessionBL = new LessionBL();
            LessionModel model = new LessionModel();
            model.Name = txtNameLession.Text;
            var result = lessionBL.InsertLession(model);
            lblWarning.Text = result.Message;
            txtNameLession.Text=string.Empty;
        }

        private void lblWarning_TextChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Thread.Sleep(1500);
                    Invoke(new Action(() => 
                    {
                        try
                        {
                            lblWarning.Text = "";
                            pnlAddLession.Visible = false;
                        }
                        catch (Exception)
                        {

                           
                        }
                        
                    }));
                }
                catch (Exception)
                {


                }


            });
        }

        private void btnTenthGrade_Click(object sender, EventArgs e)
        {
           
            btnEleventhGrade.Enabled = true;
            btnTwelfthGrade.Enabled = true;
            btnTenthGrade.Enabled = false;
            clearlbl();
            int length = selectGrade("دهم");
            lblTenthGrade.Text = length.ToString();
        }

        private void btnEleventhGrade_Click(object sender, EventArgs e)
        {

           

            btnEleventhGrade.Enabled = false;
            btnTwelfthGrade.Enabled = true;
            btnTenthGrade.Enabled = true;
            clearlbl();
            int length = selectGrade("یازدهم");
            lblEleventhGrade.Text = length.ToString();    
        }

        private void btnTwelfthGrade_Click(object sender, EventArgs e)
        {


            btnEleventhGrade.Enabled = true;
            btnTwelfthGrade.Enabled = false;
            btnTenthGrade.Enabled = true;
            clearlbl();
            int length = selectGrade("دوازدهم");
            lblTwelfthGrade.Text = length.ToString();
        }

        private int selectGrade(string Grade)
        {
            int length = 0;
            listQuestions.Clear();
            QuestionBL questionBL = new QuestionBL();
            var result = questionBL.SelectQuestions();
            foreach (var item in result.Data)
            {
                if (item.Grade == Grade)
                {
                    listQuestions.Add(item);
                    length++;
                }

                
            }
            return length;   
        }

        private void nudValueChange(int value)
        {
            value--;
            
            LessionBL lessionBL = new LessionBL();
            var result=lessionBL.SelectLession(); 
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    if (item.ID == listQuestions[value].lessionID)
                    {
                       
                    }
                }
            }
          
            
        }

        private void clearlbl()
        { 
            lblTenthGrade.Text = "0";
            lblTwelfthGrade.Text = "0";
            lblEleventhGrade.Text = "0";
        }
      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Exam exam   = new Exam();
            
        }

        private void btnShowExam_Click(object sender, EventArgs e)
        {
            frmExamView exam = new frmExamView();
            exam.Show();
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            frmShowUsers frmShowUsers = new frmShowUsers(User);
            frmShowUsers.Show();
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            if (User.Permission == "owner" || User.Permission == "admin")
            {
                frmCreateExam exam = new frmCreateExam();
                exam.ShowDialog();
            }
            else if (User.Permission=="teacher")
            {
                frmCreateExam exam = new frmCreateExam(User.LessionId);
                exam.ShowDialog();
            }
            
               
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
