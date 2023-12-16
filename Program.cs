using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Xml.Linq;
namespace OOP_Day_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Assignment
			//1-Design class that contain info(Name, Address, NID, Salary, Title, DepartmentName).
			//2-There is only one department which is “.Net Department”, choose the most appropriate type for this field.
			//3-Create all type of constructors needed.
			//4-Use Constructor Chaining.
			//5-Use Property to define class member if needed.
			//6-Try to set constrain in your Property in set and get  
			//7-Add static field “Count” to count number of objects created.
			//8-Add a member function called “DisplayCount” to display the total number of employees.
			//9-Call the function DisplayCount in main.
				//a.Can you call the function using object?
			//10-	Add a static constructor.
				//a.Can you call the static constructor?
				//b.What is the difference between instance constructor and static constructor?

	#endregion

			#region Lab
			Employee employee = new Employee();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee("Nader", "Bns", 2, 8000);
            employee2.Display();
            Employee.DisplayCount(); 
            #endregion
        }
    }
}