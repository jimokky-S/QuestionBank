using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IExamDetails
    {
        OperationResult InsertExamDetaile(ExamDetaileModel examDetaile);
        OperationResult DeleteExamDetaile(int Id);
        OperationResult UpdataExamDetaile(int Id, ExamDetaileModel examDetaile);
        OperationResult<List<Tbl_ExamDetali>> SelectExamDetails(string search = "");
    }
}
