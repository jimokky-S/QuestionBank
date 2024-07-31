using BLL;
using BLL.QuestionBank;
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
    public partial class frmExamView : Form
    {
        public frmExamView()
        {
            InitializeComponent();
        }

        private void frmExamView_Load(object sender, EventArgs e)
        {
            
            string search = "";
            LessionBL lessionBL = new LessionBL();
            var resultLession = lessionBL.SelectLession(search);
            
            if (resultLession != null) 
            {
                foreach (var item in resultLession.Data)
                {
                    dgvLession.Rows.Add(item.ID, item.Name);
                }
            }
            else
            {
                MessageBox.Show("result Lession is null");
            }
            cboxEleventhGrade.Checked = true;
            cboxTenthGrade.Checked = true;
            cboxTwelfthGrade.Checked = true;
        }

        private void dgvLession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            selectdgvQuestion();


        }

        private void dgvQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvQuestionDetails.Rows.Clear();
            dgvTestQuestion.Rows.Clear();
            int ID = (int)dgvQuestion.CurrentRow.Cells["IDQuestion"].Value;
            QuestionDetailsBL questionDetailsBL = new QuestionDetailsBL();
            var resultQuestionDetails = questionDetailsBL.SelectQuestionDetailsByQuestionID(ID);
            if (resultQuestionDetails != null)
            {
                foreach (var item in resultQuestionDetails.Data)
                {
                    dgvQuestionDetails.Rows.Add(item.ID,item.IDQuestions,item.text);
                }
            }

        }

        private void dgvQuestionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTestQuestion.Rows.Clear();
            int ID = (int)dgvQuestionDetails.CurrentRow.Cells["IDQuestionDetails"].Value;
           TestQuestionBL testQuestionBL = new TestQuestionBL();
            var resultTestQuestion = testQuestionBL.SelectTestQuestionByQuestionDetailID(ID);
            if (resultTestQuestion != null)
            {
                foreach (var item in resultTestQuestion.Data)
                {
                    dgvTestQuestion.Rows.Add(item.ID, item.QuestionDetailsID, item.Text,item.Priority);
                }
            }
        }

        private void selectdgvQuestion()
        {
            dgvQuestion.Rows.Clear();
            dgvQuestionDetails.Rows.Clear();
            dgvTestQuestion.Rows.Clear();
            string Tenthgrade = "";
            string Eleventhgrade = "";
            string Twelfthgrade = "";
            if (cboxTenthGrade.Checked)
            {
                Tenthgrade = "دهم";
            }
            if (cboxEleventhGrade.Checked)
            {
                Eleventhgrade = "یازدهم";
            }
            if (cboxTwelfthGrade.Checked )
            {
                Twelfthgrade = "دوازدهم";
            }
            int ID = (int)dgvLession.CurrentRow.Cells["IDLession"].Value;
            QuestionBL questionBL = new QuestionBL();
            var resultQuestion = questionBL.SelectQuestionsbylessionIDAndGrade(ID, Tenthgrade, Eleventhgrade, Twelfthgrade);
            if (resultQuestion != null)
            {
                foreach (var item in resultQuestion.Data)
                {
                    dgvQuestion.Rows.Add(item.ID, item.QuestionText, item.DifficultyLevel, item.QuestionType, item.Session, item.Grade);
                }
            }
        }

        private void cboxTwelfthGrade_CheckedChanged(object sender, EventArgs e)
        {
            selectdgvQuestion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
