using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DTO
{
    public class Revenue
    {
        public string Date { get; set; }
        public double Deal { get; set; }

        public Revenue(string _Date, double _Deal = 0)
        {
            this.Date = _Date;
            this.Deal = _Deal;
        }

        public Revenue(DataRow row)
        {
            this.Date = row["Date"].ToString();
            this.Deal = Double.Parse(row["Deal"].ToString());
        }
    }
}
