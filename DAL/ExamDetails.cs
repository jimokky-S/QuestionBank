using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamDetails : IExamDetails
    {

        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True;";
        OperationResult result;
        questionBankDataContext db;
        public ExamDetails()
        {
            db= new questionBankDataContext(connectionString);
            result = new OperationResult();
        }
        public OperationResult DeleteExamDetaile(int Id)
        {
            try
            {
                var del = db.Tbl_ExamDetalis.Where(x => x.ID == Id).SingleOrDefault();
                db.Tbl_ExamDetalis.DeleteOnSubmit(del);
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

        public OperationResult InsertExamDetaile(ExamDetaileModel examDetaile)
        {
            try
            {
                Tbl_ExamDetali tbl_ExamDetali = new Tbl_ExamDetali();
                tbl_ExamDetali = update(examDetaile);
                db.Tbl_ExamDetalis.InsertOnSubmit(tbl_ExamDetali);
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

        public OperationResult<List<Tbl_ExamDetali>> SelectExamDetails(string search = "")
        {
            OperationResult<List<Tbl_ExamDetali>> Op = new OperationResult<List<Tbl_ExamDetali>>();
            try
            {
                var selectDate = db.Tbl_ExamDetalis.ToList();
                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectDate;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }

        public OperationResult UpdataExamDetaile(int Id, ExamDetaileModel examDetaile)
        {
            try
            {
                Tbl_ExamDetali tbl_ExamDetali = new Tbl_ExamDetali();
                tbl_ExamDetali = db.Tbl_ExamDetalis.Where(x => x.ID == Id).Single();
                tbl_ExamDetali = update(examDetaile);
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
        private Tbl_ExamDetali update(ExamDetaileModel examDetaileModel)
        {
            Tbl_ExamDetali tbl_ExamDetali = new Tbl_ExamDetali()
            {
                ExamID = examDetaileModel.ExamID,
                QuestionID = examDetaileModel.QuestionID,
                Score = examDetaileModel.Score,
            };
            return tbl_ExamDetali;
        }
    }
}
