using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> codingLanguage = new Dictionary<string, int>();
            codingLanguage.Add("Java", 1);
            codingLanguage.Add("Javascript", 2);
            codingLanguage.Add("C#", 3);
            codingLanguage.Add("Python", 4);

            codingLanguage.ContainsKey("Java");
        }
    }
}
