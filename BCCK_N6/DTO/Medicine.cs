using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6
{
    public class Medicine
    {
        public string ID { get; set; }
        public string medicineName { get; set; }
        public string price { get; set; }
        public string number { get; set; }

        public Medicine(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.medicineName = row["MedicineName"].ToString();
            this.price = row["Price"].ToString();
            this.number = row["Number"].ToString();
        }

        public Medicine(string _ID = "", string _name = "", string _price = "0", string _number = "0")
        {
            this.ID = _ID;
            this.medicineName = _name;
            this.price = _price;
            this.number = _number;
        }

        public static bool operator >(Medicine a, Medicine b)
        {
            return String.Compare(a.ID, b.ID, false) > 0;
        }
        public static bool operator <(Medicine a, Medicine b)
        {
            return String.Compare(a.ID, b.ID, false) < 0;
        }
        public static bool operator ==(Medicine a, Medicine b)
        {
            return String.Equals(a.ID, b.ID);
        }
        public static bool operator !=(Medicine a, Medicine b)
        {
            return !String.Equals(a.ID, b.ID);
        }
        public static bool operator <=(Medicine a, Medicine b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(Medicine a, Medicine b)
        {
            return a > b || a == b;
        }
    }
}
