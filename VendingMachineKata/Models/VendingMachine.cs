using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachineKata.Models
{
    public class VendingMachine
    {
        double TOTAL = 0.00;

        public void insert(string value)
        {
            if(value.Equals("nickel"))
            {
                TOTAL += 0.05;
            }
            else if(value.Equals("dime"))
            {
                TOTAL += 0.1;
            }
            else if(value.Equals("quarter"))
            {
                TOTAL += 0.25;
            }
        }

        public string getDisplay()
        {
            return string.Format("{0:0.00}", TOTAL);
        }
    }
}