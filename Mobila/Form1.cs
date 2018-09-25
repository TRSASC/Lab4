using System;
using System.Windows.Forms;
using Simcorp.IMS.Phone;
using Simcorp.IMS.Phone.Output;
using Simcorp.IMS.Phone.Speaker;

namespace Mobila {
    public partial class PhoneForm : Form {
        private BaseMobile simCorp;
        private IPlay unofficialHeadset;
        private IPlay samsungHeadset;
        private IPlay externalSpeaker;

        public PhoneForm() {
            InitializeComponent();
            simCorp = new SimCorpMobile(new TextBoxOutput(PlayTextBox));
            simCorp.PlaybackDevice = simCorp.Speaker;
            unofficialHeadset = new UnofficialHeadset(new RealSpeaker(0.2), new RealSpeaker(0.2), 50, new TextBoxOutput(PlayTextBox));
            samsungHeadset = new SamsungHeadset(new RealSpeaker(0.5), new RealSpeaker(0.5), 20, new TextBoxOutput(PlayTextBox));
            externalSpeaker = new ExternalSpeaker(new RealSpeaker(10), 20, new TextBoxOutput(PlayTextBox));
        }

        private void Speaker_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = simCorp.Speaker;
            if (!Speaker.Checked) { return; }
            simCorp.PlaybackDeviceName = simCorp.SpeakerName;
            PlayTextBox.AppendText(SelectionMsg(simCorp));
        }

        private void UnoffHeadset_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = unofficialHeadset;
            if (!UnoffHeadset.Checked) { return; }
            simCorp.PlaybackDeviceName = $"{nameof(UnofficialHeadset)}";
            PlayTextBox.AppendText(SelectionMsg(simCorp));
        }

        private void SamsHeadset_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = samsungHeadset;
            if (!SamsHeadset.Checked) { return; }
            simCorp.PlaybackDeviceName = $"{nameof(SamsungHeadset)}";
            PlayTextBox.AppendText(SelectionMsg(simCorp));
        }

        private void ExtSpeaker_CheckedChanged(object sender, EventArgs e) {
            simCorp.PlaybackDevice = externalSpeaker;
            if (!ExtSpeaker.Checked) { return; }
            simCorp.PlaybackDeviceName = $"{nameof(ExternalSpeaker)}";
            PlayTextBox.AppendText(SelectionMsg(simCorp));
        }

        private void buttonPlay_Click(object sender, EventArgs e) {
            PlayTextBox.AppendText("Set playback to Mobile" + Environment.NewLine);
            simCorp.Play(new Track());
        }

        private static string SelectionMsg(BaseMobile mobile) {
            return mobile.PlaybackDeviceName + " playback selected" + Environment.NewLine;
        }
    }
}