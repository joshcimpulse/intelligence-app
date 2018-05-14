using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class SaleDay
    {
        public string salesPerson;
        public DateTime date;
        public List<Sale> saleList;
        public float totalVolume;
        public float totalGP;

        /*
         * Function responsible for retrieving a list of Sales Order Numbers from DB, 
           Uses instance's date as param and returns a list of strings of SorNumbers         
         */

        public List<string> retrieveSorNumbers() {

            //await querySale task


        }
        /*
         Asynchronous task for retrieiving all of the sales order numbers for a specific
         salesperson and date
         >>Need DB access to implement
         */
        private async Task<List<string>> querySorNumbers(string query)
        {



        }
        /*
         Method responsible for retrieving all the sale data for the specific date.
         A list of sales order numbers is required, which will be iterated over and
        individual queries made for each sale order.
             
        */
        private void retrieveAllSales()
        {




        }
        /*
        Method for computing the total sales volume for the day based on the instance's
        sales list
        */
        private float computeVolume()
        {




        }
        /*
        Method for computing the total sales GP for the day based on the instance's
        sales list
        */
        private float computeGP()
        {




        }

    }
}
