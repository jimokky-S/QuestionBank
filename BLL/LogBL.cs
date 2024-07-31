using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogBL : ILog
    {
        public OperationResult DeleteLog(int Id)
        {
            throw new NotImplementedException();
        }

        public OperationResult InsertLog(LogModel log)
        {
            OperationResult result = new OperationResult();
            if (log != null || log.IdUser != 0)
            {
                Log tbl_log = new Log();
                result = tbl_log.InsertLog(log);
            }
            return result;
        }

        public OperationResult<List<Tbl_Log>> SelectLog(string search = "")
        {
            throw new NotImplementedException();
        }

        public OperationResult UpdataLog(int Id, LogModel Log)
        {
            throw new NotImplementedException();
        }
    }
}
