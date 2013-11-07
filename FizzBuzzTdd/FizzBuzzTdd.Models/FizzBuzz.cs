using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzTdd.Models
{
    public class FizzBuzz : IFuzzBuzz
    {
        public string Answer(int max)
        {
            var output = string.Empty;

            for (var i = 1; i <= max; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    output += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    output += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    output += "Buzz ";
                }
                else
                {
                    output += string.Format("{0} ", i.ToString());
                }
            }

            return output.TrimEnd();
        }
    }
}
