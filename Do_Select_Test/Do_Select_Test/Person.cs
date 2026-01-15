using System;
using System.Collections.Generic;
using System.Text;

namespace Do_Select_Test
{
    public class Person
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
    }

    public class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            foreach(var p in person)
            {
                string s= s.Empty;
                s+= p.Name+","+p.Address + " ";
                return s;
            }
        }

        public double Average(IList<Person> person)
        {
            double result = 0;
            int cnt =0;
            foreach(var p in person)
            {
                result+=p.Age;
                cnt++;
            }
            return result/cnt;
        }

        public int Max(IList<Person> person)
        {
            int maxi =0; 
            foreach(var p in person)
            {
                if (p.Age > maxi)
                {
                    min=p.Age;
                }
            }
            return maxi;
        }
    }
}
