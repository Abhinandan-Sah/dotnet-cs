// using Person = Do_Select_Test.Person;

using System.Net.Sockets;
using System.Security.Cryptography;

namespace Do_Select_Test
{
    public class Program
    {
        public static void Main()
        {
            IList<Person> p = new List<Person>();
            p.Add(new Person{Name="Aarya", Address="A2101", Age=69});
            p.Add(new Person{Name="Avi", Address="A205", Age=45});
            

        }
    }
}