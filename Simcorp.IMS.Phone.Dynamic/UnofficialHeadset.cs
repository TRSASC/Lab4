using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone.Speaker {
    public class UnofficialHeadset : BaseTwoSpeakersSystem, IPlay {
        public UnofficialHeadset(BaseSpeaker speaker1, BaseSpeaker speaker2, int curVolume, IOutput output) : base(speaker1, speaker2, curVolume, output) {
        }

        public new int CurVolume {
            get { return CurVolume; }
            protected set  {
                if (value > 100) { value = 100; }
                if (value < 0) { value = 0; }
                CurVolume = value;
            }
        }

        public override void Play(ISoundable sound) {
            ///there is no sound splitting. It is just unofficial headset:)
            Output.WriteLine($"{nameof(UnofficialHeadset)} sound");
            Speaker1.Play(sound);
            Speaker2.Play(sound);
        }
    }
}
