using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Users : IUsers
    {
        const string connectionString = "Data Source=.;Initial Catalog=db_QuestionBank;Integrated Security=True";

        OperationResult result;
        questionBankDataContext db;
        public Users() 
        {
            result = new OperationResult();
            db = new questionBankDataContext(connectionString); 
        }
        public OperationResult DeleteUsers(int Id)
        {
            try
            {
                var del = db.Tbl_Users.Where(x => x.ID == Id).Single();
                db.Tbl_Users.DeleteOnSubmit(del);
                db.SubmitChanges();
                result.Success = true;
                result.Message = string.Empty;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.Success = false;
            }
            return result;
        }

        public OperationResult InsertUsers(UserModel userModel)
        {
            try
            {
                Tbl_User User = new Tbl_User();
                User = updata(userModel);
                db.Tbl_Users.InsertOnSubmit(User);
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

        public OperationResult<List<Tbl_User>> SelectUsers(string searchFirstName = "", string searchLastName = "")
        {
            OperationResult<List<Tbl_User>> Op = new OperationResult<List<Tbl_User>>();
            try
            {
                var selectData = db.Tbl_Users.Where(x => x.Firstname.Contains(searchFirstName)|| x.Lastname.Contains(searchLastName)).ToList();

                Op.Success = true;
                Op.Message = string.Empty;
                Op.Data = selectData;
            }
            catch (Exception ex)
            {
                Op.Success = false;
                Op.Message = ex.Message;
            }
            return Op;
        }


        public OperationResult<List<Tbl_User>> SelectUsersbyUsernameAndPassword(string username, string password)
        {
            OperationResult<List<Tbl_User>> result = new OperationResult<List<Tbl_User>>(); 
            try
                {
                var data = db.Tbl_Users.Where(x => x.Username == username && x.Password == password).ToList();
                if (data.Count!=0)
                {
                    result.Success = true;
                    result.Data = data;
                    result.Message = string.Empty;
                }
               
               
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;

            }
            return result;
        }

        public OperationResult UpdataUsers(int Id, UserModel userModel)
        {
            throw new NotImplementedException();
        }
        private Tbl_User updata(UserModel userModel) 
        {
            Tbl_User tbl_User = new Tbl_User()
            {
                Username = userModel.Username,
                Password = userModel.Password,
                Firstname = userModel.FirstName,
                Lastname = userModel.LastName,
                PhoneNumber = userModel.PhoneNumber,
                Permission = userModel.Permission,
                LessionId = userModel.lessionID 

            };
            return tbl_User;
        }
    }
}
