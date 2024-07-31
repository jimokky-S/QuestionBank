using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Log : ILog
    {

        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True;";
        OperationResult result;
        questionBankDataContext db;

        public Log()
        {
            db = new questionBankDataContext(connectionString);
            result = new OperationResult();
        }
        public OperationResult DeleteLog(int Id)
        {
            throw new NotImplementedException();
        }

        public OperationResult InsertLog(LogModel log)
        {
            try
            {
                Tbl_Log Log = new Tbl_Log()
                {
                 UserID = log.IdUser,
                 DateTimeLogin = DateTime.Now,
                };
                db.Tbl_Logs.InsertOnSubmit(Log);
                db.SubmitChanges();
                result.Success = true;
                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
        }

        public OperationResult<List<Tbl_Log>> SelectLog(string search = "")
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdataLog(int Id, LogModel examDetaile)
        {
            throw new NotImplementedException();
        }
    }
}
