namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintThree();
            Console.WriteLine(IsEqualOrNot(8, 9));
            EvenOrOdd();
            IsPositiveOrNegative();
            OldEnough();
            InRange();
            MultTable();
        }
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers() 
        {
            for (int a = 1000; a >= -1000; a--) 
            { 
                Console.WriteLine(a);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThree() 
        { 
            for(int b = 3; b <= 999; b += 3) 
            { 
                Console.WriteLine(b);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqualOrNot(int c, int d) 
        { 
            if(c == d) 
            {
                return true; 
            }
            else 
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            int e;
            Console.WriteLine("Enter a number to check: ");
            e = int.Parse(Console.ReadLine());
            if(e % 2 == 0)
            {
                Console.WriteLine(e + " is an even number");
            }
            else 
            { 
                Console.WriteLine(e + " is an odd number");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void IsPositiveOrNegative()
        {
            int f;
            Console.WriteLine("Enter a number : ");
            f = int.Parse(Console.ReadLine());
            if(f ==0) 
            { 
                Console.WriteLine(f + " is zero.");
            }
            else if(f > 0) 
            {
                Console.WriteLine(f + " is positive number.");
            }
            else 
            {
                Console.WriteLine(f + " is a negative number.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void OldEnough() 
        {
            int g;
            Console.WriteLine("Enter your age: ");
            g = int.Parse(Console.ReadLine());
            if(g > 18) 
            {
                Console.WriteLine(g + " you are old enough horray!");
            }
            else 
            { 
                Console.WriteLine(g + "sorry better luck next year. :(");
            }
        }
        //Heatin Up Section:


        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange() 
        {
            int h;
            Console.WriteLine("Enter a number between -10 and 10 : ");
            h = int.Parse(Console.ReadLine());
            if(h < -10) 
            { 
                Console.WriteLine(h + " sorry that number is too low for our range");
            }
            else if(h > 10) 
            {
                Console.WriteLine(h + " Sorry that number is higher than the range");
            }
            else 
            {
                Console.WriteLine(h + " Yes that number is in our range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable() 
        {
            int table = 9;
            int length = 10;
            int i = 1;

            Console.WriteLine("Multiplication table: " + table);
            for (i = 1; i <= length; i++)
                Console.WriteLine("{0, 2} * {1, 2} = {2}", i, table, i * table);
        }

    }
}
