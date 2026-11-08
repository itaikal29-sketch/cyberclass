using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int best = 0;
            //double highest = -1;
            //double slow = 0;
            //for (int i = 0; i < 15; i++)
            //{
            //    double sweets = 0;
            //    for (int j = 0; j < 30; j++)
            //    {
            //        Console.WriteLine("enter sweets");
            //        sweets = double.Parse(Console.ReadLine()) + sweets;
            //    }
            //    double avrege = sweets / 30;
            //    if (avrege > highest)
            //    {
            //        highest = avrege;
            //        best = i;

            //    }
            //    if (avrege < 100)
            //    {
            //        slow++;

            //    }

            //}
            //Console.WriteLine("best machine is " + best);
            //Console.WriteLine("the number of machines who are under preforming 100 is " + slow);


            //int cagesWithManyDogs = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    int dogsInCurrentCage = 0;
            //    Console.WriteLine("enter dog's id or -1 to end slot");
            //    int dogId = int.Parse(Console.ReadLine());
            //    while (dogId != -1)
            //    {
            //        dogsInCurrentCage++;
            //        Console.WriteLine("enter dog's id or -1 to end slot");
            //        dogId = int.Parse(Console.ReadLine());
            //    }

            //    if (dogsInCurrentCage > 10)
            //    {
            //        cagesWithManyDogs++;
            //    }
            //}

            //Console.WriteLine("the num of slots with more then 10 dogs is"+cagesWithManyDogs);



            //double lowestAverage = 101;
            //int worstCompetitor = 0;

            //for (int i = 1; i <= 12; i++)
            //{
            //    double sumGrades = 0;
            //    Console.WriteLine("enter grades for competitor "+i);

            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write("enter grade for subject "+j);
            //        double grade = double.Parse(Console.ReadLine());
            //        sumGrades += grade;
            //    }

            //    double average = sumGrades / 8;


            //    if (average < lowestAverage)
            //    {
            //        lowestAverage = average;
            //        worstCompetitor = i;
            //    }
            //}

            //Console.WriteLine("the competitor with the lowest average grade is "+worstCompetitor+" with an average of "+lowestAverage);

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine("enter number "+i);
            //    int n = int.Parse(Console.ReadLine());

            //    int sum = 0;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        sum += j;
            //    }

            //    Console.WriteLine("the sum of the between 1 and "+n+"is"+sum);
            //}

            
            int goodStudentsCount = 0;

            for (int i = 1; i <= 150; i++)
            {
                Console.WriteLine("Enter grades for student number" +i+" (type -999 to finish student)");

                double sumGrades = 0;
                int countGrades = 0;

                int grade = int.Parse(Console.ReadLine());
                while (grade != -999)
                {
                    sumGrades += grade;
                    countGrades++;
                    grade = int.Parse(Console.ReadLine());
                }

                
                
                
                 double average = sumGrades / countGrades;
                 if (average > 90)
                   {
                      goodStudentsCount++;
                    }
                
            }

            Console.WriteLine("The number of students with an average grade above 90 is: " + goodStudentsCount);
        }




    }

       
    }
}
        

        

