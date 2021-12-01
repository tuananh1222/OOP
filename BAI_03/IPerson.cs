using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BAI_03
{
    internal interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public decimal InCome { get; set; }
        public int TaxCoe { get; set; }


        public bool Equal();
        public decimal GetTax();
        public void GetInfo();
    }
}
