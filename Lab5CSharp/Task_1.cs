using System;
using System.Security.Cryptography;
namespace Task_1
{
    public class Task_1
    {
        class Person
        {
            public string name, surname;
            public uint age;

            public Person(string name1, string surname1, uint age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
            }

            public string Show()
            {
                return $"Ім'я: {name} Прізвище: {surname} Вік: {age}";
            }
        }

        class Employee : Person
        {
            public float salary;

            public Employee(string name1, string surname1, uint age1, float salary1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
            }

            new public string Show()
            {
                return $"Ім'я: {name} Прізвище: {surname} Вік: {age} Зарплата: {salary}";
            }
        }

        class Worker : Person
        {
            public string typeOfWork;

            public Worker(string name1, string surname1, uint age1, string typeOfWork1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                typeOfWork = typeOfWork1;
            }

            new public string Show()
            {
                return $"Ім'я: {name} \nПрізвище: {surname} \nВік: {age} \nПрофесія: {typeOfWork}";
            }
        }

class Engineer : Person
        {
            public float experience;

            public Engineer(string name1, string surname1, uint age1, uint experience1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                experience = experience1;
            }

            new public string Show()
            {
                return $"Ім'я: {name} \nПрізвище: {surname} \nВік: {age} \nДосвід: {experience}";
            }
        }

        public void main1()
        {
            Person person1 = new Person("Антон", "Берегій", 19);
            Console.WriteLine(person1.Show());

            Employee employee1 = new Employee("Богдан", "Богданенко", 19, 10000);
            Console.WriteLine(employee1.Show());

            Worker worker1 = new Worker("Василь", "Василенко", 30, "Сантехнік");
            Console.WriteLine(worker1.Show());

            Engineer engineer1 = new Engineer("хз хто", "хз хто", 30, 10);
            Console.WriteLine(engineer1.Show());
        }
    }
}