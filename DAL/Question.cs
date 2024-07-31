using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Question : IQuestions

    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True";

        OperationResult result;
        questionBankDataContext db;
        public Question()
        {
            result = new OperationResult();
            db = new questionBankDataContext(connectionString);
        }
        public OperationResult InsertQuestions(QuestionModel questions)
        {
            try
            {
                Tbl_Question question = new Tbl_Question();
                question = updata(questions);
                db.Tbl_Questions.InsertOnSubmit(question);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
                return result;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }

        }
        public OperationResult DeleteQuestions(int Id)
        {
            try
            {

                var del = db.Tbl_Questions.Where(x => x.ID == Id).ToList().Single();
                db.Tbl_Questions.DeleteOnSubmit(del);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
                return result;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }
        public OperationResult UpdataQuestions(int Id, QuestionModel questions)
        {
            try
            {

                Tbl_Question tbl_question = new Tbl_Question();
                tbl_question = db.Tbl_Questions.Where(x => x.ID == Id).Single();
                tbl_question = updata(questions);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }

        }
        public OperationResult<List<Tbl_Question>> SelectQuestions(string search = "")
        {
            OperationResult<List<Tbl_Question>> Op = new OperationResult<List<Tbl_Question>>();
            try
            {
                var selectData = db.Tbl_Questions.Where(x => x.QuestionText.Contains(search)).ToList();
                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectData;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }

        public OperationResult<List<Tbl_Question>> SelectQuestionsforExam(int IDlession, string Grade, string difficultyLevel , string Session, string TestQuestion = ""
            , string ShortAnswer = "", string Descriptive = "")
        {
            OperationResult<List<Tbl_Question>> Op = new OperationResult<List<Tbl_Question>>();
            try
            {
                var selectData = db.Tbl_Questions.Where(x => x.lessionID == IDlession && x.Grade == Grade && x.Session == Session && (x.QuestionType == TestQuestion || x.QuestionType == ShortAnswer || x.QuestionType == Descriptive)&&x.DifficultyLevel==difficultyLevel).ToList();

                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectData;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }
        public OperationResult<List<Tbl_Question>> SelectQuestionsbylessionIDAndGrade(int IDlession, string Tenthgrade = "", string Eleventhgrade = "", string Twelfthgrade = "")
        {
            OperationResult<List<Tbl_Question>> Op = new OperationResult<List<Tbl_Question>>();
            try
            {
                var selectData = db.Tbl_Questions.Where(x => x.lessionID == IDlession && (x.Grade == (Tenthgrade) ||
                x.Grade == (Eleventhgrade) || x.Grade == (Twelfthgrade))).ToList();
                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectData;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }

        private Tbl_Question updata(QuestionModel questions)
        {
            Tbl_Question tbl_Question = new Tbl_Question()
            {
                QuestionText = questions.QuestionText,
                QuestionType = questions.QuestionType,
                DifficultyLevel = questions.DifficultyLevel,
                Session = questions.Session,
                lessionID = questions.LessionID,
                Grade = questions.grade,
            };

            return tbl_Question;
        }
    }
}
