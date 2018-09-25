namespace Simcorp.IMS.Phone.Speaker {
    public interface ISoundable {
        double Bitrate { get; set; }
        void GiveSound();
    }
}
