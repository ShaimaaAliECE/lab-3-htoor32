using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
   class CollectionBoard
    {
        private int totalScore;
        private int totalValue;

        public CollectionBoard() 
        {
            TotalScore = 0;
            totalValue = 0;
        }

        public int TotalScore { get { return totalScore; } set { totalScore = TotalScore; } }
        public int TotalValue { get { return totalValue; } set { totalScore = TotalValue; } }

    }
}
