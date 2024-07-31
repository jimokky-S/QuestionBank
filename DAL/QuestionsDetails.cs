using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuestionsDetails : IQuestionDetails
    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True";

        OperationResult result;
        questionBankDataContext db;
        public QuestionsDetails() 
        {
            result = new OperationResult();
            db = new questionBankDataContext();
        }
        public OperationResult DeleteQuestionDetaile(int Id)
        {
            try
            {
                var del = db.Tbl_QuestionDetails.Where(x => x.ID == Id).ToList().Single();
                db.Tbl_QuestionDetails.DeleteOnSubmit(del);
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

        public OperationResult InsertQuestionDetaile(QuestionDetailsModel questionDetaile)
        {
            try
            {
                Tbl_QuestionDetail tbl_QuestionDetail = new Tbl_QuestionDetail();
                tbl_QuestionDetail = updata(questionDetaile);
                db.Tbl_QuestionDetails.InsertOnSubmit(tbl_QuestionDetail);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;

            }
            return result;
        }

        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetaile(string search = "")
        {
            OperationResult<List<Tbl_QuestionDetail>> Op = new OperationResult<List<Tbl_QuestionDetail>>();
            try
            {
                var selectData = db.Tbl_QuestionDetails.Where(x => x.text.Contains(search)).ToList();

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

        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetaile(int QuestionID)
        {
            OperationResult<List<Tbl_QuestionDetail>> Op = new OperationResult<List<Tbl_QuestionDetail>>();
            try
            {
                var selectData = db.Tbl_QuestionDetails.Where(x => x.IDQuestions==QuestionID).ToList();

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

        public OperationResult UpdataQuestionDetaile(int Id, QuestionDetailsModel questionDetaile)
        {
            try
            {
                Tbl_QuestionDetail tbl_QuestionDetail = new Tbl_QuestionDetail();
                tbl_QuestionDetail = db.Tbl_QuestionDetails.Where(x => x.ID == Id).Single();
                tbl_QuestionDetail = updata(questionDetaile);
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



        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetailsByQuestionID(int QuestionID)
        {
            OperationResult<List<Tbl_QuestionDetail>> Op = new OperationResult<List<Tbl_QuestionDetail>>();
            try
            {
                var selectData = db.Tbl_QuestionDetails.Where(x => x.IDQuestions == QuestionID).ToList();
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

        private Tbl_QuestionDetail updata(QuestionDetailsModel questionDetaile)
        {
            Tbl_QuestionDetail tbl_QuestionDetail = new Tbl_QuestionDetail()
            {
                IDQuestions = questionDetaile.IDQuestions,
                text = questionDetaile.Text,

            };
            return tbl_QuestionDetail;
        }
    }
}
