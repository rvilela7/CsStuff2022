using System;

namespace myConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 4, 67, 45, 33, 2, 6, 355, 7, 77 };
            // var itemMoved = false;
            // do
            // {
            //     itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        // var lowerValue = input[i + 1];
                        // input[i + 1] = input[i];
                        // input[i] = lowerValue;
                        (input[i+1], input[i]) = (input[i], input[i+1]); // Like old perl
                        // itemMoved = true;
                    }
                }
            // } while (itemMoved);

            input.ToList().ForEach(m => Console.Write($"{m}, "));
        }
    }
}

