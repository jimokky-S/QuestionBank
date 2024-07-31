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
    public partial class frmShortAwmserAdd : Form
    {
        public frmShortAwmserAdd()
        {
            InitializeComponent();
        }

        private void frmShortAwmserAdd_Load(object sender, EventArgs e)
        {

        }

        private void gboxShortAnswer_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsertShortAnswer_Click(object sender, EventArgs e)
        {
            //گرفتن ای ای Question
            QuestionBL questionBL = new QuestionBL();
            var Question = questionBL.SelectQuestions();
            var idQuestion = Question.Data.Select(x => x.ID).ToList().LastOrDefault();


            QuestionDetailsModel detailsModel = new QuestionDetailsModel()
            {
                IDQuestions = idQuestion,
                Text = txtShortAnwser.Text,

            };
            QuestionDetailsBL questionDetailsBL = new QuestionDetailsBL();
            var result = questionDetailsBL.InsertQuestionDetaile(detailsModel);
            lblMessageQuestion.Text = result.Message;

            txtShortAnwser.Clear();
        }

        private void btnSaveandCloseShortAnswer_Click(object sender, EventArgs e)
        {
            btnInsertShortAnswer_Click(sender , e);
            this.Close();
        }
    }
}
