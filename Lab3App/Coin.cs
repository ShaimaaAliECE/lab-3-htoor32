using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int val;
        public int Value { set { val = Value; } get { return val; } }

        public Coin (string description, int score, int value)  :base (description) 
        {
            this.Value = value;
            UpdateTotalScore(score);
            UpdateTotalValue(value);
        }

        public void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        public void UpdateTotalValue(int value)
        {
            Board.TotalValue += value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }



    }
}
