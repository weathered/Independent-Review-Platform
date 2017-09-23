using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Rev.Entity;
using Rev.DAL.Login;

namespace Rev.DAL
{
    class SignUp
    {
        DataAccess db = new DataAccess();
        int checkPrivilege;
        public int Register(User user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user values ('" + user.Name + "','" + user.Password + "','" + 3 +"')";
            // 1=Admin, 2=Moderator, 3=User, 4=Guest
            return db.DMLQuery(cmd);
        }

        public int GrantPrivilege(User user, User admin)
        {
            Login check = new Login();
            checkPrivilege = check.GetPrivilege(admin);
            try
            {
                if (checkPrivilege == 1)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update user set privilege=2 where id='" + user.Id + "'";

                    return db.DMLQuery(cmd);
                }
                else
                {
                    //error message
                }
            }
            catch(SqlException ex)
            {
                //Error 
            }

            return -1;
        }
    }
}
