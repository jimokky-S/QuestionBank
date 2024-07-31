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
    public partial class frmTestQuestionAdd : Form
    {
        public frmTestQuestionAdd()
        {
            InitializeComponent();
        }

        private void txtTestQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOption1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOption2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOption3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOption4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveandCloseTestQuestion_Click(object sender, EventArgs e)
        {
           btnInsertTestQuestion_Click(sender , e);
           this.Close();
        }

        private void btnInsertTestQuestion_Click(object sender, EventArgs e)
        {
            //گرفتن ای ای Question
            QuestionBL questionBL = new QuestionBL();
            var Question = questionBL.SelectQuestions();
            var idQuestion = Question.Data.Select(x => x.ID).ToList().LastOrDefault();


            QuestionDetailsModel detailsModel = new QuestionDetailsModel()
            {
                IDQuestions = idQuestion,
                Text = txtTestQuestion.Text,

            };
            QuestionDetailsBL questionDetailsBL = new QuestionDetailsBL();
            var result = questionDetailsBL.InsertQuestionDetaile(detailsModel);
            if (!result.Success)
            {
                MessageBox.Show(result.Message);
            }
            //گرفتن ای دی QestionDetails
            var QuestionDetails = questionDetailsBL.SelectQuestionDetaile();
            var idQuestionDetails = QuestionDetails.Data.Select(x => x.ID).ToList().LastOrDefault();

            //ذخیره کردن TestQuestion
            TestQuestionsModel testQuestions1 = new TestQuestionsModel()
            {
                Text = txtOption1.Text,
                Priority = 0,
                QuestionDetailsID = idQuestionDetails,
            };
            var success1 = insertTestQuestion(testQuestions1);

            TestQuestionsModel testQuestions2 = new TestQuestionsModel()
            {
                Text = txtOption2.Text,
                Priority = 1,
                QuestionDetailsID = idQuestionDetails,
            };
            var success2 = insertTestQuestion(testQuestions2);

            TestQuestionsModel testQuestions3 = new TestQuestionsModel()
            {
                Text = txtOption3.Text,
                Priority = 2,
                QuestionDetailsID = idQuestionDetails,
            };
            var success3 = insertTestQuestion(testQuestions3);

            TestQuestionsModel testQuestions4 = new TestQuestionsModel()
            {
                Text = txtOption4.Text,
                Priority = 3,
                QuestionDetailsID = idQuestionDetails,
            };
            var success4 = insertTestQuestion(testQuestions4);

            if (success1.Success == true && success2.Success == true && success3.Success == true && success4.Success==true)
            {
                txtOption1.Clear(); txtOption2.Clear(); txtOption3.Clear(); txtOption4.Clear();
                lblMessageQuestion.Text = "";
            }
        }

        private void frmTestQuestionAdd_Load(object sender, EventArgs e)
        {

        }

        private OperationResult insertTestQuestion(TestQuestionsModel testQuestionsModel)
        {
            TestQuestions testQuestions = new TestQuestions();
            var result = testQuestions.InsertTestQuestions(testQuestionsModel);
            lblMessageQuestion.Text = result.Message;
            return result;

        }

        private void lblMessageQuestion_Click(object sender, EventArgs e)
        {

        }

        private void gboxTestQuestion_Enter(object sender, EventArgs e)
        {

        }
    }
}
