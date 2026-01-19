using System.Security.Cryptography.X509Certificates;

namespace Questions_TopBrains
{
    public class Swapping
    {
        public static void SwappingMethod()
        {
            int a, b;
            Console.Write("Enter number a: ");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Invalid number. Enter a correct number");
                }

                Console.Write("Enter number b: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Invalid number. Enter a correct number");
                }

                Console.WriteLine($"Orginal value is a = {a} and b={b}");
                SwappingByRef(ref a, ref b);
                Console.WriteLine($"After Swapping by Ref is a = {a} and b={b}");

                SwappingByOut(a, b, out a, out b);
                Console.WriteLine($"After Swapping by Out is a = {a} and b={b}");
        }

        public static void SwappingByRef(ref int a, ref int b)
        {
            a=a+b;
            b=a-b;
            a=a-b;
        }
        public static void SwappingByOut(int a, int b, out int x, out int y)
        {
            x=b;
            y=a;
        }
    }
}