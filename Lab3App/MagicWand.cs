using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string name) : base(name) { }

        public void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }
        public void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

    }
}
