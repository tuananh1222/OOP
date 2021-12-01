using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_03
{
    internal class Employee : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal InCome { get; set; }
        public int TaxCoe { get; set; }

        public string Company { get; set; }
        public string JobTitle { get; set; }
        public Employee(int id, string name, int age, decimal income, string company, string jobtitle)
        {
            Id = id;
            Name = name;
            Age = age;
            InCome = income;
            Company = company;
            JobTitle = jobtitle;
            TaxCoe = TaxData.GetTaxCoe(Age, InCome);
        }
        public bool Equal()
        {
            if (Age > 18)
                return true;
            return false;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id {Id} || Name {Name} || Age {Age} || Income {InCome} || Tax {GetTax()} ||" +
                $"Company {Company} || JobTitile {JobTitle}");
        }
        public decimal GetTax()
        {
            return InCome * (decimal)((float)TaxCoe / 100);
        }
    }
}
