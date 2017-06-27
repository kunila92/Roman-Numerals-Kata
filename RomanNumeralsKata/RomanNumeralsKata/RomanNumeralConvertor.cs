using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralConvertor
    {
        private readonly Dictionary<string, int> LiteralsDictionary = new Dictionary<string, int>()
        {
            {"I", 1},
            {"V", 5},
            {"X", 10}
        };

        public string ConvertToRomanNumeral(int number)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> literal in LiteralsDictionary)
            {
                int staticValue = literal.Value;
                if (number >= staticValue)
                {
                    while (number % staticValue == 0)
                    {
                        sb.Append("I");
                        staticValue += 1;
                    }
                }
                else { continue; }
            }
            return sb.ToString();
        }
    }
}
