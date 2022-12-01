using OcTestCSharp.Core.Service.InputOutput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Test.Core.Stubs
{
    public class ConsoleOutput : IOutput
    {
        public StringBuilder StringBuilder = new();

        public void Write(string message)
        {
            StringBuilder.Append(message);
        }

        public void WriteLine(string message)
        {
            StringBuilder.AppendLine(message);
        }
    }
}