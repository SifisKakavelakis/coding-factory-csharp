namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<char> dll = new();
            ListNode<char>? node;

            string filePath = @"C:\tmp\file.txt";
            int ordinal;
            char ch;
            int totalChars = 0;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}");
                    return;
                }
                using StreamReader reader = new(filePath);

                while ((ordinal = reader.Read()) != -1)
                {
                    ch = (char)ordinal;
                    if (ch is '\r' or '\n') continue;

                    node = dll.FindNode(ch);
                    if (node is null)
                    {
                        dll.InsertLast(ch);
                    }
                    else
                    {
                        dll.IncreaseCount(ch);
                    }
                    totalChars++;
                }
                dll.SortByCount();
                dll.Traverse(totalChars);
            } 
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
