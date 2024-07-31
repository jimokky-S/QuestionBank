using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Lession : ILessions
    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True;";
        OperationResult result;
        questionBankDataContext db;
        public Lession()
        {
            db = new questionBankDataContext(connectionString);
            result = new OperationResult();
            
        }
        public OperationResult InsertLession(LessionModel lessionModel)
        {
            try
            {
               Tbl_Lession lession = new Tbl_Lession();
                {
                    lession.Name = lessionModel.Name;
                }
                db.Tbl_Lessions.InsertOnSubmit(lession);
                db.SubmitChanges();
                result.Success = true;
                result.Success = true;
                return result;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }

        }
        public OperationResult DeleteLession(int Id) 
        {
            try
            {
                
                var del = db.Tbl_Lessions.Where(x => x.ID == Id).ToList().Single();
                db.Tbl_Lessions.DeleteOnSubmit(del);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
                return result;
            }
            catch (Exception ex) 
            {
                result.Message = ex.Message;
                result.Success = false;
                return result;
            }
            


        }
        public OperationResult UpdataLession(int Id, LessionModel lessions)
        {
            try
            {
                Tbl_Lession Lession = new Tbl_Lession();
                Lession = db.Tbl_Lessions.Where(x => x.ID == Id).Single();
                Lession = updata(lessions);
                db.SubmitChanges();
                result.Success = true;
                result.Message = String.Empty;
                return result;
            }
            catch (Exception ex)
            {
                result.Success=false;
                result.Message = ex.Message;
                return result;
               
            }
        }
        public OperationResult<List<Tbl_Lession>> SelectLession(string search = "")
        {
            OperationResult<List<Tbl_Lession>> Op = new OperationResult<List<Tbl_Lession>>();
            try
            {
                var selectData = db.Tbl_Lessions.Where(x => x.Name.Contains(search)).ToList();
                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectData;
                return Op;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
                return Op;
            }
        }

        private Tbl_Lession updata(LessionModel lessions)
        { 
            Tbl_Lession tbl_Lession = new Tbl_Lession();
            {
                tbl_Lession.Name = lessions.Name;
            }
            return tbl_Lession;
        }
    }
}
