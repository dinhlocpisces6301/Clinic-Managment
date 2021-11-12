using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public List<T> mergeSort<T>(List<T> P, bool desc = false) where T : Account
        {
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            List<T> result;

            if (P.Count <= 1)
                return P;

            int middlePoint = P.Count / 2;
            for (int i = 0; i < middlePoint; i++)
                left.Add(P[i]); ;

            for (int i = middlePoint; i < P.Count; i++)
                right.Add(P[i]);

            left = mergeSort(left, desc);
            right = mergeSort(right, desc);

            result = merge(left, right, desc);
            return result;
        }

        List<T> merge<T>(List<T> left, List<T> right, bool desc = false) where T : Account
        {
            int resultlength = left.Count + right.Count;
            List<T> result = new List<T>();
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            if (!desc)
            {
                while (indexLeft < left.Count || indexRight < right.Count)
                {
                    if (indexLeft < left.Count && indexRight < right.Count)
                    {
                        if (left[indexLeft] <= right[indexRight])
                        {
                            result.Add(left[indexLeft]);
                            indexLeft++;
                            indexResult++;
                        }
                        else
                        {
                            result.Add(right[indexRight]);
                            indexRight++;
                            indexResult++;
                        }
                    }
                    else if (indexLeft < left.Count)
                    {
                        result.Add(left[indexLeft]);
                        indexLeft++;
                        indexResult++;
                    }
                    else if (indexRight < right.Count)
                    {
                        result.Add(right[indexRight]);
                        indexRight++;
                        indexResult++;
                    }
                }
            }
            else
            {
                while (indexLeft < left.Count || indexRight < right.Count)
                {
                    if (indexLeft < left.Count && indexRight < right.Count)
                    {
                        if (left[indexLeft] >= right[indexRight])
                        {
                            result.Add(left[indexLeft]);
                            indexLeft++;
                            indexResult++;
                        }
                        else
                        {
                            result.Add(right[indexRight]);
                            indexRight++;
                            indexResult++;
                        }
                    }
                    else if (indexLeft < left.Count)
                    {
                        result.Add(left[indexLeft]);
                        indexLeft++;
                        indexResult++;
                    }
                    else if (indexRight < right.Count)
                    {
                        result.Add(right[indexRight]);
                        indexRight++;
                        indexResult++;
                    }
                }
            }
            return result;
        }

        public int binarySearch<T>(List<T> arr, int l, int r, T x) where T : Account
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch<T>(arr, l, mid - 1, x);

                return binarySearch<T>(arr, mid + 1, r, x);
            }
            return -1;
        }

        public List<Account> GetAccountList()
        {
            List<Account> accountList = new List<Account>();
            string query = "USP_GetAccountList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accountList.Add(account);
            }

            return accountList;
        }

        public bool ChangePassword(string userName, string passWord)
        {
            string query = "USP_ChangePassword @userName , @passWord";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] {userName, passWord });

            return data > 0;        
        }

        public bool CreateAccount(string userName, string passWord, string fullName, string phone, string email)
        {
            string query = "USP_CreateAccount @userName , @passWord , @fullName , @phone , @email";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, passWord, fullName, phone, email });

            return data > 0;
        }

        public string GetPassword(string userName)
        {
            string query = "USP_GetPassword @userName";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            Account account = new Account(data.Rows[0]);

            return account.passWord;
        }
    }
}
