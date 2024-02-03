using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable
    {
        private CollectionBoard board = new CollectionBoard();
        public CollectionBoard Board { set { board = Board; } get { return board; } }
        private string description;
        public string Description { get { return description; } }   


        
        public Collectable(String description)
        {
            this.description = description;
            Console.WriteLine(description + " is collected, Congrats!!!!");
        }

        public String getDescription()
        {
            return this.description;
        }
        public void AddMe(List<Collectable> list)
        {
            list.Add(this);
        }

        public void Display() 
        {
            Console.WriteLine(Description + " is displayed");
        }



    }
}
