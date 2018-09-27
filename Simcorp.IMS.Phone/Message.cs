using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.Phone {
    public class SMSMessage {
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }

        public SMSMessage(string user, string message) {
            User = user;
            Text = message;
            ReceivingTime = GetTime();
        }

        protected virtual DateTime GetTime() {
            return DateTime.Now;
        }
    }
}
