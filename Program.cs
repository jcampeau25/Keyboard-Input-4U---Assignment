using System.Xml.Serialization;

namespace Keyboard_Input_4U___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            // Part 1
            string name;
            int age, year, birthYear;

            year = DateTime.Now.Year;

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }


            birthYear = year - age;

            Console.WriteLine();
            Console.WriteLine("Hello, " + name + " you were born in " + birthYear);
            Console.WriteLine();

            // Part 2
            int num1, num2, num3, total;

            Console.WriteLine("Give me three numbers and I will add them together");
            Console.WriteLine("Please enter the first number");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            Console.WriteLine("Please enter the second number");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            Console.WriteLine("Please enter the third number");
            while (!int.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }

            total = num1 + num2 + num3;
            Console.WriteLine("Your total is " + total);
            Console.WriteLine();

            // Part 3

            double distance1, distance2, distance3, average;
            Console.WriteLine("Give me three distances and I will find the average");
            Console.WriteLine("Please enter the first distance");
            while (!double.TryParse(Console.ReadLine(), out distance1))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            Console.WriteLine("Please enter the second distance");
            while (!double.TryParse(Console.ReadLine(), out distance2))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            Console.WriteLine("Please enter the third distance");
            while (!double.TryParse(Console.ReadLine(), out distance3))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            average = (distance1 + distance2 + distance3) / 3;
            average = Math.Round(average, 2);

            Console.WriteLine("The average of the distance is " + average);
            Console.WriteLine();

            // Part 4

            double leg1, leg2, hypotenuse;

            Console.WriteLine("Give me two legs of a right triangle and I will find the hypotenuse");
            Console.WriteLine("Please enter the length of first leg");
            while (!double.TryParse(Console.ReadLine(), out leg1))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            Console.WriteLine("Please enter the length of the second leg");
            while (!double.TryParse(Console.ReadLine(), out leg2))
            {
                Console.WriteLine("Invalid Input. Try again.");
            }
            hypotenuse = (leg1 * leg1) + (leg2 * leg2);
            hypotenuse = Math.Sqrt(hypotenuse);
            hypotenuse = Math.Round(hypotenuse, 2);

            Console.WriteLine("The hypotenuse is " + hypotenuse);
            


        }
    }
}
