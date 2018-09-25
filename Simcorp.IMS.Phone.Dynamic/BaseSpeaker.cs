namespace Simcorp.IMS.Phone.Speaker {
    public abstract class BaseSpeaker {
        private double vPower;

        public double Power { get; protected set; }

        public BaseSpeaker(double maxpower) {
            Power = maxpower;
        }
        
        public abstract void Play(ISoundable sound);
    }
}