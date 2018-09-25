using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone.Speaker {
    public class MonauralSpeakerSystem : BaseSpeakerSystem, IPlay {
        public MonauralSpeakerSystem(BaseSpeaker speaker1, int curVolume, IOutput output) : base(speaker1, curVolume, output) { }

        public override void Play(ISoundable sound) {
            Output.WriteLine($"{nameof(MonauralSpeakerSystem)} sound");
            Speaker1.Play(sound);
        }
        
        public override string ToString() {
            return "Monaural speaker: " + this.Speaker1.ToString() + " Wt";
        }

    }
}
