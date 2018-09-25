namespace Simcorp.IMS.Phone.SimCard {
    public class OneSimCardSlot :BaseSimCardSlot {
        public OneSimCardSlot(SimCardTypes simCardType1) : base(simCardType1) {}

        public override void GetSimCardInfo() {
            SimCard1.Identify();
        }

        public override string ToString()
        {
            return "Single SimCard with type " + SimCardType1.ToString();
        }
    }
}
