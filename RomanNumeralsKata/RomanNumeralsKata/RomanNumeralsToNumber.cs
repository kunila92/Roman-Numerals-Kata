using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralsToNumber
    {
        public string ConvertToNumber(string givenNumeral)
        {
            StringBuilder sb = new StringBuilder();

            if (givenNumeral == "I")
                sb.Append("1");
            return sb.ToString();
        }
    }
}
