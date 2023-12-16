using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day_2
{
    public class Employee
    {
        #region Create Variables
        string _Name;
        string _Adderss;
        int _NID;
        int _Salary;
        public string _Tittle;
        static string _DepartmentName;
        static int Count;
        #endregion

        #region Default Constructor
        public Employee()
        {
            _Name = "N/A";
            _Adderss = "Minia";
            _NID = 1;
            _Salary = 4000;
            _Tittle = "Iti student";
            _DepartmentName = "“.Net Department";
            Count++;

        }

        public Employee(string name, string address, int Nid, int salary, string tittle)
        {
            if (name.Length > 2)
            {
                _Name = name;
            }
            else
            {
                _Name = "N/A";
            }
            if (address != null)
            {
                _Adderss = address;
            }
            else
            {
                _Adderss = "Minia";
            }
            if (Nid != 0)
            {
                _NID = Nid;
            }
            else
            {
                _NID = 1;
            }
            if (salary != 0 && salary > 3000)
            {
                _Salary = salary;
            }
            else
            {
                _Salary = 4000;
            }
            if (tittle.Length > 2)
            {
                _Tittle = tittle;
            }
            else
            {
                _Tittle = "Iti student";
            }
            _DepartmentName = "“.Net Department";
            Count++;


        }
        public Employee(string name, string address, int Nid, int salary ) : this(name,address,Nid,salary, "Iti student")
        {

        }
        #endregion

        #region function get and set
        public int Sallary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        #endregion

        #region Static Constructor
        static Employee()
        {
            _DepartmentName=  ".Net Department";
             Count = 0;
        }
        #endregion

        #region Function Display 
        public void Display()
        {
            Console.WriteLine($"Name:{_Name}\n Address : {_Adderss}\n Nid:{_NID}\n Salary:{_Salary}\n Tittle:{_Tittle}");
        }
        public static void DisplayCount()
        {
            Console.WriteLine(Count);
        }
        #endregion
    }
}
