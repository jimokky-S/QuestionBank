using BLL;
using BLL.QuestionBank;
using DAL;
using DAL.IRepository;
using NuGet;
using Stimulsoft.Base;
using Stimulsoft.Controls.Win.DotNetBar;
using Stimulsoft.Report;
using Stimulsoft.Report.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuestionBank
{
    public partial class frmCreateExam : Form
    {
        int lessionID = 0;
        ExamModel examModel ;
        public frmCreateExam(int lessionID)
        {
            InitializeComponent();
            this.lessionID = lessionID;
            examModel = new ExamModel();
        }
        public frmCreateExam()
        {
            InitializeComponent();
            examModel = new ExamModel();
        }
        string Grade, TestQuestion = "" , ShortAnswer = "", Descriptive = "",difficultyLevel , Session;
        int NumberLine = 0;
        private void cboxTestQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxTestQuestion.Checked == true)
            {
                TestQuestion = "سوال تستی";
            }
            else
            {
                TestQuestion = "";
            }
        }

        private void cboxShortAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShortAnswer.Checked == true)
            {
                ShortAnswer = "کوتاه پاسخ";
            }
            else
            {
                ShortAnswer = "";
            }
        }

        private void cboxDescriptive_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDescriptive.Checked == true)
            {
                Descriptive = "تشریحی";
            }
            else
            {
                Descriptive = "";
            }
        }

        private void rbtnTenthGrade_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTenthGrade.Checked == true)
            {
                Grade = "دهم";
            }
            else
            {
                Grade = "";
            }
        }

        private void rbtnEleventhGrade_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEleventhGrade.Checked == true)
            {
                Grade = "یازدهم";
            }
            else
            {
                Grade = "";
            }
        }

        private void rbtnTwelfthGrade_CheckedChanged(object sender, EventArgs e)
        {
             if (rbtnTwelfthGrade.Checked == true)
            {
                Grade = "دوازدهم";
            }
            else
            {
                Grade = "";
            }
        }

        private void nudNumberQuestion_ValueChanged(object sender, EventArgs e)
        {

            if (nudNumberQuestion.Value <= 0 || nudNumberQuestion.Value > 60)
            {
                MessageBox.Show("تعداد سوالات باید بالاتر از 1 و کوچیکتر از 60 باشد");
                nudNumberQuestion.Value = 20;
            }
        }

        private void rbtnEsay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEsay.Checked==true)
            {
                difficultyLevel = "آسان";

            }
            else
            {
                difficultyLevel = "";
            }
        }

        private void rbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMedium.Checked == true)
            {
                difficultyLevel = "متوسط";

            }
            else
            {
                difficultyLevel = "";
            }
        }

        private void rbtnHard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHard.Checked == true)
            {
                difficultyLevel = "سخت";

            }
            else
            {
                difficultyLevel = "";
            }
        }

        private void cmboxPodeman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxPodeman.Text=="پودمان 1")
            {
                this.NumberLine = 1;
            }
            else
            if (cmboxPodeman.Text == "پودمان 2")
            {
                this.NumberLine = 2;
            }
            else
            if (cmboxPodeman.Text == "پودمان 3")
            {
                this.NumberLine = 3;
            }
            else
            if (cmboxPodeman.Text == "پودمان 4")
            {
                this.NumberLine = 4;
            }
            else 
            {
                this.NumberLine =5;
            }
        }

        private void frmCreateExam_Load(object sender, EventArgs e)
        {
            rbtnTenthGrade.Enabled = true;
            rbtnEsay.Enabled = true;
            LessionBL lessionBL = new LessionBL();
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

        private void cmboxLession_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboxPodeman_CheckedChanged(object sender, EventArgs e)
        {

            if (cboxPodeman.Checked == true)
            {
                cmboxPodeman.Enabled = true;
                pnlSession.Enabled = false;
            }
            else
            {
                pnlSession.Enabled = true;
                cmboxPodeman.Enabled = false;
            }
        }

        private void nudSession_ValueChanged(object sender, EventArgs e)
        {

            if (nudSession.Value <= 0 || nudSession.Value > 30)
            {
                MessageBox.Show("لطفا تعداد فصل ها بین 1 تا 30 باشد");
                nudSession.Value = 1;
                return;
            }
            NumberLine = (int)nudSession.Value;
        }

        private void btnCreateExam_Click(object sender, EventArgs e)
        {
            LessionBL lessionBL = new LessionBL();
            if (cboxPodeman.Checked==true)
            {
                Session = cmboxPodeman.Text;
            }
            else
            {
                Session = "فصل " + nudSession.Value.ToString();
            }
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
            QuestionBL questionBL = new QuestionBL();
            QuestionDetailsBL detailsBL = new QuestionDetailsBL();
            TestQuestionBL testQuestionBL = new TestQuestionBL();
            StiReport stiReport = new StiReport();
            stiReport.Load(@"D:\C#\Report.mrt");
            var question =  questionBL.SelectQuestionsforExam(lessionID, this.Grade, this.difficultyLevel, this.Session, this.TestQuestion, this.ShortAnswer, this.Descriptive);
            List<string> Question = new List<string>();
            List<string> questionDetails = new List<string>();
            List<string> testQuestion = new List<string>();
            if (question.Data.Count == 0)
            {
                MessageBox.Show("سوال موجود نیست");
            }
            else
            {
                int numberQuestion = 0;
                int numberQ = 1;

                foreach (var item in question.Data)
                {
                    Question.Add(numberQ++ + "-" + item.QuestionText);
                    string[] ABJAD = { "الف", "ب", "ج", "د", "ه", "و", "ز", "ح", "ط", "ی", "ک", "ل", "م", "ن", "س", "ع", "ف", "ص", "ق", "ر", "ش", "ت", "ث", "خ", "ذ", "ض", "ظ", "غ" };
                    var questionDetalis = detailsBL.SelectQuestionDetailsByQuestionID(item.ID);
                    if (questionDetalis.Data.Count > 0)
                    {
                        int numberD = 0;
                        foreach (var itemquestionDetails in questionDetalis.Data)
                        {
                            var tQuestion = testQuestionBL.SelectTestQuestionsByIDQuestionDetails(itemquestionDetails.ID);
                            if (item.ID == itemquestionDetails.IDQuestions)
                            {
                                Question.Add(ABJAD[numberD] + ") " + itemquestionDetails.text+"\n");
                                numberD++;
                                if (numberD == 27)
                                {
                                    numberD = 0;
                                }
                                if (tQuestion.Data.Count > 0)
                                {
                                    int NumbetT = 1;
                                    string tQ="";
                                    foreach (var itemtestQuestion in tQuestion.Data)
                                    {
                                        if (itemquestionDetails.ID == itemtestQuestion.QuestionDetailsID)
                                        {
                                           
                                           
                                            tQ += ""+ NumbetT++ + ")" + itemtestQuestion.Text + " [░]\n\n\r";

                                        }
                                    }
                                    Question.Add(tQ);
                                }
                            }
                            
                        }
                    }
                    numberQuestion++;
                    if (numberQuestion == this.NumberLine)
                    {
                        break;
                        
                    }
                    

                }
                if (Question.LastOrDefault()== "─────────────────────────────────────")
                {
                    int countQuestion = Question.Count();
                    Question.RemoveAt(countQuestion - 1);
                }
                var logo = Image.FromFile(Path.Combine(Application.StartupPath, "Logo.png"));
                stiReport.Dictionary.Variables["VarLogo"].ValueObject = logo;
                stiReport.RegBusinessObject("Question", Question);
                stiReport.Show();
                //ExamBL examBL = new ExamBL();
                //examModel
                //examBL.InsertExam();
            }
        }
    }
}
