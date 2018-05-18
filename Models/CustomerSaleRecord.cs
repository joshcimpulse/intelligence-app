using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class CustomerSaleRecord
    {
        public string customerCode, customerName;
        public List<InvoiceLine> lines;
        public float netSales, GP;




    }
}
