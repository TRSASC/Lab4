using System;

namespace SMSPhone {
    public class StringFormatter {
        public string FormatNone(string message) {
            return $"{message}" + Environment.NewLine;
        }

        public string FormatStartDateTime(string message) {
            return $"[{GetTime()}] {message}" + Environment.NewLine;
        }

        public string FormatEndDateTime(string message) {
            return $"{message} [{GetTime()}]" + Environment.NewLine;
        }

        public string FormatUpper(string message) {
            return $"[{GetTime()}] {message.ToUpper()}" + Environment.NewLine;
        }

        public string FormatLower(string message) {
            return $"[{GetTime()}] {message.ToLower()}" + Environment.NewLine;
        }

        protected virtual string GetTime() {
            return $"{DateTime.Now}";
        }
    }
}
