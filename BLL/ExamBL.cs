using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamBL : IExam
    {
        Exam exam;
        public ExamBL() 
        {
            exam = new Exam();
        }
        public OperationResult DeleteExam(int Id)
        {
            var result = exam.DeleteExam(Id);
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
        public OperationResult InsertExam(ExamModel examModel)
        {
            OperationResult result = new OperationResult();

            if (examModel.LessionID!= 0 && examModel.LogID!= 0 && examModel.MaxScore!= 0 &&
                examModel.Type!=""&& examModel.Duration!=0)
            {
                result = exam.InsertExam(examModel);
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
        public OperationResult<List<Tbl_Exam>> SelectExam(string search = "")
        {
            var result = exam.SelectExam(search);
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
        public OperationResult UpdataExam(int Id, ExamModel examModel)
        {
            OperationResult result = new OperationResult();

            if (examModel.LessionID != 0 && examModel.LogID != 0 && examModel.MaxScore != 0 &&
                examModel.Type != "" && examModel.Duration != 0)
            {
                result = exam.UpdataExam(Id,examModel);
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
