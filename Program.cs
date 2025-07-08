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
            // Testing commit message. 
            Console.WriteLine("Please enter a positive value for n!");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("The first 10 natural numbers is: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                result += i;
            }
            Console.WriteLine($"The sum of the first 10 natural numbers is: {result}");
            Console.Read();
        }
    }
}
