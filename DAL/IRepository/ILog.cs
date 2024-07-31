using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface  ILog 
    {
        OperationResult InsertLog(LogModel Log);
        OperationResult DeleteLog(int Id);
        OperationResult UpdataLog(int Id, LogModel Log);
        OperationResult<List<Tbl_Log>> SelectLog(string search = "");
    }
}
