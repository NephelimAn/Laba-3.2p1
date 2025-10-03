using System;
using System.Collections.Generic;

namespace HRSystem
{
    public sealed class HRDepartment : Employee
    {
        private static readonly HRDepartment _instance = new HRDepartment();

        private HRDepartment()
        {
            Employees = new List<Employee>();
        }

        public static HRDepartment Instance => _instance;

        public List<Employee> Employees { get; private set; }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            Employees.Add(employee);
            Console.WriteLine($"Сотрудник {employee.FullName} добавлен в отдел кадров.");
        }

        public Employee FindEmployeeById(int id)
        {
            return Employees.Find(e => e.Id == id);
        }

        public void DisplayAllEmployees()
        {
            if (Employees.Count == 0)
            {
                Console.WriteLine("В отделе кадров пока нет сотрудников.");
                return;
            }

            Console.WriteLine("Список сотрудников:");
            foreach (var emp in Employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}