using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Алексей";
            person1.Age = 25;
            person1.DisplayInfo();

            Person person2 = new Person { Name = "Мария", Age = 30 };
            person2.DisplayInfo();

            Console.Write("Введите имя: ");
            string inputName = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int inputAge = int.Parse(Console.ReadLine());

            Person person3 = new Person(inputName, inputAge);
            person3.DisplayInfo();
            Console.ReadKey();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person()
            {
                Name = "Неизвестно";
                Age = 0;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
            }
        }
    }
}
