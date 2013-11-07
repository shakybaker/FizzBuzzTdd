using FizzBuzzTdd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number greater than 0 and press Return");
            var userValue = Console.ReadLine();
            var fizzBuzz = new FizzBuzz();
            var answer = fizzBuzz.Answer(int.Parse(userValue));//TODO: validation
            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
