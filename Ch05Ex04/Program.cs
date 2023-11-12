namespace Ch05Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Mary Chris", "Autry Rual" };

            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            foreach (string friendName in friendNames)
            {
                Console.WriteLine(friendName);
            }
            Console.ReadKey();
        }
    }
}