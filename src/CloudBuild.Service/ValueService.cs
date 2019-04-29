using System;
using System.Collections;
using System.Collections.Generic;

namespace CloudBuild.Service
{
    public class ValueService
    {
        public IEnumerable<string> GetValues()
        {
            return new List<string>() { "Value1", "Value2" };
        }
    }
}
