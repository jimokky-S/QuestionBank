using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IQuestionDetails
    {
        OperationResult InsertQuestionDetaile(QuestionDetailsModel questionDetaile);
        OperationResult DeleteQuestionDetaile(int Id);
        OperationResult UpdataQuestionDetaile(int Id, QuestionDetailsModel questionDetaile);
        OperationResult<List<Tbl_QuestionDetail>> SelectQuestionDetaile(string search = "");
    }
}
