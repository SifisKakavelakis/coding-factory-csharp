using System.Text;

namespace ExtractCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Extract capital letters from a string
        public static string ExtractCapitals(string input)
        {
            StringBuilder capitals = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    capitals.Append(c);
                }
            }
            return capitals.ToString();
        }
    }
}
