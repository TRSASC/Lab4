using System;
using System.Windows.Forms;

namespace Simcorp.IMS.Phone.Output {
    public class ListViewOutput : IOutput {
        public ListView LstView { get; set; }

        public ListViewOutput(ListView lstView) {
            LstView = lstView;
        }

        public void Write(string text) {
            LstView.Items.Add(text);
        }

        public void WriteLine(string text) {
            LstView.Items.Add(text);
        }
    }
}