using Simcorp.IMS.Phone.Output;

namespace IPlayTest {
    public class FakeOutput : IOutput {
        public string Result { get; set; }

        public void Write(string text) {
            Result = text;
        }

        public void WriteLine(string text) {
            Result = text;
        }
    }
}
