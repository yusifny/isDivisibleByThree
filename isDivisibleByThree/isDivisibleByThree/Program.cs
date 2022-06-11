using static System.Console;

namespace isDivisibleByThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 30, 33, 45, 13 };
            int sum = 0;
            foreach (var num in arr)
            {
                if (num%3==0)
                {
                    sum += num;
                }
            }
            WriteLine(sum);
        }
    }
}
