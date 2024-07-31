using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Exam : IExam
    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True";
        OperationResult result; 
        questionBankDataContext db;
        public Exam()
        {
            db = new questionBankDataContext(connectionString);
            result = new OperationResult();
        }

        public OperationResult DeleteExam(int Id)
        {
            try
            {
                var del = db.Tbl_Exams.Where(x => x.ID == Id).ToList().Single();
                db.Tbl_Exams.DeleteOnSubmit(del);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Success=false;
                result.Message = ex.Message;
            }
            return result;
        }

        public OperationResult InsertExam(ExamModel examModel)
        {
            try
            {
                Tbl_Exam tbl_Exam = new Tbl_Exam();
                tbl_Exam = updata(examModel);
                db.Tbl_Exams.InsertOnSubmit(tbl_Exam);
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

        public OperationResult<List<Tbl_Exam>> SelectExam(string search = "")
        {
            OperationResult<List<Tbl_Exam>> Op = new OperationResult<List<Tbl_Exam>>();
            try
            {
                var selectData = db.Tbl_Exams.Where(x => x.Grade.Contains(search)).ToList();

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

        public OperationResult UpdataExam(int Id, ExamModel examModel)
        {
            try
            {
                Tbl_Exam tbl_Exam = new Tbl_Exam();
                tbl_Exam = db.Tbl_Exams.Where(x => x.ID == Id).Single();
                tbl_Exam = updata(examModel);
                db.SubmitChanges();
                result.Success= true;
                result.Message = string.Empty;

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;

        }

        private Tbl_Exam updata(ExamModel examModel)
        {
            Tbl_Exam tbl_Exam = new Tbl_Exam()
            { 
                DateTimeCreateExam=examModel.DateTimeCreateExam,
               
                lessionID = examModel.LessionID,
                LogID = examModel.LogID,
                
            };
            return tbl_Exam;
        }

    }
}
