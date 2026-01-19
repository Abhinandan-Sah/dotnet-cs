namespace Questions_TopBrains
{
    public class MultiplicationTable
    {
        public static void MultiplicationTableAnswer()
        {
            int n, upto;


            Console.Write("Enter n: ");
            while (!int.TryParse((Console.ReadLine()), out n) || n < 0)
            {
                Console.WriteLine("Invalid number. Enter a correct number");
            }
            Console.Write("Enter upto: ");
            while (!int.TryParse((Console.ReadLine()), out upto) || upto < 0)
            {
                Console.WriteLine("Invalid number. Enter a correct number");
            }


            // Method 1 with array
            // int[] arr = new int[upto];

            // for(int i=1; i<=upto; i++)
            // {
            //     arr[i-1]=n*i;
            // }

            // Console.WriteLine($"Multiplication table of {n} upto {upto} are: ");
            // foreach(var num in arr){
            //     Console.Write(num+" ");
            // }

            // method2
            for (int i = 1; i <= upto; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }

}