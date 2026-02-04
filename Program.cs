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
            age = Convert.ToInt32(Console.ReadLine());

            birthYear = year - age;

            Console.WriteLine();
            Console.WriteLine("Hello, " + name + " you were born in " + birthYear);
            Console.WriteLine();

            // Part 2
            int num1, num2, num3, total;

            Console.WriteLine("Give me three numbers and I will add them together");
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3;
            Console.WriteLine("Your total is " + total);
            Console.WriteLine();

            // Part 3

            double distance1, distance2, distance3, average;
            Console.WriteLine("Give me three distances and I will find the average");
            Console.WriteLine("Please enter the first distance");
            distance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second distance");
            distance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the third distance");
            distance3 = Convert.ToDouble(Console.ReadLine());
            
            average = (distance1 + distance2 + distance3) / 3;
            average = Math.Round(average, 2);

            Console.WriteLine("The average of the distance is " + average);
            Console.WriteLine();

            // Part 4

            double leg1, leg2, hypotenuse;

            Console.WriteLine("Give me two legs of a right triangle and I will find the hypotenuse");
            Console.WriteLine("Please enter the length of first leg");
            leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the length of the second leg");
            leg2 = Convert.ToDouble(Console.ReadLine());

            hypotenuse = (leg1 * leg1) + (leg2 * leg2);
            hypotenuse = Math.Sqrt(hypotenuse);
            hypotenuse = Math.Round(hypotenuse, 2);

            Console.WriteLine("The hypotenuse is " + hypotenuse);
            


        }
    }
}
