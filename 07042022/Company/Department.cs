using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            if(GetEmployeeNo(employee.No) == null)
                Employees.Add(employee);
        }

        public Employee GetEmployeeNo(int no)
        {
            foreach (var item in Employees)
            {
                if (item.No == no)
                    return item;
            }

            return null;
        }


        public void RemoveemployeeByNo(int no)
        {
            Employee employee = GetEmployeeNo(no);

            if(employee != null)
            {
                Employees.Remove(employee);
            }
        }

        public void ChangeEmployeeNo(int oldNo,int newNo)
        {
            Employee employee = GetEmployeeNo(oldNo);

            if (employee != null && GetEmployeeNo(newNo) == null)
                employee.No = newNo;
        }


    }
}
