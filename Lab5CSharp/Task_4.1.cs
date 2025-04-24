using System;
using System.Collections.Generic;
namespace Task_4
{
    public class Task_4
    {
        struct Employee
        {
            public string LastName;
            public string FirstName;
            public string Patronymic;
            public string Position;
            public int BirthYear;
            public decimal Salary;

            public void Display()
            {
                Console.WriteLine($"{LastName} {FirstName} {Patronymic}, {Position}, {BirthYear}, {Salary} грн");
            }
        }


        public void main4_1()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { LastName = "Уванов", FirstName = "Петро", Patronymic = "Олегович", Position = "Менеджер", BirthYear = 1990, Salary = 20000 },
            new Employee { LastName = "Шевченко", FirstName = "Олена", Patronymic = "Іванівна", Position = "Бухгалтер", BirthYear = 1985, Salary = 18000 },
            new Employee { LastName = "Коваленко", FirstName = "Андрій", Patronymic = "Сергійович", Position = "Програміст", BirthYear = 1995, Salary = 25000 }
        };

            Console.Write("Введіть прізвище для видалення: ");
            string deleteLastName = Console.ReadLine()!;
            employees.RemoveAll(e => e.LastName == deleteLastName);

            Console.Write("Введіть номер елемента, після якого додати нового: ");
            int index = int.Parse(Console.ReadLine()!);

            var newEmp = new Employee
            {
                LastName = "Новий",
                FirstName = "Юрій",
                Patronymic = "Миколайович",
                Position = "Тестувальник",
                BirthYear = 1998,
                Salary = 15000
            };

            if (index >= 0 && index < employees.Count)
                employees.Insert(index + 1, newEmp);

            Console.WriteLine("\nОновлений список:");
            foreach (var emp in employees)
                emp.Display();
        }
    }
}