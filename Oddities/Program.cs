using System;
using System.Collections.Generic;

namespace Oddities
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oddities
            // https://open.kattis.com/problems/oddities
            // number is odd test

            int samplesNum = EnterNumOfSamples();

            List<int> samples = new List<int>();

            for (int i = 0; i < samplesNum; i++)
            {
                samples.Add(EnterSample());
            }

            PrintResult(samples);
        }
        private static void PrintResult(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (OddNumber(numbers[i]))
                    Console.WriteLine($"{numbers[i]} is odd");
                else
                    Console.WriteLine($"{numbers[i]} is even");
            }
        }

        private static bool OddNumber(int a)
        {
            int num = Math.Abs(a);

            if (num % 2 == 0)
                return false;
            else return true;
        }

        private static int EnterSample()
        {
            string str = "";
            int a = 0;
            str = Console.ReadLine();
            try
            {
                a = int.Parse(str);
                if (a < -10 || a > 10)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                return EnterNumOfSamples();
            }
            return a;
        }

        private static int EnterNumOfSamples()
        {
            string str = "";
            int a = 0;
            str = Console.ReadLine();
            try
            {
                a = int.Parse(str);
                if (a < 1 || a > 20)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNumOfSamples();
            }
            return a;
        }
    }
}
