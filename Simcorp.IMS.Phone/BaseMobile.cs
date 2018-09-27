using Simcorp.IMS.Phone.Battery;
using Simcorp.IMS.Phone.Speaker;
using Simcorp.IMS.Phone.Keyboard;
using Simcorp.IMS.Phone.Microphone;
using Simcorp.IMS.Phone.Screen;
using Simcorp.IMS.Phone.SimCard;
using System.Text;
using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone {
    public abstract class BaseMobile {
        public abstract string ModelName { get; }
        public abstract BaseBattery Battery { get; }
        public abstract BaseSpeakerSystem Speaker { get; }
        public abstract BaseKeyboard KeyBoard { get; }
        public abstract BaseMicrophone Microphone { get; }
        public abstract BaseScreen Screen { get; }
        public abstract BaseSimCardSlot SimCard { get; }
        public abstract string SpeakerName { get; }
        public abstract IPlay PlaybackDevice { get; set; }
        public abstract string PlaybackDeviceName { get; set; }
        public abstract IOutput Output { get; set; }
        internal SMSProvider SMSProvider { get; set; }
        public abstract MsgStorage MsgStor {get;}

        private void Show(IScreenable screenImage) {
            Screen.Show(screenImage);
        }

        private void FetchNetwork() {
            SimCard.GetSimCardInfo();
        }

        private void FetchSound(ISound sound) {
            Microphone.FetchSound(sound);
        }

        private void ReproduceSound(ISoundable sound) {
            Speaker.Play(sound);
        }

        private void Charge(double energy) {
            Battery.Charge(energy);
        }

        private void GiveCharge(double energy) {
            Battery.GiveCharge(energy);
        }

        public virtual string GetDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Model name: {ModelName}");
            descriptionBuilder.AppendLine($"{Battery.ToString()}");
            descriptionBuilder.AppendLine($"{Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard type : {KeyBoard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone : {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Sim card : {SimCard.ToString()}");
            descriptionBuilder.AppendLine($"{Screen.ToString()}");
            return descriptionBuilder.ToString();
        }

        public abstract void Play(ISoundable sound);
    }
}