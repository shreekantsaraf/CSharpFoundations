using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFoundations
{
    interface IMammal
    {
        void Eat();
    }
    interface IStrippedObjects
    {
        int getGlitters();
    }
    public partial class Zebra : IMammal, IStrippedObjects
    {
        public void Eat()
        {
            Console.WriteLine("in main public IMammal.Eat()");
        }
    }

    public partial class Zebra 
    {
        public int getGlitters()
        {
            Console.WriteLine("in partial public int IStrippedObjects.getGlitters()");
            return 1;
        }
    }
}
