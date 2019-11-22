using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "I really need to <learn> this.";
            MyStringProcessor(testString);
        }
        private static void MyStringProcessor (string s)
        {
            int pFrom = s.IndexOf("<");
            int pTo = s.LastIndexOf(">");

            String result = s.Substring(pFrom + 1, pTo - pFrom -1);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
