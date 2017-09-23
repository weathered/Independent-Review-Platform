using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Rev.Entity;

namespace Rev.DAL
{
    class Login
    {
        DataAccess db = new DataAccess();
        public int GetPrivilege(User userAttempt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select privilage from user where name='" + userAttempt.Name + "' and password='" + userAttempt.Password + "'";

            int result = (int)db.ScalarQuery(cmd);
            return result;
        }
    }
}
