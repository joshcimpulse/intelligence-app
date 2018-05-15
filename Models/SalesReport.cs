using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class SalesReport 
    {
        public List<SaleDay> saleDays;
        DateTime beginDate, endDate;


        /*
        Top level method of building reports. Responsible for rangifying the begin/end dates, iterating
        over this range and retrieving SaleDays asynchronously.




        public SalesReport(DateTime beginDate, DateTime endDate)
        {




        }
         */
        /*
        
         Task for asynchronously querying and constructing SaleDay instances for the report SaleDay list
         

        public async Task<List<SaleDay>> retrieveReportData()
        {


        }
        */
    }
}
