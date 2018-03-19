using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string strn = "Um tab\t e um copyright\u03A9";
            string sv = @"C:\\Users\\Ana\\Documents\u+0194";

            Console.WriteLine(" " + strn + " ");
            Console.WriteLine(" " + sv + " " );


        }
    }
}
