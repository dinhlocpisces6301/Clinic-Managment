using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6
{
    public class Account
    {
        public string userName { get; set; }
        public string passWord { get; set; }
        public int typeAcc { get; set; }

        public Account(string _userName = "", string _passWord = "", int _typeAcc = 1)
        {
            this.userName = _userName;
            this.passWord = _passWord;
            this.typeAcc = _typeAcc;
        }

        public Account(DataRow row)
        {
            this.userName = row["Username"].ToString();
            this.passWord = row["Password"].ToString();
            this.typeAcc = (int)row["Type"];
        }

        public static bool operator >(Account a, Account b)
        {
            return String.Compare(a.userName, b.userName, false) > 0;
        }
        public static bool operator <(Account a, Account b)
        {
            return String.Compare(a.userName, b.userName, false) < 0;
        }
        public static bool operator ==(Account a, Account b)
        {
            return String.Equals(a.userName, b.userName);
        }
        public static bool operator !=(Account a, Account b)
        {
            return !String.Equals(a.userName, b.userName);
        }
        public static bool operator <=(Account a, Account b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(Account a, Account b)
        {
            return a > b || a == b;
        }
    }
}
