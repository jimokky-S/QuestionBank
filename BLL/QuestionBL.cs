using BLL.QuestionBank;
using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionBL : IQuestions
    {

        Question question;
        OperationResult result;

        public QuestionBL()
        {
            question = new Question();
            result = new OperationResult();
        }
        public OperationResult DeleteQuestions(int Id)
        {
            var result = question.DeleteQuestions(Id);
            return result;
        }

        public OperationResult InsertQuestions(QuestionModel questions)
        {

            if (questions.QuestionText != "" && questions.DifficultyLevel != "" &&
                questions.QuestionType != "" && questions.Session != "" &&
                questions.grade != "")
            {
                result = question.InsertQuestions(questions);
                if (result.Success)
                {
                    result.Message = "موفقیت آمیز بود";

                }
                else
                {
                    result.Message = "موفقیت آمیز نبود";

                }
            }
            else
            {
                result.Message = "لطفا تمام مقادیر را پر کنید ";
            }
            return result;
        }

        public OperationResult<List<Tbl_Question>> SelectQuestions(string search = "")
        {
            var operation = question.SelectQuestions(search);
            return operation;
        }

        public OperationResult UpdataQuestions(int Id, QuestionModel questions)
        {
            if (questions.QuestionText != "" && questions.DifficultyLevel != "" &&
               questions.QuestionType != "" && questions.Session != "" &&
               questions.grade != "")
            {
                result = question.UpdataQuestions(Id, questions);
                if (result.Success)
                {
                    result.Message = "موفقیت آمیز بود";

                }
                else
                {
                    result.Message = "موفقیت آمیز نبود";

                }
            }
            else
            {
                result.Message = "لطفا تمام مقادیر را پر کنید";
            }
            return result;
        }

        public OperationResult<List<Tbl_Question>> SelectQuestionsforExam(int IDlession, string Grade, string difficultyLevel, string Session,string TestQuestion = ""
            , string ShortAnswer = "", string Descriptive = "")
        {
            if (IDlession > 0)
            {
                var result = question.SelectQuestionsforExam(IDlession, Grade, difficultyLevel, Session, TestQuestion, ShortAnswer, Descriptive);
                return result;
            }
            else { return null; }
        }


        public OperationResult<List<Tbl_Question>> SelectQuestionsbylessionIDAndGrade(int lessionID, string Tenthgrade = "", string Eleventhgrade = "", string Twelfthgrade = "")
        {
            if (lessionID > 0)
            {
                var result = question.SelectQuestionsbylessionIDAndGrade(lessionID, Tenthgrade, Eleventhgrade, Twelfthgrade);
                return result;
            }
            else { return null; }
        }


    }
}
