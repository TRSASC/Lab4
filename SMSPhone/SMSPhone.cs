using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Simcorp.IMS.Phone;
using Simcorp.IMS.Phone.Output;

namespace SMSPhone {

    public delegate string FormatDelegate(SMSMessage message); 
    public partial class SMSPhone : Form {
        private SimCorpMobile simCorp;
        private FormatDelegate Formatter;
        private string Sender;
        private MsgStorage MsgData=new MsgStorage();
        private string allSenderItem = "All";

        public SMSPhone() {
            simCorp = new SimCorpMobile(new ListViewOutput(MessageListView));
            simCorp.MsgStor.MsgAdded += OnMsgAdded;
            simCorp.MsgStor.MsgRemoved += OnMsgRemoved;

            InitializeComponent();
            FormatItem defaultItem = new FormatItem("None", StringFormatter.FormatNone);
            FormatComboBox.Items.Add(defaultItem);
            FormatComboBox.Items.Add(new FormatItem("Start with DateTime", StringFormatter.FormatStartDateTime));
            FormatComboBox.Items.Add(new FormatItem("End with DateTime", StringFormatter.FormatEndDateTime));
            FormatComboBox.Items.Add(new FormatItem("Lowercase", StringFormatter.FormatLower));
            FormatComboBox.Items.Add(new FormatItem("Uppercase", StringFormatter.FormatUpper));
            FormatComboBox.SelectedItem = defaultItem;

            SenderComboBox.Items.Add(allSenderItem);
            SenderComboBox.SelectedItem = allSenderItem;

            OrAndCheckBox.Checked = true;
        }

        private void SMSPhone_Load(object sender, EventArgs e) {
            Timer MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e) {
            simCorp.GenerateSMS();
        }

        private void OnMsgAdded(SMSMessage message) {
            if (!SenderComboBox.Items.Contains(message.User)) {
                SenderComboBox.Items.Add(message.User);
            }
            DisplayMessages(new List<SMSMessage> { message });
        }
        private void OnMsgRemoved(SMSMessage message) {
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void FormatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            FormatItem itm = (FormatItem)FormatComboBox.SelectedItem;
            Formatter = itm.FormatDel;
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void SenderComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Sender = SenderComboBox.SelectedItem.ToString();
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e) {
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void FromDatePicker_ValueChanged(object sender, EventArgs e) {
            if (FromDatePicker.Value.Date > ToDatePicker.Value.Date) {
                ToDatePicker.Value = FromDatePicker.Value;
            }
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void ToDatePicker_ValueChanged(object sender, EventArgs e) {
            if (FromDatePicker.Value.Date > ToDatePicker.Value.Date) {
                    FromDatePicker.Value = ToDatePicker.Value;
            }
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void OrAndCheckBox_CheckedChanged(object sender, EventArgs e) {
            DisplayAll(simCorp.MsgStor.MsgList);
        }

        private void DisplayAll(List<SMSMessage> msgList) {
            MessageListView.Items.Clear();
            DisplayMessages(msgList);
        }

        private void DisplayMessages(List<SMSMessage> msgList) {
            string searchText = SearchTextBox.Text.ToString();
            DateTime fromDate = FromDatePicker.Value.Date;
            DateTime toDate = ToDatePicker.Value.Date;
            bool andcond = OrAndCheckBox.Checked;
            string fltrSender = (Sender == allSenderItem) ? String.Empty : Sender;

            IEnumerable<SMSMessage> fltrdList = MsgStorage.RetrieveMessages(msgList, fltrSender, searchText, fromDate, toDate, andcond);

            foreach (var message in fltrdList) {
                ShowMessage(message);
            }
        }

        private void ShowMessage(SMSMessage message) {
            string formattedMessage = Formatter(message);
            MessageListView.Items.Add(new ListViewItem(new[] { message.User, formattedMessage }));
        }

        private class FormatItem {
            public string Name;
            public FormatDelegate FormatDel;
            public FormatItem(string name, FormatDelegate formatDel) {
                Name = name;
                FormatDel = formatDel;
            }
            public override string ToString() {
                return Name;
            }
        }
    }
}
