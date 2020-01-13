using System;
using System.Collections.Generic;

namespace RomanNumeralConverterWorking
{
    public class NumberConverter
    {
        static List<string> numerals = new List<string> { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

        public NumberConverter()
        {
        }

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

        public static string ConvertNumeralToNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return ""; //Field is empty/whitespace
            }
            foreach(string numeral in numerals)
            {
                if(text == numeral)
                {
                    return (numerals.IndexOf(numeral) + 1).ToString(); //convert to digit
                }
            }
            return "NR"; //If it isn't a numeral in the list
        }

        public static string ConversionResponse(string conversionResult)
        {
            switch (conversionResult) //Interpret the result of the conversion
            {
                case "":
                    return "Please enter a value";
                case "NN":
                    return "Number must be 1-10";
                case "OR":
                    return "Entry must be a number 1-10";
                case "NR":
                    return "Entry must be a Roman Numeral I-X";
                default:
                    return conversionResult;
            }
        }
    }
}
