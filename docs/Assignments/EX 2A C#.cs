using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculating_Averages
{
    class Program
    {



        static void Main(string[] args)

        {

            int maxIterations = 10;
            int accum = 0;
            double avg;
            //Exercise #1 Calculate the sum of 10 numbers
            for (int i = 0; i < maxIterations; ++i)
            {
                Console.WriteLine("Enter 10 numerical grades between 0 and 100:");
                accum += int.Parse(Console.ReadLine());
                Console.WriteLine(i);

            }
            Console.WriteLine("\nThe sum of the 10 Numbers is:  ");
            Console.WriteLine(accum);

            //Exercise#2: Caculate the average of ten scores
            avg = accum / 10.0;

            Console.WriteLine("The average for a grade is: ");
            Console.WriteLine(avg);
            Console.WriteLine("Click enter to see your letter grade...");
            Console.ReadLine();

            if (avg < 65)
            {
                Console.WriteLine("Your grade is a: F");
            }
            else if (avg < 70)
            {
                Console.WriteLine("Your grade is a: D");
            }
            else if (avg < 80)
            {
                Console.WriteLine("Your grade is a: C");
            }
            else if (avg < 90)
            {
                Console.WriteLine("Your grade is a: B");
            }
            else
                Console.WriteLine("\n\t\tYour grade is a: A");
            Console.WriteLine("\nClick enter to key in more grades");
            Console.ReadLine();



            //Exercise #3 Average a specific number of scores
            maxIterations = 0;
            accum = 0;

            for (int i = 0; i < maxIterations; ++i)
                while (i < 100)
                {
                    Console.WriteLine("Enter number of grades to average between 0 and 100:  ");
                    accum += int.Parse(Console.ReadLine());
                    Console.WriteLine(i);



                }
            Console.WriteLine("\nThe sum of all Numbers is:  ");
            Console.WriteLine(accum);


            avg = accum / 10.0;

            Console.WriteLine("The average for a grade is: ");
            Console.WriteLine(avg);
            Console.WriteLine("Click enter to see your letter grade...");
            Console.ReadLine();

            if (avg <= 65)
            {
                Console.WriteLine("Your grade is a: F");
            }
            else if (avg < 70)
            {
                Console.WriteLine("Your grade is a: D");
            }
            else if (avg < 80)
            {
                Console.WriteLine("Your grade is a: C");
            }
            else if (avg < 90)
            {
                Console.WriteLine("Your grade is a: B");
            }
            else
                Console.WriteLine("Your grade is a: A");
            Console.ReadLine();
            Console.WriteLine("\n\t\tYour grade is a: A");
            Console.WriteLine("\nClick enter to key in more grades");
            Console.ReadLine();


            //Exercise #4 Enter a non-specific number of scores

             maxIterations = 0;
             accum = 0;
             
            int ChosenRandom;
            Console.WriteLine("Press enter for random number of grades between 0 and 100 to be averaged: ");
            ChosenRandom = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            _ = rnd.Next(0, 100);
            for (int i = 0; i < ChosenRandom; i++)

            {
                Console.WriteLine("Random numbers: " + rnd.Next(0, 100));
            }

            for (int i = 0; i < maxIterations; ++i)
            {
               
                accum += int.Parse(Console.ReadLine());
                Console.WriteLine(i);

            }
            Console.WriteLine("\nThe sum of the 10 Numbers is:  ");
            Console.WriteLine(accum);

            
            avg = accum / 10.0;

            Console.WriteLine("The average for a grade is: ");
            Console.WriteLine(avg);
            Console.WriteLine("Click enter to see your letter grade...");
            Console.ReadLine();

            if (avg < 65)
            {
                Console.WriteLine("Your grade is a: F");
            }
            else if (avg < 70)
            {
                Console.WriteLine("Your grade is a: D");
            }
            else if (avg < 80)
            {
                Console.WriteLine("Your grade is a: C");
            }
            else if (avg < 90)
            {
                Console.WriteLine("Your grade is a: B");
            }
            else
                Console.WriteLine("\n\t\tYour grade is a: A");
            Console.WriteLine("\nClick enter to key in more grades");
            Console.ReadLine();

        }


    }
}
