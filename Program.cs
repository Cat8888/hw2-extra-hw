using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2_extra_HOMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Q1
            Console.WriteLine("Q1");
            Console.WriteLine("Enter a name: ");
            int length;
            length = Console.ReadLine().Length;

            switch (length)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("That is not a real name.");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("You have a short name.");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("A name with an average length.");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("What a long name!");
                    break;
                default:
                    Console.WriteLine("Is this only one name?");
                    break;
            }

            //Q2
            Console.WriteLine("Enter a positive integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            while (a <= num1)
            {
                Console.WriteLine("Square of: " + a + " = " + Math.Pow(a, 2));
                a++;
            }


            //Q3

            Console.WriteLine("I have picked a number between 1 and 100, " + "guess the number: ");
            int mynumber = 99;
            int guess;
            int kactane = 0;

            do

            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < mynumber)
                {
                    Console.WriteLine("increase your guess");

                }
                else if (guess > mynumber)
                {
                    Console.WriteLine("Decrease your number");
                }
                kactane++;
            } while (guess != mynumber);
            Console.WriteLine("You have found the number after " + kactane + " guess");

            //Q4

            Console.WriteLine("Enter the height of rectangle: ");
            int height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the width of rectangle: ");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < height; j++)
                {

                    if (i % 2 == 1)
                        Console.Write("O");
                    else
                        Console.Write("X");
                }
                Console.WriteLine();

            }

            /*
            //Q5
            //bunu yapmayalım demiştik, denedim ama olmadı zaten, atlıyorum

            Console.WriteLine("Enter the number: ");
            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = row; i > 0; i--)
                
            {
                for ( int j = 1; j < i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }
            */

            //Q6

            Console.WriteLine("Give me 10 numbers: ");
            int[] number1 = new int[10];

            for (int i = 0; i < number1.Length; i++)
            {
                Console.WriteLine("Number {0}", (i + 1));
                number1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The first smallest number is: " + number1.Min());
            int Min2 = number1.OrderBy(z => z).Skip(1).First();
            Console.WriteLine("Second smallest number is: " + Min2);



            //Q7
            //yapamadım->(verilen numaraların ascending orderda olup olmadığı)

            Console.WriteLine("Give me 10 numbers: ");
            int[] usernumbers = new int[10];

            // Sayilari almissin guzel
            for (int n = 0; n < usernumbers.Length; n++)
            {
                Console.WriteLine("Number {0}", (n + 1));
                usernumbers[n] = Convert.ToInt32(Console.ReadLine());

            }

            Boolean aornot = true;

            for (int n = 0; n < usernumbers.Length - 1; n++)
            {
                if (usernumbers[n] >= usernumbers[n + 1])
                {
                    aornot = false;
                    break;
                }
            }

            if (aornot)
            {
                Console.WriteLine("Ascending order");
            }
            else
            {
                Console.WriteLine("Not ascending order");
            }

            //YUKARIDAKILERDEN SADECE 5 VE 7yi YAPAMADIM
             //EXTRA ÖDEVLER///////////////////////////////////////////////////////////////////////////////

            //Q1

            Console.WriteLine("Enter a Positive integer: ");
            int sq = Convert.ToInt32(Console.ReadLine());
            while (sq > 0)
            {
                Console.WriteLine("Square of " + sq + " is " + (sq * sq));
                sq--;
            }
            Console.WriteLine();

            //Q2

            Console.WriteLine("Give me a number: ");
            int sumnumber = Convert.ToInt32(Console.ReadLine());
            int y = 0;
            while (y < sumnumber)
            {
                Console.WriteLine("summation" + sumnumber + " :" + ((sumnumber * (sumnumber + 1)) / 2));
                sumnumber--;
            }
            Console.WriteLine();

            //Q3

            Console.WriteLine("Enter a positive integer: ");
            int posint = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            while (p <= posint)
            {
                Console.WriteLine("5 * " + p + " = " + (p * 5));
                p++;

            }
            Console.WriteLine();

            //Q4

            Console.WriteLine("Enter a positive integer: ");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a positive integer: ");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            int end = 1;

            while (end <= secondnum)
            {
                Console.WriteLine(firstnum + " * " + end + " = " + (firstnum * end));
                end++;

            }
            Console.WriteLine();

            //Q5

            int nmin1, nmin2, nmin3, days, hours, minutes;

            Console.WriteLine("Enter number of days: ");
            days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of hours: ");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            nmin1 = days * 1440;
            nmin2 = hours * 60;
            nmin3 = minutes * 1;
            Console.WriteLine("Number of days: " + (days));
            Console.WriteLine("Number of hours: " + (hours));
            Console.WriteLine("Number of minutes: " + (minutes));
            Console.WriteLine("Total minutes: " + (nmin1 + nmin2 + nmin3));
            Console.WriteLine("Total minutes consists of: " + ((nmin1 + nmin2 + nmin3) / 60 + " hours " + (nmin1 + nmin2 + nmin3) % 60 + " minutes"));

            //Q6

            int cent, meter, kilometer, remcent;
            Console.WriteLine("Enter centimeters: ");
            cent = Convert.ToInt32(Console.ReadLine());
            meter = cent / 100;
            kilometer = meter / 100;
            remcent = (kilometer + meter + cent) % 100;
            Console.WriteLine(cent + " centimeter(s) consists of: " + kilometer + " kilometers, " + meter + " meters " + "and " + remcent + " centimeters");
        }
    }
}