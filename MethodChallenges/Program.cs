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

        // Creates a random pin of 4 digitss. Random .next
        public static string GeneratePin()
        {
            Random rand = new Random();

            return rand.Next(1000, 10000).ToString();   // 1000 to 9999
        }

        // Filtering even numbers from an array

        public static int[] filterEven(int[] array)
        {
            //return arr.Where(NotFiniteNumberException => % 2 == 0).ToArray();
            return [.. array.Where(num =>  num % 2 == 0)];  // spread > C# 12
        }

        // Bubble sort an array of ints
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j])
                    {
                        // Swap arr[j] and arr[j + 1]
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);    // tuple swap
                    }
                }
            }
        }

        // Binary search for an int in a sorted array
        public static int BinarySearch(int[] arr, int val)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == val) return mid;  // Target found

                if (arr[mid] < val)
                {
                    left = mid + 1;  // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }
            return -1;
        }

        // Check if two strings are anagrams
        public static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            char[] chars1 = str1.ToLower().ToCharArray();
            char[] chars2 = str2.ToLower().ToCharArray();

            Array.Sort(chars1);
            Array.Sort(chars2);

            return new string(chars1) == new string(chars2);
        }

        // Calculate common elements between two arrays
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            HashSet<int> set1 = [.. arr1];
            HashSet<int> set2 = [.. arr2];

            set1.IntersectWith(set2);
            return [.. set1];

        }

    }
}
