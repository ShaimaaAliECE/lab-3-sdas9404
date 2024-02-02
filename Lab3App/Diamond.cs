using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {

        public Diamond(String Description, int score) : base(Description, score)  {
           
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond {Description} is displayed");

        }

    }
}
