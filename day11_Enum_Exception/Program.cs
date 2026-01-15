using static day11_Enum_Exception.EnumExample;
using day11_Enum_Exception;

namespace day11_Enum
{
    public class Program
    {
        
    static void Main(string[] args)
{
            // 2D array using enum instead of string
            // Subjects[,] schedule = new Subjects[2, 4]
            // {

            //             { Subjects.OS, Subjects.CN, Subjects.OOPs, Subjects.DBMS },
            //             { Subjects.SE, Subjects.CloudComputing, Subjects.AI, Subjects.DS }
            // };

            // Printing the schedule
            // for (int i = 0; i < schedule.GetLength(0); i++)
            // {
            //     Console.WriteLine($"Semester {i + 1}:");

            //     for (int j = 0; j < schedule.GetLength(1); j++)
            //     {
            //         Console.WriteLine(
            //             $"Subject: {schedule[i, j]}  | Code: {(int)schedule[i, j]}"
            //         );
            //     }

            //     Console.WriteLine();
            // }


            //             var service = new OrderService();

            // Pass a method as callback
            //             service.PlaceOrder("ORD-101", SendEmail);

            // Pass another method as callback
            //             service.PlaceOrder("ORD-102", SendSms);

            try
            {
                int divisor = 0;
                int x = Divide(10,divisor);
                Console.WriteLine("Value of X: " +x);
            }
            catch(AppCustomException ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
            }
            


}
        static void SendEmail(string msg) => Console.WriteLine("EMAIL: " + msg);
        static void SendSms(string msg) => Console.WriteLine("SMS:   " + msg);

        public static int Divide(int a, int b){
            try{
                return a/b;
            }
            catch{
                throw new AppCustomException();
            }
        }

    }
}