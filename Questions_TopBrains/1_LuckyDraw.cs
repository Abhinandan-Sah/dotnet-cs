namespace Questions_TopBrains
{
    public class LuckyDraw
    {
        public static void LuckyDrawAnswer()
        {
            int m, n;

            do
            {
                Console.Write("Enter start range number: ");
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Invalid number. Enter a correct number");
                }

                Console.Write("Enter end range number: ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Invalid number. Enter a correct number");
                }

                if (m >= n)
                    Console.WriteLine("Start range should be less than end range.");
            }
            while (m >= n);

            int cnt = 0;
            int sqr = 0;
            for (int i = m; i <= n; i++)
            {
                if (i > 0 && !IsPrime(i))
                {
                    sqr = i * i;
                    int forI = NumSum(i);
                    int forSqr = NumSum(sqr);

                    if ((forI * forI) == forSqr)
                    {
                        cnt++;
                    }
                }
            }

            Console.WriteLine("The count of Lucky Draw numbers between the given range is: " + cnt);
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int NumSum(int n)
        {
            if (n == 0) return 0;
            int res = 0;
            while (n != 0)
            {
                int d = n % 10;
                res += d;
                n /= 10;
            }
            return res;
        }
    }
}