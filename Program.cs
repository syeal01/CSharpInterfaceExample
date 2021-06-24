
using System;

namespace CSharpInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var ClassObject = new ExampleClass();
            Console.WriteLine($"{ClassObject.IExampleInterface0Method()}"); 
            Console.WriteLine($"{ClassObject.IExampleInterface1Method()}");
            Console.WriteLine($"{ClassObject.IExampleInterface2Method()}");
        }
    }

    interface IExampleInterface0
    {
        string IExampleInterface0Method();
    }
    
    interface IExampleInterface1
    {
        string IExampleInterface1Method();
    }
    // Multiple inheritance with comma separated
    interface IExampleInterface2 : IExampleInterface1, IExampleInterface0
    {
        string IExampleInterface2Method();
    }

    /* An interface is a completely "abstract class"
     * Our Class will inherit from Interface and all
     * Interface methods can be accessed
     */
    class ExampleClass : IExampleInterface2
    {
        public string IExampleInterface0Method()
        {
            return "IExampleInterface0Method";
        }
        public string IExampleInterface1Method()
        {
            return "IExampleInterface1Method";
        }

        public string IExampleInterface2Method()
        {
            return "IExampleInterface2Method";
        }
    }
}
