using static DL.SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace PointsBusinessLogic
{
    [Serializable]
    public class User
    {
        public User()
        {

        }
        public User(string userid, string name)
        {
            this.userid = userid;
            this.name = name;
        }
        
        public string userid { get; private set; }

        private string name;

        public UserRole UserRole { get; set; }

        public bool Login()
        {
            var userRole = SqlData.ValidateUser(this.userid, this.name);
            if (!string.IsNullOrEmpty(userRole))
            {
                this.UserRole = (UserRole)Enum.Parse(typeof(UserRole), userRole);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    

    [Serializable]
    public enum UserRole
    {
        Courier,
        Admin
    }
}