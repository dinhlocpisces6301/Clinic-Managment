using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace BCCK_N6
{
    public class MD5Hashing
    {
        private static MD5Hashing instance;

        public static MD5Hashing Instance
        {
            get { if (instance == null) instance = new MD5Hashing(); return instance; }
            private set { instance = value; }
        }

        private MD5Hashing() { }

        public string GetMD5(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {

                // Chuyển chuỗi đầu vào thành mảng và băm
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));   //1 đơn vị thời gian

                // Tạo một StringBuilder mới để thu thập các Bytes
                // Và Tạo một chuỗi mới
                StringBuilder sBuilder = new StringBuilder(); // 1 đơn vị thời gian

                // Lặp lại từng byte dữ liệu được băm
                // và định dạng từng cái dưới dạng chuỗi thập lục phân

                for (int i = 0; i < data.Length; i++)   // n+1 đơn vị thời gian
                {
                    sBuilder.Append(data[i].ToString("x2"));// 1 đơn vị thời gian
                }

                // Trả về chuỗi thập lục phân
                return sBuilder.ToString();
            }
        }
    }
}
