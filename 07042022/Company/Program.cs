using System;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            Department department = new Department();

            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
            department.AddEmployee(employee4);
            department.AddEmployee(employee5);


            department.ChangeEmployeeNo(5,4);

            Console.WriteLine("employees ");
            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.No);
            }

        }
    }
}
