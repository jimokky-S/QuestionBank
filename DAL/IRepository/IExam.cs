using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IExam
    {
        OperationResult InsertExam(ExamModel examModel);

        OperationResult DeleteExam(int Id);

        OperationResult UpdataExam(int Id, ExamModel examModel);

        OperationResult<List<Tbl_Exam>> SelectExam(string search = "");
    }
}
