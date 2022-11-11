using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exprecionesRegulares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testString = "Oscary Basurto, 42 años";
            Regex regex = new Regex(@"^([^,]+),\s([0-9]+)");
            Match match = regex.Match(testString);
            if (match.Success)
                Console.WriteLine("Name: " + match.Groups[1].Value + ". Age: " + match.Groups[2].Value);
            Console.ReadKey();
        }
    }
}
