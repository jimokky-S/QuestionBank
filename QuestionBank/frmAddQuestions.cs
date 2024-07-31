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
using BLL;
using BLL.QuestionBank;
using DAL;

namespace QuestionBank
{
    public partial class frmAddQuestions : Form
    {
        LessionBL lessionBL;
        int lessionID = 0;
        public frmAddQuestions()
        {
            lessionBL = new LessionBL();
            InitializeComponent();
        }
        public frmAddQuestions(int lessionID)
        {
            InitializeComponent();
            lessionBL = new LessionBL();
            this.lessionID = lessionID;
        }

        private void frmAddQuestions_Load(object sender, EventArgs e)
        {
            var less = lessionBL.SelectLession();
            if (this.lessionID == 0)
            {
                foreach (var item in less.Data)
                {
                    cmboxLession.Items.Add(item.Name);
                }
            }
            else
            {
                foreach (var item in less.Data)
                {
                    if (item.ID == this.lessionID)
                    {
                        cmboxLession.Items.Add(item.Name);
                    }
                }
            }

        }

        private void chboxPodeman_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPodeman.Checked)
            {
                gboxPodeman.Enabled = true;
                gboxSession.Enabled = false;

            }
            else
            {
                gboxPodeman.Enabled = false;
                gboxSession.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txtQuestion.Text = string.Empty;
            cmboxPodeman.Text = string.Empty;
            cmboxLession.Text = string.Empty;
            nudSession.Value = 0;
        }

        private void lblMessageQuestion_TextChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                try
                {
                    Thread.Sleep(3000);
                    Invoke(new Action(() => { lblMessageQuestion.Text = ""; }));
                }
                catch (Exception)
                {


                }


            });
        }

        private void rbtnTestQuestion_CheckedChanged(object sender, EventArgs e)
        {
            lblTypeQuestion.Text = rbtnTestQuestion.Text;
            gboxQuestions.Enabled = true;

        }

        private void rbtnDescriptive_CheckedChanged(object sender, EventArgs e)
        {
            lblTypeQuestion.Text = rbtnDescriptive.Text;
            gboxQuestions.Enabled = true;
            //gboxTestQuestion.Enabled = false;
            //gboxShortAnswer.Enabled = false;

        }

        private void rbtnShortAnswer_CheckedChanged(object sender, EventArgs e)
        {
            lblTypeQuestion.Text = rbtnShortAnswer.Text;
            gboxQuestions.Enabled = true;
            //gboxTestQuestion.Enabled = false;
            //gboxShortAnswer.Enabled = false;
        }

        private void gboxQuestions_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnTenthGrade_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = rbtnTenthGrade.Text;
        }

        private void rbtnEleventhGrade_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = rbtnEleventhGrade.Text;
        }

        private void rbtnTwelfthGrade_CheckedChanged(object sender, EventArgs e)
        {
            lblGrade.Text = rbtnTwelfthGrade.Text;
        }

        private void btnInsertDescriptive_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text != string.Empty)
            {
                var result = InsertDescriptive();
                lblMessageQuestion.Text = result.Message;
                if (result.Success)
                {
                    lblMessageQuestion.Text = "ثبت موفقیت آمیز بود";
                }
                else
                {
                    lblMessageQuestion.Text = result.Message;
                }

                if (rbtnTestQuestion.Checked)
                {
                    frmTestQuestionAdd frm = new frmTestQuestionAdd();
                    frm.ShowDialog();
                }
                else
                if (rbtnShortAnswer.Checked)
                {
                    frmShortAwmserAdd frm = new frmShortAwmserAdd();
                    frm.ShowDialog();
                }

            }

            clear();
        }

        private void rbtnEsay_CheckedChanged(object sender, EventArgs e)
        {
            lblDifficultyLevel.Text = rbtnEsay.Text;
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            lblDifficultyLevel.Text = rbtnMedium.Text;
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)
        {
            lblDifficultyLevel.Text = rbtnHard.Text;
        }

        private OperationResult InsertDescriptive()
        {
            QuestionBL questionBL = new QuestionBL();
            var lession = lessionBL.SelectLession();
            int lessionID = 0;
            foreach (var item in lession.Data)
            {
                if (item.Name == cmboxLession.Text)
                {
                    lessionID = item.ID;
                    break;
                }
            }
            string session = "";
            if (cboxPodeman.Checked)
            {
                session = cmboxPodeman.Text;
            }
            else { session = "فصل" + " " + nudSession.Value.ToString(); }

            QuestionModel questionModel = new QuestionModel()
            {
                grade = lblGrade.Text,
                DifficultyLevel = lblDifficultyLevel.Text,
                LessionID = lessionID,
                QuestionText = txtQuestion.Text,
                QuestionType = lblTypeQuestion.Text,
                Session = session,

            };


            var Result = questionBL.InsertQuestions(questionModel);
            return Result;
        }






        private void cboxPodeman_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPodeman.Checked)
            {
                gboxPodeman.Enabled = true;
                gboxSession.Enabled = false;
            }
            else
            {
                gboxSession.Enabled = true;
                gboxPodeman.Enabled = false;
            }
        }
        private void gboxPodeman_Enter(object sender, EventArgs e)
        {

        }

        private void gboxTypeQuestions_Enter(object sender, EventArgs e)
        {

        }

    }
}
