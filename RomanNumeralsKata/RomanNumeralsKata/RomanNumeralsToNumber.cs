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
            if (givenNumeral == "") { return "Invalid Input."; };

            int retVal = 0;
            while (!string.IsNullOrEmpty(givenNumeral))
            {
                foreach (string currentKey in Helper.LiteralsDictionary.Keys)
                {
                    if (givenNumeral.StartsWith(currentKey))
                    {
                        retVal = retVal + GetValueOfGivenKey(currentKey);
                        givenNumeral = givenNumeral.Substring(currentKey.Length);
                        break;
                    }
                }
            }

            return retVal.ToString();
        }

        private int GetValueOfGivenKey(string givenKey)
        {
            return Helper.LiteralsDictionary[givenKey];
        }
    }
}
