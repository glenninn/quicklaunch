namespace quickLaunch
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
            this.btnMyBJN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BJN Monitor:";
            // 
            // monMtgId
            // 
            this.monMtgId.Location = new System.Drawing.Point(112, 44);
            this.monMtgId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monMtgId.Name = "monMtgId";
            this.monMtgId.Size = new System.Drawing.Size(153, 22);
            this.monMtgId.TabIndex = 1;
            this.monMtgId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpMonitor);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Web Server";
            // 
            // wsFolder
            // 
            this.wsFolder.Location = new System.Drawing.Point(112, 71);
            this.wsFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wsFolder.Name = "wsFolder";
            this.wsFolder.Size = new System.Drawing.Size(119, 22);
            this.wsFolder.TabIndex = 3;
            this.wsFolder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpWebServer);
            // 
            // btnFolderWhere
            // 
            this.btnFolderWhere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolderWhere.Location = new System.Drawing.Point(237, 69);
            this.btnFolderWhere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFolderWhere.Name = "btnFolderWhere";
            this.btnFolderWhere.Size = new System.Drawing.Size(28, 26);
            this.btnFolderWhere.TabIndex = 4;
            this.btnFolderWhere.UseVisualStyleBackColor = true;
            this.btnFolderWhere.Click += new System.EventHandler(this.OnClickFolderLocation);
            // 
            // btnMyBJN
            // 
            this.btnMyBJN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMyBJN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBJN.Location = new System.Drawing.Point(112, 99);
            this.btnMyBJN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMyBJN.Name = "btnMyBJN";
            this.btnMyBJN.Size = new System.Drawing.Size(153, 22);
            this.btnMyBJN.TabIndex = 5;
            this.btnMyBJN.Text = "4159908751";
            this.btnMyBJN.UseVisualStyleBackColor = true;
            this.btnMyBJN.Click += new System.EventHandler(this.OnClickMyBJN);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(199)))));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "quickLaunch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Join My Mtg";
            // 
            // QuickLaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(228)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMyBJN);
            this.Controls.Add(this.btnFolderWhere);
            this.Controls.Add(this.wsFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monMtgId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuickLaunch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuickLaunch";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.QuickLaunch_Load);
            this.Shown += new System.EventHandler(this.OnFirstShow);
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
        private System.Windows.Forms.Button btnMyBJN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

