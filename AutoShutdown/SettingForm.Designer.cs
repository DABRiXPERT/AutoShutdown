﻿namespace AutoShutdown
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.saveOnExit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.notificationSetupGroup = new System.Windows.Forms.GroupBox();
            this.byNothing = new System.Windows.Forms.RadioButton();
            this.byMessageBox = new System.Windows.Forms.RadioButton();
            this.byNotification = new System.Windows.Forms.RadioButton();
            this.exitWithoutChanges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.notificationSetupGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveOnExit
            // 
            this.saveOnExit.Location = new System.Drawing.Point(74, 325);
            this.saveOnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveOnExit.Name = "saveOnExit";
            this.saveOnExit.Size = new System.Drawing.Size(88, 24);
            this.saveOnExit.TabIndex = 0;
            this.saveOnExit.Text = "儲存設定";
            this.saveOnExit.UseVisualStyleBackColor = true;
            this.saveOnExit.Click += new System.EventHandler(this.saveOnExit_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(13, 219);
            this.info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(245, 39);
            this.info.TabIndex = 1;
            this.info.Text = "自動關機程式 版本 1.0 (2022/03/13)\r\n(C) DABRiXPERT 2022\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(13, 258);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(210, 13);
            this.githubLink.TabIndex = 3;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/DABRiXPERT";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // notificationSetupGroup
            // 
            this.notificationSetupGroup.Controls.Add(this.byNothing);
            this.notificationSetupGroup.Controls.Add(this.byMessageBox);
            this.notificationSetupGroup.Controls.Add(this.byNotification);
            this.notificationSetupGroup.Location = new System.Drawing.Point(12, 12);
            this.notificationSetupGroup.Name = "notificationSetupGroup";
            this.notificationSetupGroup.Size = new System.Drawing.Size(360, 41);
            this.notificationSetupGroup.TabIndex = 4;
            this.notificationSetupGroup.TabStop = false;
            this.notificationSetupGroup.Text = "通知方式";
            // 
            // byNothing
            // 
            this.byNothing.AutoSize = true;
            this.byNothing.Location = new System.Drawing.Point(287, 18);
            this.byNothing.Name = "byNothing";
            this.byNothing.Size = new System.Drawing.Size(67, 17);
            this.byNothing.TabIndex = 2;
            this.byNothing.Text = "不通知";
            this.byNothing.UseVisualStyleBackColor = true;
            // 
            // byMessageBox
            // 
            this.byMessageBox.AutoSize = true;
            this.byMessageBox.Location = new System.Drawing.Point(152, 18);
            this.byMessageBox.Name = "byMessageBox";
            this.byMessageBox.Size = new System.Drawing.Size(137, 17);
            this.byMessageBox.TabIndex = 1;
            this.byMessageBox.Text = "彈出視窗(Win 7+)";
            this.byMessageBox.UseVisualStyleBackColor = true;
            // 
            // byNotification
            // 
            this.byNotification.AutoSize = true;
            this.byNotification.Checked = true;
            this.byNotification.Location = new System.Drawing.Point(6, 18);
            this.byNotification.Name = "byNotification";
            this.byNotification.Size = new System.Drawing.Size(144, 17);
            this.byNotification.TabIndex = 0;
            this.byNotification.TabStop = true;
            this.byNotification.Text = "彈出通知(Win 10+)";
            this.byNotification.UseVisualStyleBackColor = true;
            // 
            // exitWithoutChanges
            // 
            this.exitWithoutChanges.Location = new System.Drawing.Point(170, 325);
            this.exitWithoutChanges.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitWithoutChanges.Name = "exitWithoutChanges";
            this.exitWithoutChanges.Size = new System.Drawing.Size(88, 24);
            this.exitWithoutChanges.TabIndex = 5;
            this.exitWithoutChanges.Text = "撤銷設定";
            this.exitWithoutChanges.UseVisualStyleBackColor = true;
            this.exitWithoutChanges.Click += new System.EventHandler(this.exitWithoutChanges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 41);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "密碼(待下次更新使用)";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitWithoutChanges);
            this.Controls.Add(this.notificationSetupGroup);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.saveOnExit);
            this.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingForm";
            this.Text = "設定";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.notificationSetupGroup.ResumeLayout(false);
            this.notificationSetupGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveOnExit;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.GroupBox notificationSetupGroup;
        private System.Windows.Forms.RadioButton byMessageBox;
        private System.Windows.Forms.RadioButton byNotification;
        private System.Windows.Forms.RadioButton byNothing;
        private System.Windows.Forms.Button exitWithoutChanges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}