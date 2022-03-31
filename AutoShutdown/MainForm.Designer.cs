namespace AutoShutdown
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.countdown = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.reject = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.timerForDateTime = new System.Windows.Forms.Timer(this.components);
            this.timerForCountdown = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBackgroundSession = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "關機時間設定：";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(166, 18);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(265, 23);
            this.timePicker.TabIndex = 1;
            this.timePicker.Value = new System.DateTime(2004, 3, 25, 4, 0, 0, 0);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.OrangeRed;
            this.countdown.Location = new System.Drawing.Point(9, 58);
            this.countdown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(450, 20);
            this.countdown.TabIndex = 2;
            this.countdown.Text = "這部裝置將在　－－時－－分－－秒　後關閉。";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.ForestGreen;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(13, 93);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(144, 63);
            this.save.TabIndex = 3;
            this.save.Text = "儲存設定";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reject
            // 
            this.reject.BackColor = System.Drawing.Color.Red;
            this.reject.ForeColor = System.Drawing.Color.White;
            this.reject.Location = new System.Drawing.Point(165, 93);
            this.reject.Margin = new System.Windows.Forms.Padding(4);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(144, 63);
            this.reject.TabIndex = 4;
            this.reject.Text = "撤銷設置";
            this.reject.UseVisualStyleBackColor = false;
            this.reject.Click += new System.EventHandler(this.reject_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Yellow;
            this.settings.Location = new System.Drawing.Point(317, 93);
            this.settings.Margin = new System.Windows.Forms.Padding(4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(144, 63);
            this.settings.TabIndex = 5;
            this.settings.Text = "更多設定";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // timeDisplay
            // 
            this.timeDisplay.AutoEllipsis = true;
            this.timeDisplay.AutoSize = true;
            this.timeDisplay.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ForeColor = System.Drawing.Color.Blue;
            this.timeDisplay.Location = new System.Drawing.Point(9, 176);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(399, 20);
            this.timeDisplay.TabIndex = 6;
            this.timeDisplay.Text = "現在時間：20--年--月--日 --時--分--秒。";
            // 
            // timerForDateTime
            // 
            this.timerForDateTime.Enabled = true;
            this.timerForDateTime.Interval = 20;
            this.timerForDateTime.Tick += new System.EventHandler(this.timerForDateTime_Tick);
            // 
            // timerForCountdown
            // 
            this.timerForCountdown.Interval = 20;
            this.timerForCountdown.Tick += new System.EventHandler(this.timerForCountdown_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // checkBackgroundSession
            // 
            this.checkBackgroundSession.Interval = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.reject);
            this.Controls.Add(this.save);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "自動關機程式 ver: 1.05";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Timer timerForDateTime;
        private System.Windows.Forms.Timer timerForCountdown;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer checkBackgroundSession;
    }
}

