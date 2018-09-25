
namespace Simcorp.IMS.Phone.Speaker
{
    public class RealSpeaker : BaseSpeaker
    {
        public RealSpeaker(double maxpower) : base(maxpower) { }

        public override void Play(ISoundable sound) {
            ///Some code to reproduce sound
        }

        public override string ToString() {
            return Power.ToString();
        }
    }
}
