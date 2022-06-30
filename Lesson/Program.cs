//using System;

using System;
namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value1: ");
            int v1 = int.Parse(Console.ReadLine());

            Console.WriteLine(v1 + 100);

            Console.Write("Enter Your name: ");
            var name =  Console.ReadLine();
            Console.WriteLine($"My name is: {name}");

            //int n = 20;
            //do
            //{
            //    Console.WriteLine($"DO-WHILE: {n}");
            //    n--;
            //} while (n >= 0);


            //int a = 2;
            //while(a <= 20)
            //{
            //    Console.WriteLine(a);
            //    a--;
            //}


            // 
            //int value1, value2;
            //value1 = 100;
            //value2 = 200;

            //int result = value1 + value2;

            //Console.WriteLine($"Addition: {++result}")




            //Console.WriteLine(!(!(true)));


            //int number = 0;


            ////number = number + 1;

            //number += 1;

            //number *= 5;

            //number /= 5;

            //Console.WriteLine(number);


            //int n, n1;

            //n = 2000;
            //n1 = n;

            //n = 300;

            //Console.WriteLine($"n: {n}");

            //Console.WriteLine($"n1: {n1}");


            //int a = 200;
            //Console.WriteLine(a);
            //bool b = false;
            //Console.WriteLine(b);
            //long myNum = 150000000000000L;
            //Console.WriteLine(long.MaxValue);
            //string greeting = "Hello World!";
            //Console.WriteLine(greeting);
            //float myNum2 = 5.75F;
            //Console.WriteLine(myNum2);
            //char myGrade = 'A';
            //Console.WriteLine(myGrade);


            Console.ReadKey();
        }

       
    }
}
