using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCK_N6.DAO
{
    class PatientDAO
    {
        private static PatientDAO instance;

        internal static PatientDAO Instance
        {
            get { if (instance == null) instance = new PatientDAO(); return instance; }
            private set { instance = value; }
        }

        private PatientDAO() { }

        public List<T> mergeSort<T>(List<T> P, bool desc = false) where T : Patient
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

        List<T> merge<T>(List<T> left, List<T> right, bool desc = false) where T : Patient
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

        public List<Patient> GetPatientList()
        {
            string query = "USP_GetPatientList";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<Patient> patientList = new List<Patient>();

            foreach (DataRow row in data.Rows)
            {
                Patient tmp = new Patient(row);
                patientList.Add(tmp);
            }
            return patientList;
        }

        public bool UpdatePatientInfo(int ID, string dataExam, string fullName, string birth, string address, string phone, string diagnose, string medicine)
        {
            string query = "USP_UpdatePatientInfo @ID , @dataExam , @fullName , @birth , @address , @phone , @diagnose , @medicine";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, dataExam, fullName, birth, address, phone, diagnose, medicine });

            return data > 0;
        }

        public bool AddPatient(int ID, string dataExam, string fullName, string birth, string address, string phone, string diagnose, string medicine)
        {
            string query = "USP_AddPatient @ID , @dataExam , @fullName , @birth , @address , @phone , @diagnose , @medicine";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, dataExam, fullName, birth, address, phone, diagnose, medicine });

            return data > 0;
        }

        public bool DeletePatient(int ID, string dateExam)
        {
            string query = "USP_DeletePatient @ID , @dateExam";

            int data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID, dateExam });

            return data > 0;
        }

        public int GetOrderOfExam(string dateExam)
        {
            string query = "USP_getOrderOfExam @dateExam";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { dateExam });
            if (data.Rows.Count == 0)
                return 1;
            else
            {
                Patient patient = new Patient(data.Rows[0]);
                int ID = patient.ID + 1;
                return ID;
            }
        }
    }
}
