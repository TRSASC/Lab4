using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.Phone;
using SMSPhone;

namespace FilterTest {
    public class SMSMessage1 : SMSMessage {
        public SMSMessage1(string user, string message) : base(user, message) { }
        protected override DateTime GetTime() { return new DateTime(2018, 9, 25); }
    }

    public class SMSMessage2 : SMSMessage {
        public SMSMessage2(string user, string message) : base(user, message) { }
        protected override DateTime GetTime() { return new DateTime(2018, 9, 26); }
    }

    public class SMSMessage3 : SMSMessage {
        public SMSMessage3(string user, string message) : base(user, message) { }
        protected override DateTime GetTime() { return new DateTime(2018, 9, 27); }
    }

    [TestClass]
    public class FilterTest {
        SMSMessage1 msg1 = new SMSMessage1("trsa", "hello");
        SMSMessage2 msg2 = new SMSMessage2("mksk", "pryvit");
        SMSMessage3 msg3 = new SMSMessage3("yrmn", "chao");

        [TestMethod]
        public void TestUserFilter() {
            List<SMSMessage> msgList = new List<SMSMessage>();
            List<SMSMessage> expMsgList = new List<SMSMessage>();
            msgList.Add(msg1);
            msgList.Add(msg2);
            msgList.Add(msg3);
            expMsgList.Add(msg1);

            List<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, "trsa", "", new DateTime(1900, 1, 1), new DateTime(2099, 9, 27), true);

            Assert.IsTrue(fltrdList.SequenceEqual(expMsgList));
        }

        [TestMethod]
        public void TestTextFilter() {
            List<SMSMessage> msgList = new List<SMSMessage>();
            List<SMSMessage> expMsgList = new List<SMSMessage>();
            msgList.Add(msg1);
            msgList.Add(msg2);
            msgList.Add(msg3);
            expMsgList.Add(msg2);

            List<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, String.Empty, "yvi", new DateTime(1900, 1, 1), new DateTime(2099, 9, 27), true);

            Assert.IsTrue(fltrdList.SequenceEqual(expMsgList));
        }

        [TestMethod]
        public void DateFilter() {
            List<SMSMessage> msgList = new List<SMSMessage>();
            List<SMSMessage> expMsgList = new List<SMSMessage>();
            msgList.Add(msg1);
            msgList.Add(msg2);
            msgList.Add(msg3);
            expMsgList.Add(msg3);
            

            List<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, String.Empty, "", new DateTime(2018, 9, 27), new DateTime(2018, 9, 27), true);

            Assert.IsTrue(fltrdList.SequenceEqual(expMsgList));
        }

        [TestMethod]
        public void DateAndMessageFilter() {
            List<SMSMessage> msgList = new List<SMSMessage>();
            List<SMSMessage> expMsgList = new List<SMSMessage>();
            msgList.Add(msg1);
            msgList.Add(msg2);
            msgList.Add(msg3);
            expMsgList.Add(msg1);

            List<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, String.Empty, "h", new DateTime(2018, 9, 25), new DateTime(2018, 9, 26), true);

            Assert.IsTrue(fltrdList.SequenceEqual(expMsgList));
        }

        [TestMethod]
        public void DateOrMessageFilter() {
            List<SMSMessage> msgList = new List<SMSMessage>();
            List<SMSMessage> expMsgList = new List<SMSMessage>();
            msgList.Add(msg1);
            msgList.Add(msg2);
            msgList.Add(msg3);
            expMsgList.Add(msg2);
            expMsgList.Add(msg3);

            List<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, String.Empty, "y", new DateTime(2018, 9, 27), new DateTime(2018, 9, 29), false);

            Assert.IsTrue(fltrdList.SequenceEqual(expMsgList));
        }
    }
}
