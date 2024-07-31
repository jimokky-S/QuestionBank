using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.QuestionBank
{
    public class LessionBL : ILessions
    {
        
        Lession lession;

        public LessionBL() 
        {
            lession = new Lession();
        }
        public OperationResult InsertLession(LessionModel lessionModel)
        {
            OperationResult result = new OperationResult();

            if (lessionModel.Name == "")
            {
                result.Message = "لطفا تمام مقادیر را پر کنید";
                return result;
            }
            if (lessionModel.Name.Length <= 2)
            {
                result.Message = "حروف کم";
                return result;
            }
            result = lession.InsertLession(lessionModel);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else if (!result.Success)
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult DeleteLession(int Id)
        {
            var result = lession.DeleteLession(Id);
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

        public OperationResult UpdataLession(int Id, LessionModel lessionModel)
        {
            OperationResult result = new OperationResult();

            if (lessionModel.Name != "")
            {
                result.Message = "لطفا تمتم مقادیر را پر کنید";
                return result;
            }
            if (lessionModel.Name.Length <= 2)
            {
                result.Message = "حروف کم است";
                return result;
            }
            result = lession.InsertLession(lessionModel);
            if (result.Success)
            {
                result.Message = "موفقیت آمیز بود";
            }
            else if (!result.Success)
            {
                result.Message = "موفقیت آمیز نبود";
            }
            return result;
        }

        public OperationResult<List<Tbl_Lession>> SelectLession(string search = "")
        {
            var result = lession.SelectLession(search);
            return result;
            
        }


    }
}
