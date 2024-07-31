using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestQuestions : ITestQuestions
    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True;";
        OperationResult result;
        questionBankDataContext db;
        public TestQuestions()
        {
            db = new questionBankDataContext(connectionString);
            result = new OperationResult();
        }
        public OperationResult DeleteTestQuestions(int Id)
        {
            try
            {
                var del = db.Tbl_TestQuestions.Where(x => x.ID == Id).SingleOrDefault();
                db.Tbl_TestQuestions.DeleteOnSubmit(del);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public OperationResult InsertTestQuestions(TestQuestionsModel testQuestions)
        {
            try
            {
                Tbl_TestQuestion tquestion = new Tbl_TestQuestion();
                tquestion = update(testQuestions);
                db.Tbl_TestQuestions.InsertOnSubmit(tquestion);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestions(string search = "")
        {
            OperationResult<List<Tbl_TestQuestion>> Op = new OperationResult<List<Tbl_TestQuestion>>();
            try
            {
                var selectDate = db.Tbl_TestQuestions.Where(x => x.Text.Contains(search)).ToList();
                Op.Data = selectDate;
                Op.Success = true;
                Op.Message = string.Empty;
            }
            catch (Exception ex )
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }

        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestionsByIDQuestionDetails(int IDQuestionDetails)
        {
            OperationResult<List<Tbl_TestQuestion>> Op = new OperationResult<List<Tbl_TestQuestion>>();
            try
            {
                var selectDate = db.Tbl_TestQuestions.Where(x => x.QuestionDetailsID== IDQuestionDetails).ToList();
                Op.Data = selectDate;
                Op.Success = true;
                Op.Message = string.Empty;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }


        public OperationResult UpdataTestQuestions(int Id, TestQuestionsModel testQuestions)
        {
            try
            {
                Tbl_TestQuestion tquestion = new Tbl_TestQuestion();
                tquestion= db.Tbl_TestQuestions.Where(x=>x.ID == Id).SingleOrDefault();
                tquestion = update(testQuestions);
                
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestionByQuestionDetailID(int QuestionDetailID)
        {
            OperationResult<List<Tbl_TestQuestion>> Op = new OperationResult<List<Tbl_TestQuestion>>();
            try
            {
                var selectDate = db.Tbl_TestQuestions.Where(x => x.QuestionDetailsID == QuestionDetailID).ToList();
                Op.Data = selectDate;
                Op.Success = true;
                Op.Message = string.Empty;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }

        private Tbl_TestQuestion update(TestQuestionsModel testQuestionsModel)
        {
            Tbl_TestQuestion testQuestion = new Tbl_TestQuestion()
            {
                QuestionDetailsID = testQuestionsModel.QuestionDetailsID,
                Text = testQuestionsModel.Text,
                Priority = testQuestionsModel.Priority,
            };
            return testQuestion;
        }
    }
}
