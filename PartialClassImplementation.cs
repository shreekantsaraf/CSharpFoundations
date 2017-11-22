using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFoundations
{
    class PartialClassImplementation
    {
    }

    public partial class child : parent
    {
        partial void VirtualMethod() { Console.WriteLine("from PartialClassImplementation.cs --  public partial class child : parent"); }

    }

}
