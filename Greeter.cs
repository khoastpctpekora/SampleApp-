using System;

namespace TextLib
{
    // This class is compiled into TextLib.dll and used by SampleApp.exe
    public class Greeter
    {
        public string Greet(string name)
        {
            return "TextLib: Hello, " + name + "! Welcome to Software Deployment.";
        }
    }
}
