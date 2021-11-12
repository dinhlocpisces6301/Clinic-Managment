using BCCK_N6.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6
{
    public class Patient
    {   
        public int ID { get; set; }
        public string fullName { get; set; }
        public string birth { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string date { get; set; }
        public string diagnose { get; set; }
        public string medicine { get; set; }

        public Patient(DataRow row)
        {
            this.ID = Int32.Parse(row["ID"].ToString());
            this.fullName = row["Fullname"].ToString();
            this.birth = Checking.Instance.CheckBirth(row["Birth"].ToString());
            this.address = row["Address"].ToString();
            this.phone = row["Phone"].ToString();
            this.date = row["DateExam"].ToString();
            this.diagnose = row["Diagnose"].ToString();
            this.medicine = row["Medicine"].ToString();
        }

        public Patient(int _id = 1, string _fullname = "", string _birth = "", string _address = "", string _phone = "", string _date = "", string _diagnose = "", string _medicine = "")
        {
            this.ID = _id;
            this.fullName = _fullname;
            this.birth = Checking.Instance.CheckBirth(_birth);
            this.address = _address;
            this.phone = _phone;
            this.date = _date;
            this.diagnose = _diagnose;
            this.medicine = _medicine;
        }

        public override string ToString()
        {
            return string.Format("STT: " + ID.ToString() + "Ngày khám: " + date + "\nHọ Tên: " + fullName + "  \nNăm Sinh: " + birth + "  \nĐịa Chỉ: " + address + "  \nSố Điện Thoại: " + phone + "  \nChẩn Đoán: " + diagnose + "  \nĐơn Thuốc: " + medicine);
        }

        public string GetName()
        {
            string name = this.fullName;
            for (int i = this.fullName.Length - 1; i >= 0; i--)
            {
                if (fullName[i] == ' ')
                {
                    name = this.fullName.Substring(i + 1);
                    break;
                }
            }
            return name;
        }

        public static bool operator >(Patient a, Patient b)
        {
            return String.Compare(a.GetName(), b.GetName(), false) > 0;
        }
        public static bool operator <(Patient a, Patient b)
        {
            return String.Compare(a.GetName(), b.GetName(), false) < 0;
        }
        public static bool operator ==(Patient a, Patient b)
        {
            return String.Equals(a.GetName(), b.GetName());
        }
        public static bool operator !=(Patient a, Patient b)
        {
            return !String.Equals(a.GetName(), b.GetName());
        }
        public static bool operator <=(Patient a, Patient b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(Patient a, Patient b)
        {
            return a > b || a == b;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
