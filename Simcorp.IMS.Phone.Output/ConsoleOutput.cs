using System;

namespace Simcorp.IMS.Phone.Output {
    public class ConsoleOutput : IOutput{
        public void Write (string text) {
            Console.Write(text);
        }
        public void WriteLine(string text) {
            Console.WriteLine(text);
        }
    }
}
