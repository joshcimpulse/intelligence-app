using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp.Models
{
    public class RetrieveSaleDataException : Exception
    {

        public RetrieveSaleDataException()
        {

        }

        public RetrieveSaleDataException(string message) : base(message)
        {

        }

        public RetrieveSaleDataException(string message, Exception inner) : base(message, inner)
        {


        }

    }
}
