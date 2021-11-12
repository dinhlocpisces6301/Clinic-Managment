using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class MedicineDAO
    {
        private static MedicineDAO intance;

        public static MedicineDAO Intance 
        {
            get { if (intance == null) intance = new MedicineDAO();  return intance; }
            private set { intance = value; } 
        }

        private MedicineDAO() { }

        public List<T> mergeSort<T>(List<T> P, bool desc = false) where T : Medicine
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

        List<T> merge<T>(List<T> left, List<T> right, bool desc = false) where T : Medicine
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

        public List<Medicine> GetMedicineList()
        {
            string query = "USP_GetMedicineList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Medicine> medicines = new List<Medicine>();
            foreach  (DataRow item in data.Rows)
            {
                Medicine tmp = new Medicine(item);
                medicines.Add(tmp);
            }
            return medicines;
        }

        public bool UpdateMedicineInfo(string ID, string medicineName, string price, int number)
        {
            string query = "USP_UpdateMedicineInfo @ID , @medicineName , @price , @number";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, medicineName, price, number });

            return data > 0;
        }

        public bool DeleteMedicine(string ID)
        {
            string query = "USP_DeleteMedicine @ID";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });

            return data > 0;
        }

        public bool AddMedicine(string ID, string medicineName, string price, int number)
        {
            string query = "USP_AddMedicine @ID , @medicineName , @price , @number";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, medicineName, price, number });

            return data > 0;
        }
    }
}
