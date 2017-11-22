using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFoundations
{
    class ClassToDemoProps
    {
        public int Amount { get; set; }
        public int DoubleTheAmount()
        {
            return Amount * 2;
        }
    }
    public static class Converter
    {
        public static double FarennheightToCelsius(double Farennheight)
        {
            double dblRet = (Farennheight - 32)*5/9;
            return dblRet;
        }
        public static double CelsiusToFarennheight(double Celsius)
        {
            double dblRet = (Celsius * 9 / 5) + 32;
            return dblRet;
        }
    }

    public abstract partial class parent
    {
        public abstract void abstractMethod();
        public virtual string name => "parent";
    }

    public partial class child : parent
    {
        partial void VirtualMethod();
        public void CallVirtualMethod() { VirtualMethod(); }
        string str = "child abstractMethod()";
        public override void abstractMethod() => Console.WriteLine($"{str}");
        
        public override  string name =>  "child";
    }
}
