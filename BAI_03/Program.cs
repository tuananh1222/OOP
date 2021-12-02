using BAI_03;
using System;
using System.Linq;
using System.Collections.Generic;
using App;
namespace Example1
{
    public class Program
    {
        public static void Output()
        {
            Console.WriteLine("List Student");
            Console.WriteLine(TaxData.Init().persons.OfType<Student>().Count<Student>());            
            foreach(var student in TaxData.Init().persons.OfType<Student>())
            {
                student.GetInfo();
            }
            Console.WriteLine("====================================");
            Console.WriteLine("List Teacher");
            Console.WriteLine(TaxData.Init().persons.OfType<Teacher>().Count<Teacher>());
            foreach(var teacher in TaxData.Init().persons.OfType<Teacher>())
            {
                teacher.GetInfo();
            }
            Console.WriteLine("====================================");
            Console.WriteLine("List Employee");
            Console.WriteLine(TaxData.Init().persons.OfType<Employee>().Count<Employee>());
            foreach (var employee in TaxData.Init().persons.OfType<Employee>())
            {
                employee.GetInfo();
            }
        }
        static void Main(string[] args)
        {
            Application.Create();
            Output();

            Console.ReadKey();
        }
    }
}

