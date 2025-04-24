using System;
using System.Collections.Generic;
namespace Task_6
{
    public class Task_6
    {
        public record Employee(string LastName, string FirstName, string Patronymic, string Position, int BirthYear, decimal Salary);

        public void main4_3()
        {
            List<Employee> employees = new()
        {
            new Employee("Уванов", "Петро", "Олегович", "Менеджер", 1990, 20000),
            new Employee("Шевченко", "Олена", "Іванівна", "Бухгалтер", 1985, 18000),
            new Employee("Коваленко", "Андрій", "Сергійович", "Програміст", 1995, 25000)
        };

            Console.Write("Введіть прізвище для видалення: ");
            string deleteLastName = Console.ReadLine()!;
            employees.RemoveAll(e => e.LastName == deleteLastName);

            Console.Write("Введіть номер елемента, після якого додати нового: ");
            int index = int.Parse(Console.ReadLine()!);

            var newEmp = new Employee("Новий", "Юрій", "Миколайович", "Тестувальник", 1998, 15000);

            if (index >= 0 && index < employees.Count)
                employees.Insert(index + 1, newEmp);

            Console.WriteLine("\nОновлений список:");
            foreach (var e in employees)
                Console.WriteLine($"{e.LastName} {e.FirstName} {e.Patronymic}, {e.Position}, {e.BirthYear}, {e.Salary} грн");
        }
    }
}
