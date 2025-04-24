using System;
using System.Collections.Generic;
namespace Task_5
{
    public class Task_5
    {

        public void main4_2()
        {
            List<(string LastName, string FirstName, string Patronymic, string Position, int BirthYear, decimal Salary)> employees = new()
            {
            ("Уванов", "Петро", "Олегович", "Менеджер", 1990, 20000),
            ("Шевченко", "Олена", "Іванівна", "Бухгалтер", 1985, 18000),
            ("Коваленко", "Андрій", "Сергійович", "Програміст", 1995, 25000)
            };

            Console.Write("Введіть прізвище для видалення: ");
            string deleteLastName = Console.ReadLine()!;
            employees.RemoveAll(e => e.LastName == deleteLastName);

            Console.Write("Введіть номер елемента, після якого додати нового: ");
            int index = int.Parse(Console.ReadLine()!);

            var newEmp = ("Новий", "Юрій", "Миколайович", "Тестувальник", 1998, 15000m);

            if (index >= 0 && index < employees.Count)
                employees.Insert(index + 1, newEmp);

            Console.WriteLine("\nОновлений список:");
            foreach (var e in employees)
                Console.WriteLine($"{e.LastName} {e.FirstName} {e.Patronymic}, {e.Position}, {e.BirthYear}, {e.Salary} грн");
        }
    }

}
