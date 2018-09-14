using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>(); 
            var listOfEmployees = new List<Employees>
            {
                new Employees { EmployeeID=1150, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees { EmployeeID=1151, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees { EmployeeID=1152, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees { EmployeeID=1153, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees { EmployeeID=1154, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees { EmployeeID=1155, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees { EmployeeID=1156, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees { EmployeeID=1157, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees { EmployeeID=1158, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees { EmployeeID=1159, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees { EmployeeID=1160, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees { EmployeeID=1161, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
            };

            Employees.DisplayWithApparisal(listOfEmployees,"All Employees");

            #region LINQ syntax

            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = listOfEmployees.Where(e=>e.Salary>=6000 && e.Age>40).ToList();
            // Query syntax
            filteredList = (from emp in listOfEmployees
                           where emp.Salary >= 6000 && emp.Age > 40
                           select emp).ToList();


            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = listOfEmployees.Where(e=>e.Salary>= 6000 && e.Age> 40 || e.Salary>=8000).ToList();
            // Query syntax
            filteredList = (from emp in listOfEmployees
                           where emp.Salary >= 6000 && emp.Age > 40 || emp.Salary >= 8000
                           select emp).ToList();


            // salery over 4000 and appraisal less than 8 - Use the displaywithappraisal method

            filteredList = listOfEmployees.Where(e=> e.Salary> 4000 && e.Appraisal.Last() < 8).ToList();
            // Query syntax
            filteredList = (from emp in listOfEmployees
                            where emp.Salary > 4000 && emp.Appraisal.Last() > 8
                            select emp).ToList();

            Employees.DisplayWithApparisal(filteredList, "Salery over 4000 and appraisal less than 8");

            //foreach (var employee in listOfEmployees)
            //{
            //    if (employee.Salary >= 6000 && employee.Age >= 40)
            //        Console.WriteLine(employee.FirstName);
            //}

            foreach (var emp in filteredList)
            {
                Console.WriteLine(emp.FirstName);
            }
            #endregion

            #region Sorting Data With LINQ
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Sorting data with LINQ");

            filteredList = listOfEmployees.OrderByDescending(e => e.Salary).ToList(); // .OrderBy is ascending .OrderByDescending is descending
            // Seems the query syntax can go further in the query
            filteredList = (from emp in listOfEmployees
                            orderby emp.Salary descending, emp.Age descending
                            select emp).ToList();

            Employees.DisplayWithApparisal(filteredList, "Sorting Employees by salary descending: ");

            #endregion

            #region LINQ with Methods
            Console.WriteLine("---------------------------------");
            Console.WriteLine("LINQ with Methods");

            Employees.DisplayWithApparisal(SortEmployees(listOfEmployees), "After Sorting");


            #endregion

            Console.WriteLine();
            Console.ReadLine();
        }
        public static List<Employees> SortEmployees(List<Employees> employees)
        {
            var list = from emp in employees
                       orderby emp.Age descending
                       select emp;
            return list.ToList();
        }
    }
}
