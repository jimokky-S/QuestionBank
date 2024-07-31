using System;
using DAL;
using DAL.IRepository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TestQuestionBL : ITestQuestions
    {
        OperationResult result;
        TestQuestions TestQuestions;
        public TestQuestionBL() 
        {
            result = new OperationResult();
            TestQuestions = new TestQuestions();

        }
        public OperationResult DeleteTestQuestions(int Id)
        {
            result = TestQuestions.DeleteTestQuestions(Id);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }

            else
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult InsertTestQuestions(TestQuestionsModel testQuestions)
        {
            result = TestQuestions.InsertTestQuestions(testQuestions);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestions(string search = "")
        {
            var result = TestQuestions.SelectTestQuestions(search);
            if (result.Success) 
            {
                result.Message = "موفقیت آمیز بود";
            }
            else 
            {
                result.Message = "موفقیت آمیز نبود";
                    
            }
            return result;
        }
        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestionsByIDQuestionDetails(int IDQuestionDetails)
        {



            if (IDQuestionDetails > 0)
            {
                var result = TestQuestions.SelectTestQuestionsByIDQuestionDetails(IDQuestionDetails);


                if (result.Success)
                {
                    result.Message = "موفقیت آمیز بود";
                }
                else
                {
                    result.Message = "موفقیت آمیز نبود";

                }

                return result;
            }
            else { return null; }
        }
        public OperationResult UpdataTestQuestions(int Id, TestQuestionsModel testQuestions)
        {

            result = TestQuestions.UpdataTestQuestions(Id,testQuestions);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else 
            {
                result.Message = "موفقیت آمیز نبود";
            }
            
            return result;
        }

        public OperationResult<List<Tbl_TestQuestion>> SelectTestQuestionByQuestionDetailID(int QuestionDetailID)
        {
            if (QuestionDetailID > 0)
            {
                var result = TestQuestions.SelectTestQuestionByQuestionDetailID(QuestionDetailID);
                return result;
            }
            else { return null; }
        }
        
    }
}
