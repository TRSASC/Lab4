namespace Simcorp.IMS.Phone {
    public class SMSProvider {
        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;

        public void SendSMS(string message) {
            RaiseSMSReseivedEvent(message);
        }

        private void RaiseSMSReseivedEvent(string message){
            var handler = SMSReceived;
            if (handler != null) {
                handler(message);
            }
        }
    }
}
