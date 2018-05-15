using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class SaleLine
    {
        public string stockCode;
        public string stockDescription;
        public float orderQty;
        public float unitPrice;
        public float unitCost;
        public float lineGP;


        /*
        
            Constructor for a SaleLine given the data retrieved from the superior Sale's querySalesLines method
             

        public SaleLine(string stockCode, string stockDescription, float orderQty, float unitCost)
        {



        }
        public float computeValue()
        {


        }


        public float computerGP()
        {



        }
        */
    }
}
