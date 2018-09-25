namespace Simcorp.IMS.Phone.SimCard {
    public class RealSimCard : BaseSimCard {
        public RealSimCard(SimCardTypes sctype) : base(sctype) { }

        public override void Identify()
        {
            ///Some code to identify subscriber
        }

        public override string ToString() {
            return "Standard Sim Card";
        }
    }
}
