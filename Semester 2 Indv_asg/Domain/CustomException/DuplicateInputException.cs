using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CustomException
{
    public class DuplicateInputException : Exception
    {
        public DuplicateInputException(string message):base(message) { }
    }
}
