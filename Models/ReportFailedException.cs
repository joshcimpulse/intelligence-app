using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class ReportFailedException : Exception
    {
        public ReportFailedException()
        {

        }

        public ReportFailedException(string message): base(message)
        {

        }

        public ReportFailedException(string message, Exception inner) : base(message, inner)
        {


        }
    }
}
