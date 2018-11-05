using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloLibrary
{
    public class Greeting
    {
        public Greeting() { }

        //constructor overload to allow storing speak value on instantiation
        public Greeting(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        //standard Speak uses Value stored in Greeting object
        public string Speak()
        {
            Value = Validate(Value);

            Console.WriteLine(Value);

            return Value;
        }

        //overloaded Speak uses parameter value
        public string Speak(string hello)
        {
            hello = Validate(hello);

            Console.WriteLine(hello);

            return hello;
        }

        //ensures if we try to speak with no value, uses default of Hello World
        private string Validate(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                value = "Hello World!";
            }

            return value;
        }
    }
}
