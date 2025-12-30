
namespace day7
{
    public class Program
    {
        public static void Main()
        {
            // System.Int32 i=10;
            // Code for day7_paraType_and_smpl_Quest can be added here.
            //     string? inp;
            //     Console.WriteLine("Enter input string of min 6 characters:");
            //     while(string.IsNullOrWhiteSpace(inp=Console.ReadLine()) || inp.Length<6 || inp.Any("@#$%^&*()123567890".Contains) || inp.Any(ch => !char.IsLetter(ch)))
            //     {
            //         Console.WriteLine("Invalid input. Enter valid input");
            //     }

            //     string lowConvert = string.Empty;
            //     foreach(var ch in inp)
            //     {
            //         lowConvert += char.ToLower(ch);
            //     }
            //     string? res = string.Empty;

            //     List<char> charArr = lowConvert.ToList();

            //     for(int i=0; i<charArr.Count; i++)
            //     {
            //         int asciiVal = (int)charArr[i];
            //         if ( asciiVal % 2 ==0)
            //         {
            //             charArr.RemoveAt(i);
            //             i--;
            //         }
            //     }

            //     charArr.Reverse();

            //     for(int i=0; i<charArr.Count; i++)
            //     {
            //         if(i%2 == 0)
            //         {
            //             charArr[i] = char.ToUpper(charArr[i]);
            //         }

            //     }




            //     foreach(var ch in charArr)
            //     {
            //         res +=ch;
            //     }

            //     Console.WriteLine(res);

            // }

            int[][] data = new int[3][];
            data[0] = new int[] { 1, 2, 3 };
            data[1] = new int[] { 10, 20 };
            data[2] = new int[] { 7, 8, 9, 10 };

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (var v in data[i]) Console.Write(v + " ");
                Console.WriteLine();
            }
        }
    }
}