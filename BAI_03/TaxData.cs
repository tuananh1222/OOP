using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_03
{
    internal class TaxData
    {
        public List<IPerson> persons { get; set; }

        public static TaxData Instance { get; set; }
        public TaxData()
        {
            persons = new List<IPerson>();
        }

        public static TaxData Init()
        {
           if(Instance == null)
            {
                Instance = new TaxData();
            }
           return Instance;
        }
        public static int GetTaxCoe(int age, decimal income)
        {
            if(age < 18)
            {
                return 0;
            }
            else {            
                
                if (9000000 < income && income <= 15000000) { return 10; }
                else if (15000000 < income && income <= 20000000) { return 20; }
                else if (20000000 < income && income <= 30000000)  return 30; 
            }
            return 5; 
            
        }
    }
}
