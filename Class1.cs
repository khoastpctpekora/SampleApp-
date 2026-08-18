using System;

namespace MathLib
{
    // This class is compiled into MathLib.dll and used by SampleApp.exe
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
