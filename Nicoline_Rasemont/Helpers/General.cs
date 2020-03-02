using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Nicoline_Rasemont.Helpers
{
    public class General
    {
        public string[] ReadInput(string filepath)
        {
            string[] input = File.ReadAllLines(filepath);
            return input;
        }
    }
}
