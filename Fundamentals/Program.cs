namespace Fundamentals
{
    internal class Program
    {
        static int PrintSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;

        }
        //<summary>
        // method<c>GetPositive</c> takes array as param and returns list of positive
        //</summary>
        static List<int> GetPositive(int[] arr, out int countNonPositive)
        {
            countNonPositive = 0;
            List<int> result = new List<int>();
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    result.Add(item);
                }
                else
                {
                    countNonPositive++;
                }
            }
            return result;
        }

        static void PrintName(string? name)
        {
            Console.WriteLine(name);
            Console.WriteLine(name?.Length);
        }
        static void Main(string[] args)
        {
            //string? name = Console.ReadLine();

            //PrintName(name);



            //int[] arr = { 2, 3, 4, 5, 6 };



            //Console.WriteLine(arr[^2]);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"item {arr[i]} ");
            //}

            //int[,] arr2 = { { 2, 3, 4 }, { 1, 4, 1 } };
            //int rows = arr2.GetLength(0);
            //int cols = arr2.GetLength(1);
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}



            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);


            int[] a = { 10, 11, -12, 13, 14, -15, 16, -17, 18, 19, 20, 21 };
            nums.AddRange(a);
            //foreach (var item in nums)
            //{
            //    Console.Write($"Item = {item} ");
            //}
            Console.WriteLine();

            int countNonPositive;
            List<int> positiveInts = GetPositive(a, out countNonPositive);
            foreach (var item in positiveInts)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine(countNonPositive + " ");


            Console.Read();
        }
    }
}
