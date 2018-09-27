using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simcorp.IMS.Phone;
using System.Collections.Generic;
using System.Linq;
using IPlayTest;

namespace FilterTest {
    [TestClass]
    public class AddRemove {
        private void OnMsgChanged(SMSMessage message)
        {
            ///dummy method that will be connected to event
        }

        /// <summary>
        /// Add method test of MsfStorage class
        /// </summary>
        [TestMethod]
        public void AddTest() {
            MsgStorage msgStor = new MsgStorage();
            msgStor.MsgAdded += OnMsgChanged;
            SMSMessage msg = new SMSMessage("trsa", "hello");
            List<SMSMessage> expList = new List<SMSMessage> { msg };

            msgStor.Add(msg);

            Assert.IsTrue(expList.SequenceEqual(msgStor.MsgList));
        }

        /// <summary>
        /// Remove method test of MsfStorage class
        /// </summary>
        [TestMethod]
        public void RemoveTest() {
            SMSMessage msg1 = new SMSMessage("trsa", "hello");
            SMSMessage msg2 = new SMSMessage("mksk", "pryvit");
            List<SMSMessage> expList = new List<SMSMessage> { msg1 };
            MsgStorage msgStor = new MsgStorage(new List<SMSMessage> { msg1, msg2 });
            msgStor.MsgRemoved += OnMsgChanged;

            msgStor.Remove(msg2);

            Assert.IsTrue(expList.SequenceEqual(msgStor.MsgList));
        }

        /// <summary>
        /// Test that verifying that messages are being added to Storage collection
        /// </summary>
        [TestMethod]
        public void FetchNewMsgTest() {
            SimCorpMobile simCorp = new SimCorpMobile(new FakeOutput());
            simCorp.MsgStor.MsgAdded += OnMsgChanged;
            int expLength = 1;

            simCorp.GenerateSMS();

            Assert.IsTrue(expLength == simCorp.MsgStor.MsgList.Count);
        }

    }
}
