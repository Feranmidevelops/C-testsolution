using System;

namespace InternshipTest

{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            Console.WriteLine("name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("is Admin: " + isAdmin);


            //task2

            Console.Write("\nEnter an integer: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("odd");
            }

            //task 3

            Console.WriteLine("\nNumbers from 1 to 10: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            //task 4
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            Console.WriteLine("\nArray Elements");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine("sum of elements:" + sum);

            //task5
            Greet("Alice");
        }
        static void Greet(string name)
        {
            Console.WriteLine("\nHello, " + name + "!");
        }

        }

    }



