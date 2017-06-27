using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    public class Helper
    {
        public static readonly Dictionary<string, int> LiteralsDictionary = new Dictionary<string, int>()
        {
            // Assuming taking following numbers in List are fine like 4, 9, 40, 400, 900, etc.
            { "M",1000 },
            { "CM",900 },  
            { "D",500 },
            { "CD",400 },
            { "C",100 },
            { "L",50 },
            { "XL",40 },
            { "X",10 },
            { "IX",9},
            { "V",5 },
            { "IV",4 },
            { "I",1 }  
        };
    }
}
