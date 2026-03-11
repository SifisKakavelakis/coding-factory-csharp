using System.Text;

namespace MethodChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        //Checks if a int is even
        public static int IsEven(int number)
        {
            return number % 2 == 0 ? 1 : 0;
        }

        // Calculate the Max of two ints
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Calculate the area of a circle
        public static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Convertes Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Returns repeated string n times
        public static string RepeatString(string str, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
