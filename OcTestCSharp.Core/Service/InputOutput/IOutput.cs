using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Service.InputOutput
{
    public interface IOutput
    {
        void Write(string message);
        void WriteLine(string message);
    }
}
