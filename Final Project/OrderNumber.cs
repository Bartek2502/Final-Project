using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    //properties for the random order number
    public class OrderNumber
    {
        public string RandomOrderNumber { get; set; }

        public OrderNumber(string randomOrderNumber)
        {
            randomOrderNumber = RandomOrderNumber;
        }

        public OrderNumber() : this("Unknown") { }

        //Formating the json text
        public override string ToString()
        {
            return string.Format("[{0}] {1}", this.GetType().Name.ToUpper(), RandomOrderNumber);
        }
    }
}
