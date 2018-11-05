using System;
using HelloLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class GreetingTest
    {
        [TestMethod]
        public void Speak_NoValue_PrintsDefaultGreeting()
        {
            var greet = new Greeting();

            var result = greet.Speak();

            Assert.IsTrue(result == "Hello World!");
        }

        [TestMethod]
        public void Speak_BlankString_PrintsDefaultGreeting()
        {
            var greet = new Greeting();

            var result = greet.Speak("");

            Assert.IsTrue(result == "Hello World!");
        }

        [TestMethod]
        public void Speak_ConstructorValue_PrintsValue()
        {
            var value = "Hello, World.";
            var greet = new Greeting(value);

            var result = greet.Speak();

            Assert.IsTrue(result == value);
        }

        [TestMethod]
        public void Speak_SetValueExplicitly_PrintsValue()
        {
            var greet = new Greeting();
            greet.Value = "Hello, World.";

            var result = greet.Speak();

            Assert.IsTrue(result == greet.Value);
        }

        [TestMethod]
        public void Speak_ParameterValue_PrintsValue()
        {
            var value = "Hello, World.";
            var greet = new Greeting();

            var result = greet.Speak(value);

            Assert.IsTrue(result == value);
        }
    }
}
