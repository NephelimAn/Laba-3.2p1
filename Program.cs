using System;

namespace HRSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var hr = HRDepartment.Instance;

            hr.AddEmployee(new Employee(1, "Иванов Иван Иванович", "Программист", new DateTime(2023, 3, 15)));
            hr.AddEmployee(new Employee(2, "Петрова Анна Сергеевна", "Менеджер", new DateTime(2022, 11, 1)));

            hr.DisplayAllEmployees();

            var emp = hr.FindEmployeeById(1);
            if (emp != null)
                Console.WriteLine($"\nНайден сотрудник: {emp.FullName}");

            Console.ReadKey();
        }
    }
}