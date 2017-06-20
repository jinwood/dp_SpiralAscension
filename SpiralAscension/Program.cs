using System;

namespace SpiralAscension
{
    class Program
    {
        public const int Base = 5;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integer");
            int.TryParse(Console.ReadLine(), out int input);
            var start = 1;

            Ascend(input, ref input, ref start);
            Console.ReadLine();
        }

        static void Ascend(int input, ref int count, ref int start)
        {
            if (count == 0)
            {
                count = input;
                Console.Write(Environment.NewLine);
            }
            var diff = (Base - input) +1;
            Console.Write($"{start}");
            while(diff != 0 && diff > 0)
            {
                Console.Write(" ");
                diff--;
            }
            start++;
            count--;

            if (start == input * input +1) { return; } else Ascend(input, ref count, ref start);
        }
    }
}