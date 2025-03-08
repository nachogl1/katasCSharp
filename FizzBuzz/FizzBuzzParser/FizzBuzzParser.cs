using System;

namespace FizzBuzzParser
{
    public class FizzBuzzParser
    {
        public string Parse(int input)
        {
            var result = "";

            if (input % 3 == 0)
            {
                result += "Fizz";
            }

            if (input % 5 == 0)
            {
                result += "Buzz";
            }


            return result.Length > 0 ? result : Convert.ToString(input);
        }
    }
}