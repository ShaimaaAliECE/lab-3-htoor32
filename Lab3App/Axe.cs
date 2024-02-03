using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        public Axe(string description) : base(description) { }

        public void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }
        public void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
    }
}
