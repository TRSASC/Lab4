using System;
using System.Collections.Generic;
using System.Linq;

namespace Simcorp.IMS.Phone {
    public class MsgStorage {
        public delegate void MsgAddedDelegate(SMSMessage message);
        public event MsgAddedDelegate MsgAdded;
        public delegate void MsgRemovedDelegate(SMSMessage message);
        public event MsgRemovedDelegate MsgRemoved;

        public List<SMSMessage> MsgList { get; set; }

        public MsgStorage() {
            MsgList = new List<SMSMessage>();
        }

        public MsgStorage(List<SMSMessage> msgList) {
            MsgList = msgList;
        }

        public void Add(SMSMessage message) {
            MsgList.Add(message);
            MsgAdded(message);
        }

        public void Remove (SMSMessage message){
            MsgList.Remove(message);
            MsgRemoved(message);
        }

        public static List<SMSMessage> RetrieveMessages(List<SMSMessage> msgList, string sender, string searchText, DateTime fromDate, DateTime toDate, bool andcond) {
            IEnumerable<SMSMessage> query = msgList.
                                            Select(m => m);
            if (andcond) {
                query = query.Where(m => m.Text.ToLower().Contains(searchText.ToLower()) && (fromDate <= m.ReceivingTime.Date && toDate >= m.ReceivingTime.Date));
            } else {
                query = query.Where(m => m.Text.ToLower().Contains(searchText.ToLower()) || (fromDate <= m.ReceivingTime.Date && toDate >= m.ReceivingTime.Date));
            }
            if (!String.IsNullOrEmpty(sender)) {
                query = query.Where(m => m.User == sender);
            }
            return query.ToList();
        }
    }
}
