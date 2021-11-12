using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class Checking
    {
        private static Checking instance;

        internal static Checking Instance
        {
            get { if (instance == null) instance = new Checking(); return instance; }
            private set { instance = value; }
        }

        private Checking() { }


        public string CheckEmail(string _email)
        {
            string[] tmp = _email.Split('@');
            if (tmp.Count() == 1)
                return "Example@gmail.com";
            else
            {
                string[] tmp2 = tmp[1].Split('.');
                if (tmp.Count() == 1)
                    return "Example@gmail.com";
                else
                    return _email;
            }
        }

        public string CheckBirth(string _birth)
        {
            if (_birth == "")
                return "1900";
            else if (double.Parse(_birth) < 1900 || double.Parse(_birth) > DateTime.Now.Year)
                return "1900";
            else
                return _birth;
        }

        public DateTime CheckDate(string Date)
        {
            string[] tmp = Date.Split('/');
            if (tmp.Count() < 3)
                return DateTime.Now;
            else
            {
                int Day = Int32.Parse(tmp[0]);
                int Month = Int32.Parse(tmp[1]);
                int Year = Int32.Parse(tmp[2]);

                return new DateTime(Year, Month, Day);
            }
        }
    }
}
