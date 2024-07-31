using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamDetailsBL : IExamDetails
    {

        ExamDetailsBL examDetails;
        public ExamDetailsBL()
        {

            examDetails = new ExamDetailsBL();
        }
        public OperationResult DeleteExamDetaile(int Id)
        {
            var result = examDetails.DeleteExamDetaile(Id);
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

        public OperationResult InsertExamDetaile(ExamDetaileModel examDetaile)
        {
            OperationResult result = new OperationResult();

            if (examDetaile.Score != 0 && examDetaile.QuestionID != 0)
            {
                result = examDetails.InsertExamDetaile(examDetaile);
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
                result.Message = "لطفا مقادیر را پر کنید";
            }
            return result;
        }

        public OperationResult<List<Tbl_ExamDetali>> SelectExamDetails(string search = "")
        {
            var result = examDetails.SelectExamDetails(search);
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

        public OperationResult UpdataExamDetaile(int Id, ExamDetaileModel examDetaile)
        {
            OperationResult result = new OperationResult();

            if (examDetaile.Score != 0 && examDetaile.QuestionID != 0)
            {
                result = examDetails.UpdataExamDetaile(Id, examDetaile);
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
    }
}