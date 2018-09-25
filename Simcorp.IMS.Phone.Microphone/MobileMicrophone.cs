namespace Simcorp.IMS.Phone.Microphone {
    public class MobileMicrophone : BaseMicrophone, IFetchSound {
        public override void FetchSound(ISound sound) {
            ///code that fetch sound
        }

        public override string ToString() {
            return "Simple microphone";
        }
    }
}
