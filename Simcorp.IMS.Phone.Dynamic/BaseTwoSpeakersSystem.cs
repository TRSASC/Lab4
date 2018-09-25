using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone.Speaker {
    public abstract class BaseTwoSpeakersSystem : BaseSpeakerSystem, IPlay {
        private BaseSpeaker vSpeaker2;

        public BaseSpeaker Speaker2 {
            get { return vSpeaker2; }
            set { vSpeaker2 = value; }
        }

        public BaseTwoSpeakersSystem(BaseSpeaker speaker1, BaseSpeaker speaker2, int curVolume, IOutput output) : base(speaker1, curVolume, output) { Speaker2 = speaker2; }

        public static ISoundable[] SplitSound(ISoundable sound) {
            ISoundable[] res = new ISoundable[2];
            res[0] = sound;    /// It is dummy spliting In reality it is differ
            res[1] = sound;    /// It is dummy spliting In reality it is differ
            return res;
        }
    }
}
