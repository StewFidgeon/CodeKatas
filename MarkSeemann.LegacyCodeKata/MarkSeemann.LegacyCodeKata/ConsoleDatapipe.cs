using System;

namespace MarkSeemann.LegacyCodeKata
{
    class ConsoleDatapipe : IDataPipe
    {
        public string Readline()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
