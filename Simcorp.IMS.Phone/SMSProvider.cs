namespace Simcorp.IMS.Phone {
    internal class SMSProvider {
        public delegate void SMSReceivedDelegate(SMSMessage message);
        public event SMSReceivedDelegate SMSReceived;

        public void SendSMS(SMSMessage message) {
            RaiseSMSReseivedEvent(message);
        }

        private void RaiseSMSReseivedEvent(SMSMessage message){
            var handler = SMSReceived;
            if (handler != null) {
                handler(message);
            }
        }
    }
}
