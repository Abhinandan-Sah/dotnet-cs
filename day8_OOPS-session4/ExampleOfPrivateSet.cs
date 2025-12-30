using System;
using System.Collections.Generic;
using System.Text;

namespace day8_OOPS_session4
{
    public class YoungProfessional
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Company { get; set; }
        public string? PersonalId { get; private set; }

        public YoungProfessional(string name, int age, string company)
        {
            this.Name = name;
            this.Age = age;
            this.Company = company;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Company: {Company}");
        }
    }
}
