using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Counter
{
	static public class Calculator
	{
        static public int ToAge(DateTime BirthDate)
        {
            return Convert.ToInt32(Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(BirthDate.Year));
        }
    }
}
