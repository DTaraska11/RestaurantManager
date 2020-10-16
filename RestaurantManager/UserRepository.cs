using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; 


namespace RestaurantManager
{
    class UserRepository: IUserRepository
    {
        public  async Task<bool> Insert(User user)
        {
            using (IDbConnection db = new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(RestaurantManager.Properties.Resources.InsertUser, new {FullName = user.FullName, Password = user.Password, Email = user.Email, UserType = user.UserType });
                return result > 0; 
            }

               

        }
    }
}
