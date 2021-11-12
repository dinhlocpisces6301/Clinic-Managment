using BCCK_N6.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class RevenueDAO
    {
        private static RevenueDAO instance;

        public static RevenueDAO Instance 
        {
            get { if (instance == null) instance = new RevenueDAO(); return instance; }
            private set { instance = value; }
        }

        private RevenueDAO() { }

        public List<Revenue> GetRevenueList()
        {
            string query = "USP_GetRevenueList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Revenue> revenueList = new List<Revenue>();

            foreach (DataRow row in data.Rows)
            {
                Revenue tmp = new Revenue(row);
                revenueList.Add(tmp);
            }
            return revenueList;
        }

        public bool AddDeal(string Date, double Deal)
        {
            string query = "USP_AddDeal @Date , @Deal";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {Date, Deal });

            return data > 0;
        }

        public List<Revenue> OrderbyDate(string Date)
        {
            string query = "USP_OrderbyDate @Date";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Date});

            List<Revenue> revenueList = new List<Revenue>();

            foreach (DataRow row in data.Rows)
            {
                Revenue tmp = new Revenue(row);
                revenueList.Add(tmp);
            }
            return revenueList;
        }
    }
}
