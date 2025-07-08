namespace Assignments1._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] numArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //int result = 0;
            //foreach (int num in numArray)
            //{
            //    result += num;
            //}
            int result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result += i;
            }
            Console.WriteLine($"The sum of the first 10 natural numbers is: {result}");
            Console.Read();
        }
    }
}
