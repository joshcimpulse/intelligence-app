using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class Sale
    {
        public List<SaleLine> saleLines;
        public string customer;
        public string sorNum;


        /*
        To retrieve sale information from database asynchronously calling the querySale task 
        Responsible for setting it's instances saleLines list, to be only called within construtor
        after receiving a valid sor number. 

        */

        public Sale(sorNum) {


        }
        /*
         Asynchronous task for retrieiving all of the sale lines for a specific sales order nmber
         >>> Need db access for this 
         */
        private async Task<Sale> querySaleLines(string queryString) {



        }
        /*
        Method for computing the total sales volume for the sale based on the instance's
        saleLines list
        */
        private float computeVolume()
        {




        }
        /*
        Method for computing the total sales GP for the sale based on the instance's
        saleLines list
        */
        private float computeGP()
        {




        }
    }
}
