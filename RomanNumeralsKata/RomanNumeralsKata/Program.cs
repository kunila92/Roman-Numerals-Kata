using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose which task to perform either by entering 1 or 2.");
            Console.WriteLine("1 - Convert givenNumber to Roman Numeral. \n2 - Convert RomanNumeral to Number. ");
            string choice = Console.ReadLine();
            string output = string.Empty;
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter a number to convert.");
                    int givenNumber = Int32.Parse(Console.ReadLine());
                    RomanNumeralConvertor rnm = new RomanNumeralConvertor();
                    output = rnm.ConvertToRomanNumeral(givenNumber);
                    break;
                case "2":
                    Console.WriteLine("Please enter a number to convert.");
                    string givenNumeral = Console.ReadLine();
                    RomanNumeralsToNumber rnn = new RomanNumeralsToNumber();
                    output = rnn.ConvertToNumber(givenNumeral);
                    break;
            }
            Console.WriteLine("Output is :" + output);
            Console.WriteLine("Enter any key to exit.");
            Console.ReadLine();
        }
    }
}
