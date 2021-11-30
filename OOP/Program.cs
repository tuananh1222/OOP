using Bai_01;
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

            person.Add(new Person { Id = 1, Name = "Le Tuan Anh", Age = 21, InCome = 2000, TaxCoe = 1 });
            person.Add(new Person { Id = 2, Name = "Duong Tuan Anh", Age = 21, InCome = 2000, TaxCoe = 1 });
            person.Add(new Person { Id = 3, Name = "Nguyen Tien Anh", Age = 21, InCome = 2000, TaxCoe = 1 });
            person.Add(new Person { Id = 4, Name = "Nguyen Bao Trung", Age = 29, InCome = 10000, TaxCoe = 1 });
            person.Add(new Person { Id = 5, Name = "Le Thi Linh", Age = 35, InCome = 2000, TaxCoe = 1 });
            person.Add(new Person { Id = 6, Name = "Nguyen Thu Hoa", Age = 17, InCome = 1000, TaxCoe = 1 });
            person.Add(new Person { Id = 7, Name = "Vu Tuan Anh", Age = 31, InCome = 13000, TaxCoe = 1 });
            
        }
        public  static void Output()
        {
            foreach(var p in person)
            {
                Console.WriteLine($"Id: {p.Id} || Name: {p.Name} || Tax: {p.TaxCoe}");
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
