using System.Collections.Generic;

namespace Simcorp.IMS.Phone.Keyboard
{
    public abstract class BaseKeyboard
    {
        private List<BaseButton> keys;
        public List<BaseButton> Keys
        {
            get { return keys; }
            set { keys = value; }
        }
    }
}
