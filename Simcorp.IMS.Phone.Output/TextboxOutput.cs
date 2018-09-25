using System.Windows.Forms;

namespace Simcorp.IMS.Phone.Output {
    public class TextBoxOutput : IOutput {
        public TextBox TxtBox { get; set; }

        public TextBoxOutput(TextBox textBox) {
            TxtBox = textBox;
        }
        public void Write(string text) {
            TxtBox.AppendText(text);
        }
        public void WriteLine(string text) {
            TxtBox.AppendText(text);
        }
    }
}