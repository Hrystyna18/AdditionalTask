using System;
using System.Collections.Generic;
using System.Text;

namespace AdditionalTask
{
    interface ITriangle
    {
        int FirstParty { get; }
        int SecondParty { get; }
        int Corner { get; }

        double Area();
        double Perimeter();
    }
}
