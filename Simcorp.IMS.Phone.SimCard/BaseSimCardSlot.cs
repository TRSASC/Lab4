namespace Simcorp.IMS.Phone.SimCard {
    public abstract class BaseSimCardSlot {
        private SimCardTypes vSimCardType1;
        private BaseSimCard vSimCard1;

        public SimCardTypes SimCardType1 {
            get { return vSimCardType1; }
            set { vSimCardType1=value; }
        }

        public BaseSimCard SimCard1 {
            get { return vSimCard1; }
            set { vSimCard1 = value; }
        }

        public BaseSimCardSlot(SimCardTypes simCardType) {
            SimCardType1 = simCardType;
        }

        public abstract void GetSimCardInfo();
    }
}
