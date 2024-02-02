using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {

        public MagicWand(String Description) : base(Description) {
            
        }
        public override void  Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed", this.Description);
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWant is Used");
        }



    }
}
