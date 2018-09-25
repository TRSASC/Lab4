using System;

namespace Simcorp.IMS.Phone.Battery {
    public abstract class BaseBattery : ICharge, IGiveCharge {
        private double vCapacity;
        private double vChargeLevel;

        public double Capacity {
            get {
                return vCapacity;
            }
            private set {
                if (value <= 0) {throw new ArgumentOutOfRangeException("Battery capacity must be positive"); }
                vCapacity = value;
            }
        }

        public double ChargeLevel {
            get {
                return (int)vChargeLevel;
            }
            protected set {
                if (value < 0){
                    value = 0;
                }
                if (value > 100){
                    value = 100;
                }
                vChargeLevel = value;
            }
        }

        public BaseBattery(double vol){
            Capacity = vol;
        }

        public abstract void Charge(double energy);

        public void GiveCharge(double energy) {
            if (this.ChargeLevel - energy < 0) {
               
                ChargeLevel -= energy;
            }
            else {
                Console.WriteLine("Battery discharged");
            }
        }
    }
}