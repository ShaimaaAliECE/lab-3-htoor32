using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public Treasure(string description) : base(description) { }

        public void UpdateTotalScore(int score)
        {
            Board.TotalScore = Board.TotalScore + score;
            Console.WriteLine("Total Score was updated to: " + Board.TotalScore);
        }
    }

    
}
