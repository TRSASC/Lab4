namespace Simcorp.IMS.Phone.Speaker {
    public class Track : ISoundable {
        public double Bitrate { get; set; }

        public void GiveSound() {
            ///Some code that transfer sound to playback
        }
    }
}
