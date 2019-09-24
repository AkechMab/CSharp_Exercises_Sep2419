using System;

namespace Exercises_Sep2419
{
    public class Sep2419
    {
        static void Main(string[] args)
        {
           //console application run the method by calling here
        }

        public static string PrintName(string name)
        {
            //Write a C# Sharp program to print Hello and your name in a separate line.
            return $"Hello \n {name}";

        }

        public static string SumOfNum(int numOne, int numTwo)
        {
            //Write a C# Sharp program to print the sum of two numbers.
            return $"{numOne} + {numTwo} = {numOne + numTwo}";
        }

        public static string DivTwoNum(int numOne, int numTwo)
        {
            //Write a C# Sharp program to print the result of dividing two numbers.
            return $"{numOne} + {numTwo} = {numOne / numTwo}";
        }

        public static string[] SpecMathCal()
        {
            /*Write a C# Sharp program to print the result of the specified operations.
             * Operation 1: -1 + 4 * 6
             * Operation 2: ( 35+ 5 ) % 7
             * Operation 3: 14 + -4 * 6 / 11
             * Operation 4: 2 + 15 / 6 * 1 - 7 % 2
             */

            string operationOne   = $"-1 + 4 * 6 = {(-1 + 4) * 6}";
            string operationTwo   = $"( 35+ 5 ) % 7 = {(35 + 5) % 7}";
            string operationThree = $"14 + -4 * 6 / 11 = {(14 + -4) * (6 / 11)}";
            string operationFour  = $"2 + 15 / 6 * 1 - 7 % 2 = {(2 + 15)/ 6 * (1 - (7 % 2))}";

            string[] operations = { operationOne, operationTwo, operationThree, operationFour };

            return operations;
        }

        public static int[] SwapTwoNum(int numOne, int numTwo)
        {
            //Write a C# Sharp program to swap two numbers.
            int numThree = numOne;
            numOne = numTwo;
            numTwo = numThree;

            int[] numSwitched = { numOne, numTwo};

            return numSwitched;
        }
    }
}
