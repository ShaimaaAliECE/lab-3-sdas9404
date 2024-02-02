using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {

        private int score;

        public Treasure(string Name, int score): base(Name)
        {
            this.score = score;
        }

        public void UpdateTotalScore()
        {
            Board.totalScore = this.score;
            Console.WriteLine("Total score is updated to: "+Board.totalScore);
        }

        public override void AddMe(List<Collectable> collected)
        {
            base.AddMe(collected);
            UpdateTotalScore();
        }



    }
}
