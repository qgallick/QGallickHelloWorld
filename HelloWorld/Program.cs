using HelloLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var hi = new Greeting();
            hi.Speak("Hello, World!");
            
            //pauses application so console can be viewed before completion
            Console.ReadKey();
        }
    }
}
