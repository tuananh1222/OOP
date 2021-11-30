using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_01
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public decimal InCome { get; set; }
        public int TaxCoe { get; set; }

        public bool Equal(Person p)
        {
            if( Id == p.Id && Age == p.Age && InCome == p.InCome && TaxCoe == p.TaxCoe)
            {
                return false;
            }
            return true;
        }
        public decimal GetTax()
        {
            return InCome*(decimal)((float)TaxCoe/100);
        }
    }
}
