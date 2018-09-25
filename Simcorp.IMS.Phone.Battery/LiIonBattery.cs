using System;

namespace Simcorp.IMS.Phone.Battery {
    public class LiIonBattery : BaseBattery, ICharge, IGiveCharge {
        public LiIonBattery(double vol) : base(vol){}

        public override void Charge(double energy) {
            if (this.ChargeLevel + energy < this.Capacity) {
                ///Some code to implement battery specific charging
                this.ChargeLevel += energy;
            }
            else {
                Console.WriteLine("Battery is charged");
            }
        }

        public override string ToString() {
            return "Lithium-ion battery: " + this.Capacity + " mAh";
        }
    }
}