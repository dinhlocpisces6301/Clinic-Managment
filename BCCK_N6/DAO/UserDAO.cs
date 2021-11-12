using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance 
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }

        public UserDAO() { }

        public List<T> mergeSort<T>(List<T> P, bool desc = false) where T : User
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

        List<T> merge<T>(List<T> left, List<T> right, bool desc = false) where T : User
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

        public User GetUserInfo(string userName)
        {
            string query = "USP_GetUserInfo @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });

            if (data.Rows.Count > 0)
            {
                User user = new User(data.Rows[0]);
                return user;
            }
            return null;
        }

        public List<User> GetUserList()
        {
            List<User> userList = new List<User>();
            string query = "USP_GetUserList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                userList.Add(user);
            }
            return userList;
        }

        public bool UpdateInfo(string userName, string fullName, string birth, string address, string phone, string email)
        {
            string query = "USP_UpdateInfo @userName , @fullName , @birth , @address , @phone , @email";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, fullName, birth, address, phone, email });
            return data > 0;
        }

        public User CheckAccount(string check, int type = 0)
        {
            string query = "USP_CheckAccount @check , @type";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { check, type });
            User user = new User(data.Rows[0]);
            return user;
        }

        public bool ExistsEmail(string email)
        {
            string query = "USP_ExistEmail @email";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object [] { email});
            return data.Rows.Count > 0;
        }

        public bool ExistsPhone(string phone)
        {
            string query = "USP_ExistPhone @phone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });
            return data.Rows.Count > 0;
        }

        public bool ExistsUsername(string userName)
        {
            string query = "USP_ExistUsername @userName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            return data.Rows.Count > 0;
        }

        public void ReplaceAtmpValues(string userName)
        {
            string query = "USP_ReplaceAtmpValues @userName ";
            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName} );
        }
    }
}
