#region Word Wand - A Language Model
/*
Once upon a time, there was a language model named Word Wand who was trained to perform various tasks. One day, a curious user came to Word
Wand and asked it to do something special with the sentences. Word Wand was up for the challenge, and the user gave it the following sentences:
"I love you"
"Fresh Start"
Word Wand counted the number of words in both sentences and found that there were three words in the first and two words in the second. Since the
number of words was odd and even, Word Wand reversed euch word in the first sentence and the position of words in the second sentence, resulting
in the following:
"I evol uoy"
"Start Fresh"
The user was amazed by Word Wand's abilities. So, the user decided to create a software program that would perform this word manipulation task
automatically. Assist the user in carrying out the requirements.

Condition:
The sentence should contain only alphabets and space, else print "Invalid Sentence".
G
Note:
In the Sample Input/ Output provided, the highlighted text in bold corresponds to the input given by the user, and the rest of the text represents
the output.
Ensure to follow the object-oriented specifications provided in the question description.
Ensure to provide the names for classes, attributes, and methods as specified in the question description.
Adhere to the code template, if provided
Please do not use System.exit(0); to terminate the program.
Sample Input/Output 1
Enter the sentence
Bold action
Word Count: 2
action Bold
[Explanation: Since the number of words in a sentence is even, words are reversed.]

Sample Input / Output 1
Enter the sentence
Bold action
Word Count: 2
action Bold
[Explanation: Since the number of words in a sentence is even, words are reversed.]


Sample Input / Output 2
Enter the sentence
The Sun Shine
Word Count: 3
ehT nuS enihS
[Explanation: Since the number of words in a sentence is odd, the letters of each word are reversed.]

Sample Input/ Output 3
Enter the sentence
The number 42 is often referred to as the answer to life, the universe, and everything
Invalid Sentence
*/

namespace M1_Practice
{
    public class WordWand
    {
        public static bool CheckInvalidCharacter(string s)
        {
            if (string.IsNullOrEmpty)
            {
                return true;
            }

            bool hasDigit = s.Any(c => char.IsDigit(c));

            bool hasSymbol = s.Any(c => char.IsPunctuation(c) || char.IsSymbol(c));

            return hasDigit || hasSymbol;
        }
        public static void WordWandAnswer()
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();

            if (CheckInvalidCharacter(s))
            {
                Console.WriteLine("Invalid Sentence");
            }
            else
            {
                string[] words = s.Split(' '); // split into words
                // If even number of words: reverse word order; else reverse each word's chars
                if (words.Length % 2 == 0)
                {
                    System.Console.WriteLine(ReverseTheWords(words));
                }
                else
                {
                    System.Console.WriteLine(ReverseCharacters(words));
                }
            }



        }

        /// <summary>
        /// Reverse characters of each element in the input array.
        /// </summary>
        /// <param name="str">Array of words.</param>
        /// <returns>Concatenated string with each word's characters reversed.</returns>
        public static string ReverseCharacters(string[] str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                string toRev = str[i];
                res += EachCharReverse(toRev) + " "; // reverse and append
            }

            return res;
        }
        /// <summary>
        /// Reverse the characters of a single string.
        /// </summary>
        /// <param name="str">Input word.</param>
        /// <returns>Reversed word.</returns>
        public static string EachCharReverse(string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            string rev = new string(charArr);
            return rev;
        }

        /// <summary>
        /// Reverse the order of words in the array in-place and join them.
        /// </summary>
        /// <param name="str">Array of words.</param>
        /// <returns>Single string with words in reversed order.</returns>
        public static string ReverseTheWords(string[] str)
        {
            string res = "";
            int start = 0;
            int end = str.Length - 1;

            // Swap words in-place
            while (start < end)
            {
                string temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }

            // Join with spaces
            for (int i = 0; i < str.Length; i++)
            {
                res = res + str[i] + " ";
            }

            return res;
        }
    }
}

#endregion
