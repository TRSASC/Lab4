using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone.Speaker {
    public class ExternalSpeaker : BaseSpeakerSystem, IPlay{
        public ExternalSpeaker(BaseSpeaker speaker1, int curVolume, IOutput output) : base(speaker1, curVolume, output) {
        }

        public override void Play(ISoundable sound) {
            Output.Write($"{nameof(ExternalSpeaker)} sound");
            Speaker1.Play(sound);
        }
    }
}
