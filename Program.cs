using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator newOne = new Calculator();
            Console.WriteLine(newOne.Add(5, 6));
        }
    }
}
