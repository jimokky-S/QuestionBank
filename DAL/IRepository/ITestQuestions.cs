using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ITestQuestions
    {
        OperationResult InsertTestQuestions(TestQuestionsModel testQuestions);
        OperationResult DeleteTestQuestions(int Id);
        OperationResult UpdataTestQuestions(int Id, TestQuestionsModel testQuestions);
        OperationResult<List<Tbl_TestQuestion>> SelectTestQuestions(string search = "");
    }
}
