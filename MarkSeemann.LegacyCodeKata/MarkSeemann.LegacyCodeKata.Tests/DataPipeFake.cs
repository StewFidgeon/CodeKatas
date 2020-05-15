using System.Collections.Generic;

namespace MarkSeemann.LegacyCodeKata.Tests
{
    class DataPipeFake : IDataPipe
    {
        private List<string> _fakeInputs;
        private int _counter = -1;

        public List<string> Outputs { get; } = new List<string>();

        public DataPipeFake(List<string> inputs)
        {
            _fakeInputs = inputs;
        }

        public string Readline()
        {
            _counter++;
            return _counter < _fakeInputs.Count ? _fakeInputs[_counter] : "";
        }

        public void WriteLine(string message)
        {
            Outputs.Add(message);
        }
    }
}
