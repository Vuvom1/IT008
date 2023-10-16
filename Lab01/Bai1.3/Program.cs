namespace Bai1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 5, 3 };
            Console.WriteLine(MaxInt(number));
        }
        static int MaxInt(int[] numbers)
        {
            int max = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i) max = i;
            }
            return max;
        }
        static double MaxDou(double[] numbers)
        {
            double max = numbers[0];
            foreach (double i in numbers)
            {
                if (max < i) max = i;
            }
            return max;
        }
        static string MaxString(string[] line)
        {
            string res = line[0];
            foreach (string s in line)
            {
                if (s.Length > res.Length) res = s;
            }
            return res;
        }
        static int MinInt(int[] numbers)
        {
            int min = numbers[0];
            foreach (int i in numbers)
            {
                if (min > i) min = i;
            }
            return min;
        }
        static double MinDou(double[] numbers)
        {
            double min = numbers[0];
            foreach (double i in numbers)
            {
                if (min > i) min = i;
            }
            return min;
        }
        static string MinString(string[] line)
        {
            string res = line[0];
            foreach (string s in line)
            {
                if (s.Length < res.Length) res = s;
            }
            return res;
        }
    }
}