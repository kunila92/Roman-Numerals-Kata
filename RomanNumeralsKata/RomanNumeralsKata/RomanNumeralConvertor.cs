using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class RomanNumeralConvertor
    {       

        public string ConvertToRomanNumeral(int givenNumber)
        {
            if (givenNumber <= 0) { return "Invalid Input.";  };

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> literal in Helper.LiteralsDictionary)
            {
                while (givenNumber >= literal.Value)
                {
                    sb.Append(literal.Key);
                    givenNumber = givenNumber - literal.Value;
                }
            }
            return sb.ToString();
        }
    }
}
