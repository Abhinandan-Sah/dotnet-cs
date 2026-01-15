namespace day7.M1Practice_1
{

    public class M1Practice_1
    {
        // This class can contain methods or properties related to M1Practice_1.
        public void Question1()
        {
            string? inp;
            Console.WriteLine("Enter input string of min 6 characters:");
            while (string.IsNullOrWhiteSpace(inp = Console.ReadLine()) || inp.Length < 6 || inp.Any("@#$%^&*()123567890".Contains) || inp.Any(ch => !char.IsLetter(ch)))
            {
                Console.WriteLine("Invalid input. Enter valid input");
            }

            string lowConvert = string.Empty;
            foreach (var ch in inp)
            {
                lowConvert += char.ToLower(ch);
            }
            string? res = string.Empty;

            List<char> charArr = lowConvert.ToList();

            for (int i = 0; i < charArr.Count; i++)
            {
                int asciiVal = (int)charArr[i];
                if (asciiVal % 2 == 0)
                {
                    charArr.RemoveAt(i);
                    i--;
                }
            }

            charArr.Reverse();

            for (int i = 0; i < charArr.Count; i++)
            {
                if (i % 2 == 0)
                {
                    charArr[i] = char.ToUpper(charArr[i]);
                }

            }




            foreach (var ch in charArr)
            {
                res += ch;
            }

            Console.WriteLine(res);
        }
    }
}