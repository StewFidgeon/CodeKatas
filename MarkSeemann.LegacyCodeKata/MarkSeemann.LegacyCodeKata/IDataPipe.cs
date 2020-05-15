using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public interface IDataPipe
    {
        public string Readline();
        public void WriteLine(string message);
    }
}
