using BCCK_N6.DAO;
using BCCK_N6.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCCK_N6
{
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static List<Revenue> revenueList = new List<Revenue>();
        public void GetRevenueList()
        {
            revenueList = RevenueDAO.Instance.GetRevenueList();
        }

        public bool AddRevenue(string Date, double Deal)
        {
            return RevenueDAO.Instance.AddDeal(Date, Deal);
        }

        public List<Revenue> OrderByDate(string Date)
        {
            return RevenueDAO.Instance.OrderbyDate(Date);
        }

        public void AddItemToListview(List<Revenue> revenues)
        {
            listView1.Items.Clear();
            foreach (Revenue revenue in revenues)
            {
                ListViewItem item = new ListViewItem();
                item.Text = revenue.Date;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = revenue.Deal.ToString() });
                listView1.Items.Add(item);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetRevenueList();
            AddItemToListview(revenueList);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text;
            List<Revenue> tmp = OrderByDate(date);
            AddItemToListview(tmp);
        }
    }
}
