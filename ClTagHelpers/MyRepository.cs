using System;
using System.Collections.Generic;
using System.Text;

namespace ClTagHelpers
{
    public class MyRepository : IMyRepository
    {
        public string GetStuff()
        {
            return "Here is the stuff.";
        }
    }
}
