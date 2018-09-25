using System.Collections.Generic;

namespace Simcorp.IMS.Phone.SimCard {
    public class DualSimCardSlot : BaseSimCardSlot {
        private SimCardTypes vSimCardType2;
        private BaseSimCard vSimCard2;

        public SimCardTypes SimCardType2 {
            get { return vSimCardType2; }
            set { vSimCardType2 = value; }
        }

        public BaseSimCard SimCard2 {
            get { return vSimCard2; }
            set { vSimCard2 = value; }
        }

        public DualSimCardSlot(SimCardTypes simCardType1, SimCardTypes simCardType2) : base(simCardType1) {
            SimCardType2 = simCardType2;
        }

        public override void GetSimCardInfo() {
            SimCard1.Identify();
            SimCard2.Identify();
        }

        public override string ToString() {
            return "Dual SimCard with types " + SimCardType1.ToString() + " and " + SimCardType2.ToString();
        }
    }
}
