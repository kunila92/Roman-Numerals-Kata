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

        public string ConvertToRomanNumeral(int givenNumber)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> literal in LiteralsDictionary)
            {
                int currNumber = givenNumber;
                if (currNumber >= literal.Value)
                {
                    int currDictionaryValue = literal.Value;
                    int noOfIterations = (givenNumber - (givenNumber % currDictionaryValue)) / currDictionaryValue;
                    
                    while (noOfIterations > 0)
                    {
                        sb.Append(literal.Key);
                        noOfIterations--;
                    }

                    currNumber = givenNumber % literal.Value;
                }
            }
            return sb.ToString();
        }
    }
}
