using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure
    {
        private int value;

       public Coin(string Description, int score, int value) : base(Description, score)
        {
            this.value = value;
        }

        public void UpdateTotalValue()
        {
            Board.totalValue += this.value;
            Console.WriteLine("Total value is updated to: "+Board.totalValue);
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalValue();

        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
            
        }

       
    }
}
