using System;
using System.Windows.Forms;

namespace AutoShutdown
{
    public partial class SettingForm : Form
    {
        public SettingForm(int notificationSetting)
        {
            InitializeComponent();
            if (notificationSetting == 1)
                byNotification.Checked = true;
            if (notificationSetting == 2)
                byMessageBox.Checked = true;
            if (notificationSetting == 3)
                byNothing.Checked = true;
        }

        private void saveOnExit_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm) this.Owner;
            if (byNotification.Checked == true)
                mainForm.changeNotificationSetting(1);
            if (byMessageBox.Checked == true)
                mainForm.changeNotificationSetting(2);
            if (byNothing.Checked == true)
                mainForm.changeNotificationSetting(3);
            Close();
        }
        private void exitWithoutChanges_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/DABRiXPERT/AutoShutdown");
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
