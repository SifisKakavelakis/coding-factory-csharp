namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var allNumbers = from num in numbers select num;    // returns IEnumerable<int>

            foreach (var num in allNumbers)
            {
                Console.WriteLine(num);
            }

            // Filtering
            var eveNumbers = from num in numbers
                             where (num % 2 == 0)
                             select num;

            foreach (var num in eveNumbers)
            {
                Console.WriteLine(num);
            }

            // terminal operations
            List<int> evenNumbers2 = (from num in numbers
                                      where (num % 2 == 0)
                                      select num).ToList();

            var oddNumbers = (from num in numbers
                              where (num % 2 != 0)
                              select num).ToArray();
        }
        // Filtering 
        public static int[] FilterToArray(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 == 0
            //        select num).ToArray();

            return [ ..from num in arr
                   where num % 2 == 0
                   select num];
        }

        public static int[] FilterEvenToList(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 == 0
            //        select num).ToList();

            return [ ..from num in arr
                   where num % 2 == 0
                   select num];
        }

        // Mapping with Select
        public static int[] MapOddToDouble(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 != 0
            //        select num * 2).ToArray();

            return [ ..from num in arr
                   where num % 2 != 0
                   select num * 2];
        }

        public static List<int> MapOddToDoubleToList(int[] arr)
        {
            //return (from num in arr
            //        where num % 2 != 0
            //        select num * 2).ToList);

            return [ ..from num in arr
                   where num % 2 != 0
                   select num * 2];
        }

        // Pagiantion
        public static int[] GetPage(int[] arr, int page, int pageSize)
        {
            return (from num in arr select num).Skip((page - 1) * pageSize).Take(pageSize).ToArray();
        }

        public static Student[] GetStudentPage(Student[] students, int page, int pageSize)
        {
            return (from s in students select s)
                .OrderBy(s => s.Lastname)
                .ThenBy(s => s.Firstname)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToArray();
        }

        // Reduce
        public static int SumAll(int[] arr)
        {
            // return (from num in arr select num).Sum();   // query syntax
            // return arr.Sum();                            // Fluent
            // return arr.Count();
            // return arr.Max();
            return arr.Min();
        }

        public static double Average(int[] arr)
        {
            return arr.Average();
        }

        public static int[] SortDescending(int[] arr)
        {
            return [.. from num in arr orderby num descending select num];
        }

        public static int[] SortAscending(int[] arr)
        {
            return [.. from num in arr orderby num ascending select num];
        }

        public static int[] ReverseArray(int[] arr)
        {
            return [.. (from num in arr select num).Reverse()];
        }

        public static int[] DistinctArray(int[] arr)
        {
            return [.. (from num in arr select num).Distinct()];
        }

        public static bool AllGt(int[] arr, int num)
        {
            return arr.All(n => n > num);
        }
    }
}
