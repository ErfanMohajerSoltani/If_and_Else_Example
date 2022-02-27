using System;

namespace If_and_Else_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                // use if to set some condition 
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("1st number and 2nd number are equal to eachother");
                }
                // use else if for that time your previous condition or conditions wasn't true and you want to have another condition
                else if (firstNumber > secondNumber)
                {
                    Console.WriteLine("1st number is more than 2nd number");
                }
                // use else for that time none of your previous conditions weren't true and you don't want to set new condition
                else
                {
                    Console.WriteLine("none of previous conditions weren't ture");
                }

            }
            catch
            {
                Console.WriteLine("ERROR!!!");
            }
        }
    }
}
