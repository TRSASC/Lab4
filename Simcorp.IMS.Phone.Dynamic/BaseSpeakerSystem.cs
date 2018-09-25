using Simcorp.IMS.Phone.Output;

namespace Simcorp.IMS.Phone.Speaker
{
    public abstract class BaseSpeakerSystem : IPlay
    {
        private int vCurvolume;
        private BaseSpeaker vSpeaker1;

        protected IOutput Output { get; private set; }

        public virtual int CurVolume {
            get { return vCurvolume; }
            protected set {
                if (value > 100) { value = 100; }
                if (value < 0) { value = 0; }
                vCurvolume = value;
            }
        }

        public BaseSpeaker Speaker1 {
            get { return vSpeaker1; }
            set { vSpeaker1 = value; }
        }

        public BaseSpeakerSystem(BaseSpeaker speaker1, int curVolume, IOutput output){
            Speaker1 = speaker1;
            CurVolume = curVolume;
            Output = output;
        }

        public void SetVolume(bool volumeup) {
            int changevolume = volumeup ? 1 : -1;
            CurVolume += changevolume;
        }

        public abstract void Play(ISoundable sound);
    }
}
