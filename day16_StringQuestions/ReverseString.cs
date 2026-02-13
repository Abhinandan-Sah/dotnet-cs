// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        string str = Console.ReadLine();
        // string res = "";
        // for(int i=input.Length-1; i>=0; i--){
        //     res+=input[i];
        // }
        char[] input = str.ToCharArray();
        int s =0; 
        int e=input.Length-1;
        while(s<e){
            char temp = input[s];
            input[s]= input[e];
            input[e] = temp;
            s++;
            e--;
        }
        // string res = new string(input);
        string res = input.ToString(); //gives the type name
        Console.WriteLine(res);
    }
}