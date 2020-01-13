using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace RomanNumeralConverter
{
    class NumberConverter
    {
        static List<string> numerals = new List<string> {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
        
        public static string ConvertNumberToNumeral(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return ""; //Field is empty/whitespace
            }

            if (int.TryParse(text, out int num)) //Convert text field to num
            {
                if (num > 0 && num < 11) //Check if num 1-10
                {
                    return numerals[num - 1]; //Return converted numeral
                }
                else return "OR"; //Outside range
            }
            else return "NN"; //Not a number
        }
    }
}