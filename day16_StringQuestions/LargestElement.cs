// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for(int i=0; i<n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        int min = int.MinValue;
        foreach(var item in arr){
            if(item>min){
                min=item;
            }
        }
        
        Console.WriteLine("Answer is: "+min);
    }
}