using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAI_02;
namespace BAI_02
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public decimal InCome { get; set; }
        public int TaxCoe { get; set; }

        public Person(int id, string name, int age, decimal income)
        {
            Id = id;
            Name = name;
            Age = age;
            InCome = income;
            TaxCoe = TaxData.GetTaxCoe(Age, InCome);
        }
        public bool Equals(Person p)
        {
            if(!(Id == p.Id && Name == p.Name && Age == p.Age && InCome == p.InCome && TaxCoe == p.TaxCoe))
            {
                return false;
            }
            return true;
        }
        public decimal GetTax()
        {
            return InCome*(decimal)((float) TaxCoe/100);
        }
    }
}
