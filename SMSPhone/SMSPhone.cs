using System;
using System.Windows.Forms;
using Simcorp.IMS.Phone;
using Simcorp.IMS.Phone.Output;

namespace SMSPhone {

    public delegate string FormatDelegate(string message); 
    public partial class SMSPhone : Form {
        private SimCorpMobile simCorp;
        private FormatDelegate Formatter;
        private StringFormatter stringFormatter;

        public SMSPhone() {
            InitializeComponent();
            stringFormatter = new StringFormatter();
            Item defaultItem = new Item("None", stringFormatter.FormatNone);
            FormatComboBox.Items.Add(defaultItem);
            FormatComboBox.Items.Add(new Item("Start with DateTime", stringFormatter.FormatStartDateTime));
            FormatComboBox.Items.Add(new Item("End with DateTime", stringFormatter.FormatEndDateTime));
            FormatComboBox.Items.Add(new Item("Lowercase", stringFormatter.FormatLower));
            FormatComboBox.Items.Add(new Item("Uppercase", stringFormatter.FormatUpper));
            FormatComboBox.SelectedItem = defaultItem;
            simCorp = new SimCorpMobile(new TextBoxOutput(SMSTextBox));
            simCorp.SMSProvider.SMSReceived += OnSMSReceived;
        }

        private void SMSPhone_Load(object sender, EventArgs e) {
            Timer MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e) {  
            simCorp.SMSProvider.SendSMS("Message");
        }

        private void OnSMSReceived(string message) {
            string formattedMessage = Formatter(message);
            SMSTextBox.AppendText(formattedMessage);
        }

        private void FormatComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Item itm = (Item)FormatComboBox.SelectedItem;
            Formatter = itm.FormatDel;
        }

        private class Item {
            public string Name;
            public FormatDelegate FormatDel;
            public Item(string name, FormatDelegate formatDel) {
                Name = name;
                FormatDel = formatDel;
            }
            public override string ToString() {
                return Name;
            }
        }
    }
}
