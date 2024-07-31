using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ILessions
    {
        OperationResult InsertLession(LessionModel lessionModel);
        OperationResult DeleteLession(int Id);
        OperationResult UpdataLession(int Id, LessionModel lessionModel);
        OperationResult<List<Tbl_Lession>> SelectLession(string search = "");
    }
}
