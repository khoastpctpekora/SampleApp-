using MathLib;
using Newtonsoft.Json;
using System;
using TextLib;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SWE40006 - Deployment Portfolio Task 1");
            Console.WriteLine("Nho Anh Khoa Nguyen - 105312661");
            Console.WriteLine("--------------------------------------");

            // Dependency 1: MathLib.dll (custom class library)
            var calc = new Calculator();
            Console.WriteLine("MathLib:  12 + 30 = " + calc.Add(12, 30));
            Console.WriteLine("MathLib:  6 x 7   = " + calc.Multiply(6, 7));

            // Dependency 2: TextLib.dll (custom class library)
            var greeter = new Greeter();
            Console.WriteLine(greeter.Greet("Khoa"));

            // Dependency 3: Newtonsoft.Json.dll (third-party NuGet DLL)
            var info = new
            {
                App = "SampleApp",
                Version = "1.0.0",
                Dependencies = new[] { "MathLib.dll", "TextLib.dll", "Newtonsoft.Json.dll" }
            };
            string json = JsonConvert.SerializeObject(info, Formatting.Indented);
            Console.WriteLine("Newtonsoft.Json output:");
            Console.WriteLine(json);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Deployment Task completed! Press any key to exit...");
            Console.ReadKey();
        }
    }
}
