using BCCK_N6.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6
{
    public class User
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public string birth { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        
        public User(DataRow row)
        {
            this.userName = row["Username"].ToString();
            this.fullName = row["Fullname"].ToString();
            this.birth = Checking.Instance.CheckBirth(row["Birth"].ToString());
            this.address = row["Address"].ToString();
            this.phone = row["Phone"].ToString();
            this.email = row["Email"].ToString();
        }

        public User(string _username = "", string _fullname = "", string _birth = "1900", string _address = "", string _phone = "", string _email = "")
        {
            this.userName = _username;
            this.fullName = _fullname;
            this.address = _address;
            this.phone = _phone;
            this.birth = Checking.Instance.CheckBirth(_birth);
            this.email = _email;
        }

        public static bool operator >(User a, User b)
        {
            return String.Compare(a.fullName, b.fullName, false) > 0;
        }
        public static bool operator <(User a, User b)
        {
            return String.Compare(a.fullName, b.fullName, false) < 0;
        }
        public static bool operator ==(User a, User b)
        {
            return String.Equals(a.fullName, b.fullName);
        }
        public static bool operator !=(User a, User b)
        {
            return !String.Equals(a.fullName, b.fullName);
        }
        public static bool operator <=(User a, User b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(User a, User b)
        {
            return a > b || a == b;
        }
    }
}
