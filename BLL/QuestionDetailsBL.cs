using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DAL.IRepository;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionDetailsBL : IQuestionDetails
    {
        QuestionsDetails QuestionDetail;
        public QuestionDetailsBL() 
        {
            QuestionDetail = new QuestionsDetails();
        }
        public OperationResult DeleteQuestionDetaile(int Id)
        {
            var result = QuestionDetail.DeleteQuestionDetaile(Id);
            return result;
        }

        public OperationResult InsertQuestionDetaile(QuestionDetailsModel questionDetaile)
        {
            OperationResult result = new OperationResult();

            if (questionDetaile.IDQuestions != 0 && questionDetaile.Text != "" )
            {
                result = QuestionDetail.InsertQuestionDetaile(questionDetaile);
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
                result.Success = false;
                result.Message = "لطفا تمام مقادیر را پر کنید";
            }
            return result;
        }

        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetaile(string search = "")
        {
            var result = QuestionDetail.SelectQuestionDetaile(search);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetaile(int QuestionID)
        {
            var result = QuestionDetail.SelectQuestionDetaile(QuestionID);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult UpdataQuestionDetaile(int Id, QuestionDetailsModel questionDetaile)
        {
            OperationResult result = new OperationResult();

            if ( questionDetaile.IDQuestions != 0 && questionDetaile.Text != "")
            {
                result = QuestionDetail.UpdataQuestionDetaile(Id, questionDetaile);
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
                result.Success = false;
                result.Message = "لطفا تمام مقادیر را پر کنید";
            }
            return result;

        }

        public OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetailsByQuestionID(int QuestionID)
        {
            if (QuestionID > 0)
            {
                var result = QuestionDetail.SelectQuestionDetailsByQuestionID(QuestionID);
                return result;
            }
            else { return null; }
        }
    }
}
