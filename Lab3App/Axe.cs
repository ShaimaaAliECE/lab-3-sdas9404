using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {

        public Axe(String Description) : base(Description) {
            
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed", this.Description);
        }

       

    }
}
