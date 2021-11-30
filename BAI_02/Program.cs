using BAI_02;
using System;
using System.Collections.Generic;
namespace Example1
{
    public class Program
    {
        static List<Person> person = null;

        
        public static void Init()
        {
            person = new List<Person>();

            person.Add(new Person(1, "Le Tuan Anh",  21, 31000000));
            person.Add(new Person ( 2, "Duong Tuan Anh",  21, 9000000));
            person.Add(new Person ( 3,  "Nguyen Tien Anh",  21, 9000000));
            person.Add(new Person(4, "Nguyen Bao Trung", 22, 200000000));
            person.Add(new Person(5, "Man Van Truong", 21, 9000000));
            person.Add(new Person(6, "Le Thi Linh", 15, 23000000));
            person.Add(new Person(7, "Nguyen Thu Hoa", 18, 9000000));

        }
        public static void Output()
        {
            foreach (var p in person)
            {
                Console.WriteLine($"Id: {p.Id} || Name: {p.Name} || Tax: {p.GetTax()}");
            }
        }
        static void Main(string[] args)
        {
            Init();
            Output();

            Console.ReadKey();
        }
    }
}
