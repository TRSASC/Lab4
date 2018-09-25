using System;

namespace Simcorp.IMS.Phone.Battery {
    public class LiPolBattery : BaseBattery, ICharge, IGiveCharge {
        public LiPolBattery(double vol) : base(vol) {}

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
            return "Lithium polymer battery: " + this.Capacity + " mAh";
        }
    }
}
