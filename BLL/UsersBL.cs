using DAL;
using DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBL : IUsers
    {
       Users Users ;
        public UsersBL() 
        {
            Users = new Users();
        }
        public OperationResult DeleteUsers(int Id)
        {
            throw new NotImplementedException();
        }

        public OperationResult InsertUsers(UserModel userModel)
        {
            if (userModel.Username!=""&& userModel.LastName != ""&&userModel.FirstName != "" && userModel.Permission != "" && userModel.Password != "" && userModel.PhoneNumber != "" &&userModel.lessionID != 0 )
            {
               var result = Users.InsertUsers(userModel);
               return result;
            }
            return null;
        }

        public OperationResult<List<Tbl_User>> SelectUsers(string searchFirstName = "", string searchLastName = "")
        {
            var result = Users.SelectUsers(searchFirstName, searchLastName);
            return result;
        }

        public OperationResult UpdataUsers(int Id, UserModel userModel)
        {
            throw new NotImplementedException();
        }
        public OperationResult<List<Tbl_User>> SelectUsersbyUsernameAndPassword(string username, string password)
        {
            Users user = new Users();
            OperationResult<List<Tbl_User>> result = new OperationResult<List<Tbl_User>>();
            if (username != "" && password != "")
            {
               result = user.SelectUsersbyUsernameAndPassword(username, password);

               
            }
            else
            {
                 result.Message = "لطفا تمام مقادیر را پر کنید";

            }
            return result;
        }
    }
}
