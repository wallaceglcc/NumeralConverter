using System;
using System.Collections.Generic;

namespace RomanNumeralConverterWorking
{
    public static class NumberConverter
    {
        //Error handling literals
        const string ERROR_OUTSIDE_RANGE = "OR";
        const string ERROR_NON_DIGIT = "NN";
        const string ERROR_NON_NUMERAL = "NR";
        const string ERROR_NON_ENTRY = "";

        const string ERROR_NON_ENTRY_MESSAGE = "ERROR: Please enter a value";
        const string ERROR_OUTSIDE_RANGE_MESSAGE = "ERROR: Entry must be 1-10";
        const string ERROR_NON_DIGIT_MESSAGE = "ERROR: Entry must be a number 1-10";
        const string ERROR_NON_NUMERAL_MESSAGE = "ERROR: Entry must be a Roman Numeral I-X";

        //Numerals
        static List<string> numerals = new List<string> { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };


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
                else return ERROR_OUTSIDE_RANGE; //Outside range
            }
            else return ERROR_NON_DIGIT; //Not a number
        }

        public static string ConvertNumeralToNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return ERROR_NON_ENTRY; //Field is empty/whitespace
            }
            foreach(string numeral in numerals)
            {
                if(text == numeral)
                {
                    return (numerals.IndexOf(numeral) + 1).ToString(); //convert to digit
                }
            }
            return ERROR_NON_NUMERAL; //If it isn't a numeral in the list
        }

        public static string ConversionResponse(string conversionResult)
        {
            switch (conversionResult) //Interpret the result of the conversion
            {
                case ERROR_NON_ENTRY:
                    return ERROR_NON_ENTRY_MESSAGE;
                case ERROR_OUTSIDE_RANGE:
                    return ERROR_OUTSIDE_RANGE_MESSAGE;
                case ERROR_NON_DIGIT:
                    return ERROR_NON_DIGIT_MESSAGE;
                case ERROR_NON_NUMERAL:
                    return ERROR_NON_NUMERAL_MESSAGE;
                default:
                    return conversionResult;
            }
        }
    }
}
