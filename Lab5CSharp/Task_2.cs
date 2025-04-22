using System;
using System.Security.Cryptography;
namespace Task_2
{
    public class Task_2
    {
        class Person
        {
            public string name = string.Empty, surname = string.Empty;
            public uint age;
            public Person(string name1)
            {
                name = name1;
                Console.WriteLine("Створено персону: " + name1);
            }

            public Person(string name1, string surname1)
            {
                name = name1;
                surname = surname1;
                Console.WriteLine("Створено персону: " + name1 + surname1);
            }

            public Person(string name1, string surname1, uint age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                Console.WriteLine("Створено персону: " + name1 + surname1);
            }

            ~Person()
            {
                Console.WriteLine("Об'єкт видалено");
            }

            public string Show()
            {
                return $"Ім'я: {name} Прізвище: {surname} Вік: {age}";
            }
        }

        class Employee : Person
        {
            public float salary;
            public uint termOfService;
            public int phoneNumber;

            public Employee(string name1, string surname1, uint age1, float salary1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                Console.WriteLine("Створено службовця");
            }

            public Employee(string name1, string surname1, uint age1, float salary1, uint termOfService1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                termOfService = termOfService1;
                Console.WriteLine("Створено службовця");
            }

            public Employee(string name1, string surname1, uint age1, float salary1, uint termOfService1, int phoneNumber1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                termOfService = termOfService1;
                phoneNumber = phoneNumber1;
                Console.WriteLine("Створено службовця");
            }

            ~Employee()
            {
                Console.WriteLine("Об'єкт видалено");
            }

            new public string Show()
            {
                return $"Ім'я: {name} Прізвище: {surname} Вік: {age} Зарплата: {salary}";
            }
        }

        class Worker : Person
        {
            public float salary;
            public string typeOfWork = string.Empty;
            public int phoneNumber;

            public Worker(string name1, string surname1, uint age1, float salary1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                Console.WriteLine("Створено робітника");
            }

            public Worker(string name1, string surname1, uint age1, float salary1, string typeOfWork1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                typeOfWork = typeOfWork1;
                Console.WriteLine("Створено робітника");
            }

            public Worker(string name1, string surname1, uint age1, float salary1, string typeOfWork1, int phoneNumber1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                typeOfWork = typeOfWork1;
                phoneNumber = phoneNumber1;
                Console.WriteLine("Створено робітника");
            }
            ~Worker()
            {
                Console.WriteLine("Об'єкт видалено");
            }

            new public string Show()
            {
                return $"Ім'я: {name} \nПрізвище: {surname} \nВік: {age} \nПрофесія: {typeOfWork}";
            }
        }

        class Engineer : Person
        {
            public float salary;
            public float experience;
            public int phoneNumber;

            public Engineer(string name1, string surname1, uint age1, float salary1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                Console.WriteLine("Створено інженера");
            }
            public Engineer(string name1, string surname1, uint age1, float salary1, uint experience1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                experience = experience1;
                Console.WriteLine("Створено інженера");
            }

            public Engineer(string name1, string surname1, uint age1, float salary1, uint experience1, int phoneNumber1) : base(name1, surname1, age1)
            {
                name = name1;
                surname = surname1;
                age = age1;
                salary = salary1;
                experience = experience1;
                phoneNumber = phoneNumber1;
                Console.WriteLine("Створено інженера");
            }

            ~Engineer()
            {
                Console.WriteLine("Об'єкт видалено");
            }

            new public string Show()
            {
                return $"Ім'я: {name} \nПрізвище: {surname} \nВік: {age} \nДосвід: {experience}";
            }
        }

        public void main2()
        {
            Person person1 = new Person("Антон");
            Console.WriteLine(person1.Show());

            Person person2 = new Person("Антон", "Берегій");
            Console.WriteLine(person2.Show());

            Person person3 = new Person("Антон", "Берегій", 19);
            Console.WriteLine(person3.Show());

            Employee employee1 = new Employee("Богдан", "Богданенко", 19, 10000);
            Console.WriteLine(employee1.Show());

            Employee employee2 = new Employee("Богдан", "Богданенко", 19, 10000, 5);
            Console.WriteLine(employee2.Show());

            Employee employee3 = new Employee("Богдан", "Богданенко", 19, 10000, 5, 1234556789);
            Console.WriteLine(employee3.Show());

            Worker worker1 = new Worker("Василь", "Василенко", 30, 20000);
            Console.WriteLine(worker1.Show());

            Worker worker2 = new Worker("Василь", "Василенко", 30, 20000, "Сантехнік");
            Console.WriteLine(worker2.Show());

            Worker worker3 = new Worker("Василь", "Василенко", 30, 20000, "Сантехнік", 786545468);
            Console.WriteLine(worker3.Show());

            Engineer engineer1 = new Engineer("хз хто", "хз хто", 30, 30000);
            Console.WriteLine(engineer1.Show());

            Engineer engineer2 = new Engineer("хз хто", "хз хто", 30, 30000, 10);
            Console.WriteLine(engineer2.Show());

            Engineer engineer3 = new Engineer("хз хто", "хз хто", 30, 30000, 10, 444444444);
            Console.WriteLine(engineer3.Show());
        }
    }
}