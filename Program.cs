// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int limit = 30;
            FizzBuss fizzbuss = new FizzBuss(limit);
            fizzbuss.Run();
            
        }
    }

    class FizzBuss
    {
        private int _limit;

        public FizzBuss(int limit)
        {
            _limit = limit;
        }

        public void Run()
        {
            for(int i=1; i<=_limit; i++)
            {
                if(i%3 ==0  && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }


            }
        }        
    }
}


/*
Console.WriteLine("Hello, World!");


int limit = 30;
FizzBuzz fizzBuzz = new FizzBuzz(limit);
fizzBuzz.Run();


class FizzBuzz
{
    private int _limit;

    public FizzBuzz(int limit)
    {
        _limit = limit;
    }

    public void Run()
    {
        for (int i = 1; i <= _limit; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
*/