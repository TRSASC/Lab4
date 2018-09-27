using System;
using Simcorp.IMS.Phone;

namespace SMSPhone {
    public static class StringFormatter {
        public static string FormatNone(SMSMessage message) {
            return $"{message.Text}" + Environment.NewLine;
        }

        public static string FormatStartDateTime(SMSMessage message) {
            return $"[{message.ReceivingTime}] {message.Text}" + Environment.NewLine;
        }

        public static string FormatEndDateTime(SMSMessage message) {
            return $"{message.Text} [{message.ReceivingTime}]" + Environment.NewLine;
        }

        public static string FormatUpper(SMSMessage message) {
            return $"[{message.ReceivingTime}] {message.Text.ToUpper()}" + Environment.NewLine;
        }

        public static string FormatLower(SMSMessage message) {
            return $"[{message.ReceivingTime}] {message.Text.ToLower()}" + Environment.NewLine;
        }
    }
}
