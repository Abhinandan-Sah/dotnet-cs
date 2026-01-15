using System.Xml.Serialization;
using System;
using System.Collections;
namespace day8_OOPS_session4
{
public class Program
{

    public static void Main(string[] args)
    {
        # region XMLSerialization
        XMLSerializer student = new XMLSerializer();
        student.id = 101;
        student.Name = "Avi";
        student.Marks = new List<int>(){95,87,92};
        student.arrayLists = new ArrayList{"First", 1, 2};

        XmlSerializer serializer = new XmlSerializer(typeof(XMLSerializer));


        serializer.Serialize(Console.Out, student);
        #endregion
    }
}


}
// namespace day8_OOPS_session4
// {
//     public class Checker
//     {
//         public int ID { get; set; }
//         public string? name { get; set; }
//         public string Display()
//         {
//             return $"Name is {name}";
//         }

//         public int Add(int a, int b)
//         {
//             return a + b;
//         }
//     }

//     public class Program
//     {
//     static void Main(string[] args)
//     {
//         Checker checker = new Checker();
//         checker.ID = 20;
//         checker.name = "dd";

//         Console.WriteLine(checker.Display());
//         System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(checker.GetType());
//         x.Serialize(Console.Out, checker);
//         Console.WriteLine();
//         Console.ReadLine();

//     }
// }
// }

