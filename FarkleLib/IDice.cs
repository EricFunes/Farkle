using System;
using System.Collections.Generic;
using System.Text;

namespace FarkleLib
{
    public interface IDice
    {
        int Value { get; set; }
        string ToString();
    }
}
