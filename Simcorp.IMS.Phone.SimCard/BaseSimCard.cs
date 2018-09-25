using System;

namespace Simcorp.IMS.Phone.SimCard {
    public abstract class BaseSimCard {
        private string vNumber;
        private int vCapacity;
        private string vProvider;
        private SimCardTypes vSimCardType;

        public string Number {
            get { return vNumber; }
            set {
                if (value.Length>15) { throw new ArgumentOutOfRangeException("Specified number is too long."); }
                vNumber = value;
            }
        }

        public int Capacity {
            get { return vCapacity; }
            private set {
                if (value < 0) { throw new ArgumentOutOfRangeException("Sim Card capacity cannot be less then zero."); }
                vCapacity = value;
            }
        }

        public string Provider {
            get { return vProvider; }
            set { vProvider = value; }
        }

        public SimCardTypes SimCardType {
            get { return vSimCardType; }
            set { vSimCardType = value; }
        }

        public BaseSimCard(SimCardTypes sctype) {
            SimCardType = sctype;
        }

        public abstract void Identify();
    }
    
}
