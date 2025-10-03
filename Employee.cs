using System;

namespace HRSystem
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }

        public Employee(int id, string fullName, string position, DateTime hireDate)
        {
            Id = id;
            FullName = fullName;
            Position = position;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {Id}, ФИО: {FullName}, Должность: {Position}, Принят: {HireDate:yyyy-MM-dd}";
        }
    }
}