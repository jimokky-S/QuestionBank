using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IQuestions
    {
        OperationResult InsertQuestions(QuestionModel questions);

        OperationResult DeleteQuestions(int Id);

        OperationResult UpdataQuestions(int Id, QuestionModel questions);


        OperationResult<List<Tbl_Question>> SelectQuestions(string search = "");
    }
}
