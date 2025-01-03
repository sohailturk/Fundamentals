namespace Fundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isParseSuccessful;
            int val;
            do
            {
                var input = Console.ReadLine();
                isParseSuccessful = int.TryParse(input, out val);
            } while (!isParseSuccessful);


            Console.WriteLine("success " + val);
            Console.Read();
        }
    }
}
