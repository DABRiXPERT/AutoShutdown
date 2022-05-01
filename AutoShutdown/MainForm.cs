using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace AutoShutdown
{
    public partial class MainForm : Form
    {
        public DateTime shutdownTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        public static int notificationSetting = 1;
        int duration_int, notify_stage;
        //public bool notificated = false;
        public MainForm()
        {
            /*
            string helloworld = "HELLO_WORLD_0123456789_TEST_ENGLISH_WORDS";
            Console.WriteLine(helloworld);
            char [] hellochar = helloworld.ToCharArray();
            for (int i = 0; i < hellochar.Length; i++)
                hellochar[i] += Convert.ToChar(65248);
            Console.WriteLine(hellochar);
            if (DateTime.Now > shutdownTime)
            {
                shutdownTime = shutdownTime.AddDays(1);
            }
            */
            InitializeComponent();
        }

        private void timerForDateTime_Tick(object sender, EventArgs e)
        {
            timeDisplay.Text = DateTime.Now.ToString("現在時間：yyyy年MM月dd日 HH時mm分ss秒。");
            //Console.WriteLine(DateTime.Now.ToString("現在時間：yyyy年MM月dd日 HH時mm分ss.fff秒。"));
        }

        private void timerForCountdown_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(shutdownTime.ToString());
            TimeSpan duration = shutdownTime.Subtract(DateTime.Now);
            //Console.WriteLine(duration.ToString("'距離關機還有：'hh'時'mm'分'ss'秒。'"));
            string duration_str = duration.ToString("hhmmss");
            char [] duration_char = duration_str.ToCharArray();
            for (int i = 0; i < duration_char.Length; i++)
                duration_char[i] += Convert.ToChar(65248);
            countdown.Text = "這部裝置將在　"+duration_char[0]+duration_char[1]+"時"+duration_char[2]+duration_char[3]+"分"+duration_char[4]+duration_char[5]+"秒　後關閉。";
            duration_int = Convert.ToInt32(duration.TotalSeconds);
            if (DateTime.Now > shutdownTime /*&& notificated == false*/)
            {
                //notificated = true;
                //DialogResult reply = MessageBox.Show("計時結束！", "時間到", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //if (reply == DialogResult.OK)
                //{  
                    //notificated = false;
                    shutdownTime = shutdownTime.AddDays(1);
                //}
            }



            if (notificationSetting == 1)
            {
                if (duration_int == 7200 && notify_stage == 0)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 2 小時後關機。")
                    .Show();
                }
                if (duration_int == 3600 && notify_stage == 1)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 1 小時後關機。")
                    .Show();
                }
                if (duration_int == 1800 && notify_stage == 2)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 30 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 900 && notify_stage == 3)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 15 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 600 && notify_stage == 4)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 10 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 300 && notify_stage == 5)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 5 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 240 && notify_stage == 6)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 4 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 180 && notify_stage == 7)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 3 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 120 && notify_stage == 8)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 2 分鐘後關機。")
                    .Show();
                }
                if (duration_int == 90 && notify_stage == 9)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 90 秒後關機。")
                    .Show();
                }
                if (duration_int == 60 && notify_stage == 10)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 60 秒後關機。")
                    .Show();
                }
                if (duration_int == 45 && notify_stage == 11)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 45 秒後關機。")
                    .Show();
                }
                if (duration_int == 30 && notify_stage == 12)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 30 秒後關機。")
                    .Show();
                }
                if (duration_int == 20 && notify_stage == 13)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 20 秒後關機。")
                    .Show();
                }
                if (duration_int == 10 && notify_stage == 14)
                {
                    notify_stage++;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 10 秒後關機。")
                    .Show();
                }
                if (duration_int == 5 && notify_stage == 15)
                {
                    notify_stage = 0;
                    new ToastContentBuilder()
                    .AddText("設備關機通知")
                    .AddText("這部裝置將在 5 秒後關機。")
                    .Show();
                }
            }
            if (notificationSetting == 2)
            {
                if (duration_int == 7200 && notify_stage == 0)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 2 小時後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 3600 && notify_stage == 1)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 1 小時後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 1800 && notify_stage == 2)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 30 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 900 && notify_stage == 3)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 15 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 600 && notify_stage == 4)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 10 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 300 && notify_stage == 5)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 5 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 240 && notify_stage == 6)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 4 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 180 && notify_stage == 7)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 3 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 120 && notify_stage == 8)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 2 分鐘後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 90 && notify_stage == 9)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 90 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 60 && notify_stage == 10)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 60 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 45 && notify_stage == 11)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 45 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (duration_int == 30 && notify_stage == 12)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 30 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (duration_int == 20 && notify_stage == 13)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 20 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (duration_int == 10 && notify_stage == 14)
                {
                    notify_stage++;
                    MessageBox.Show("這部裝置將在 10 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (duration_int == 5 && notify_stage == 15)
                {
                    notify_stage = 0;
                    MessageBox.Show("這部裝置將在 5 秒後關機。", "設備關機通知", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (notificationSetting == 3)
            {
                if (duration_int == 7200)
                    notify_stage = 1;
                if (duration_int == 3600)
                    notify_stage = 2;
                if (duration_int == 1800)
                    notify_stage = 3;
                if (duration_int == 900)
                    notify_stage = 4;
                if (duration_int == 600)
                    notify_stage = 5;
                if (duration_int == 300)
                    notify_stage = 6;
                if (duration_int == 240)
                    notify_stage = 7;
                if (duration_int == 180)
                    notify_stage = 8;
                if (duration_int == 120)
                    notify_stage = 9;
                if (duration_int == 90)
                    notify_stage = 10;
                if (duration_int == 60)
                    notify_stage = 11;
                if (duration_int == 45)
                    notify_stage = 12;
                if (duration_int == 30)
                    notify_stage = 13;
                if (duration_int == 20)
                    notify_stage = 14;
                if (duration_int == 10)
                    notify_stage = 15;
                if (duration_int == 5)
                    notify_stage = 0;
            }
            Console.WriteLine(notificationSetting + " " + duration_int + " " + notify_stage);
        }

        public void changeNotificationSetting(int result)
        {
            notificationSetting = result;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
            timerForCountdown.Enabled = true;
            shutdownTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            TimeSpan applyTime = new TimeSpan(timePicker.Value.Hour, timePicker.Value.Minute, 0);
            shutdownTime = shutdownTime.Date + applyTime;
            if (DateTime.Now > shutdownTime)
            {
                shutdownTime = shutdownTime.AddDays(1);
            }
            duration_int = Convert.ToInt32(shutdownTime.Subtract(DateTime.Now).TotalSeconds);
            if (duration_int >= 7200)
                notify_stage = 0;
            else if (duration_int >= 3600)
                notify_stage = 1;
            else if (duration_int >= 1800)
                notify_stage = 2;
            else if (duration_int >= 900)
                notify_stage = 3;
            else if (duration_int >= 600)
                notify_stage = 4;
            else if (duration_int >= 300)
                notify_stage = 5;
            else if (duration_int >= 240)
                notify_stage = 6;
            else if (duration_int >= 180)
                notify_stage = 7;
            else if (duration_int >= 120)
                notify_stage = 8;
            else if (duration_int >= 90)
                notify_stage = 9;
            else if (duration_int >= 60)
                notify_stage = 10;
            else if (duration_int >= 45)
                notify_stage = 11;
            else if (duration_int >= 30)
                notify_stage = 12;
            else if (duration_int >= 20)
                notify_stage = 13;
            else if (duration_int >= 10)
                notify_stage = 14;
            else if (duration_int >= 5)
                notify_stage = 15;
            else
                notify_stage = 0;

            Process.Start("shutdown", "/s /t " + duration_int);
            MessageBox.Show("已儲存設定！", "設定生效", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要取消設定嗎？", "撤銷設定", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("shutdown", "/a");
                timerForCountdown.Stop();
                timerForCountdown.Enabled = false;
                countdown.Text = "這部裝置將在　－－時－－分－－秒　後關閉。";
                MessageBox.Show("已撤銷原先設定！", "設定生效", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你確定要退出嗎？\n所有的設定將被撤銷！", "退出程式", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                if (timerForCountdown.Enabled)
                    Process.Start("shutdown", "/a");
                e.Cancel = true;
                
            }   
            /*
            if (WindowState == FormWindowState.Minimized)
            {
                e.Cancel = true;
                Hide();
                ShowInTaskbar = false;
                WindowState = FormWindowState.Minimized;
                notifyIcon.BalloonTipTitle = "繼續執行關機排程";
                notifyIcon.BalloonTipText = "繼續執行事先預訂的關機程序，\n如果要取消請按這個標誌";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(3000);
            }    
            */
        }

        private void notifyIcon_onDoubleClick(object sender, MouseEventArgs e)
        {
           Show();
           WindowState = FormWindowState.Normal;
        }
        private void settings_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm(notificationSetting);
            settingForm.ShowDialog(this);
        }
    }
}