using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface IUsers
    {
        OperationResult InsertUsers(UserModel userModel);
        OperationResult DeleteUsers(int Id);
        OperationResult UpdataUsers(int Id, UserModel userModel);
        OperationResult<List<Tbl_User>> SelectUsers(string searchFirstName = "", string searchLastName = "");
    }
}
