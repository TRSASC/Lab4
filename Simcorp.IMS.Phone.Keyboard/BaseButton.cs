namespace Simcorp.IMS.Phone.Keyboard {
    abstract public class BaseButton {
        protected string desc;

        abstract public void Action();

        public override string ToString() {
            return desc;
        }
    }
}
