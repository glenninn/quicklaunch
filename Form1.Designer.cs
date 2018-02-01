﻿namespace quickLaunch
{
    partial class QuickLaunch
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
            this.components = new System.ComponentModel.Container();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.monMtgId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wsFolder = new System.Windows.Forms.TextBox();
            this.btnFolderWhere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.OnClickTrayIcon);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BJN Monitor:";
            // 
            // monMtgId
            // 
            this.monMtgId.Location = new System.Drawing.Point(119, 23);
            this.monMtgId.Name = "monMtgId";
            this.monMtgId.Size = new System.Drawing.Size(147, 26);
            this.monMtgId.TabIndex = 1;
            this.monMtgId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpMonitor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Web Server";
            // 
            // wsFolder
            // 
            this.wsFolder.Location = new System.Drawing.Point(119, 56);
            this.wsFolder.Name = "wsFolder";
            this.wsFolder.Size = new System.Drawing.Size(93, 26);
            this.wsFolder.TabIndex = 3;
            // 
            // btnFolderWhere
            // 
            this.btnFolderWhere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolderWhere.Location = new System.Drawing.Point(232, 59);
            this.btnFolderWhere.Name = "btnFolderWhere";
            this.btnFolderWhere.Size = new System.Drawing.Size(32, 32);
            this.btnFolderWhere.TabIndex = 4;
            this.btnFolderWhere.UseVisualStyleBackColor = true;
            this.btnFolderWhere.Click += new System.EventHandler(this.OnClickFolderLocation);
            // 
            // QuickLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.ControlBox = false;
            this.Controls.Add(this.btnFolderWhere);
            this.Controls.Add(this.wsFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monMtgId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickLaunch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuickLaunch";
            this.Load += new System.EventHandler(this.QuickLaunch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monMtgId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wsFolder;
        private System.Windows.Forms.Button btnFolderWhere;
    }
}

