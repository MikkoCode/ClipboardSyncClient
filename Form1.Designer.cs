namespace ClipboardSyncClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSendClipboard;
        private System.Windows.Forms.Button btnRetrieveFromServer;
        private System.Windows.Forms.Button btnSaveDeviceName;
        private System.Windows.Forms.TextBox textBoxClipboard;
        private System.Windows.Forms.TextBox textBoxDeviceName;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Label lblClipboardData;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSendClipboard = new Button();
            btnRetrieveFromServer = new Button();
            btnSaveDeviceName = new Button();
            textBoxClipboard = new TextBox();
            textBoxDeviceName = new TextBox();
            textBoxLog = new TextBox();
            lblStatus = new Label();
            listBoxHistory = new ListBox();
            lblClipboardData = new Label();
            lblSource = new Label();
            lblHistory = new Label();
            lblDeviceName = new Label();
            lblLog = new Label();
            SuspendLayout();
            // 
            // btnSendClipboard
            // 
            btnSendClipboard.Location = new Point(13, 31);
            btnSendClipboard.Margin = new Padding(4, 5, 4, 5);
            btnSendClipboard.Name = "btnSendClipboard";
            btnSendClipboard.Size = new Size(200, 35);
            btnSendClipboard.TabIndex = 0;
            btnSendClipboard.Text = "Send Clipboard";
            btnSendClipboard.UseVisualStyleBackColor = true;
            btnSendClipboard.Click += btnSendClipboard_Click;
            // 
            // btnRetrieveFromServer
            // 
            btnRetrieveFromServer.Location = new Point(13, 76);
            btnRetrieveFromServer.Margin = new Padding(4, 5, 4, 5);
            btnRetrieveFromServer.Name = "btnRetrieveFromServer";
            btnRetrieveFromServer.Size = new Size(200, 35);
            btnRetrieveFromServer.TabIndex = 1;
            btnRetrieveFromServer.Text = "Get Clipboard";
            btnRetrieveFromServer.UseVisualStyleBackColor = true;
            btnRetrieveFromServer.Click += btnRetrieveFromServer_Click;
            // 
            // btnSaveDeviceName
            // 
            btnSaveDeviceName.Location = new Point(281, 76);
            btnSaveDeviceName.Margin = new Padding(4, 5, 4, 5);
            btnSaveDeviceName.Name = "btnSaveDeviceName";
            btnSaveDeviceName.Size = new Size(200, 35);
            btnSaveDeviceName.TabIndex = 2;
            btnSaveDeviceName.Text = "Save";
            btnSaveDeviceName.UseVisualStyleBackColor = true;
            btnSaveDeviceName.Click += btnSaveDeviceName_Click;
            // 
            // textBoxClipboard
            // 
            textBoxClipboard.Location = new Point(16, 177);
            textBoxClipboard.Margin = new Padding(4, 5, 4, 5);
            textBoxClipboard.Multiline = true;
            textBoxClipboard.Name = "textBoxClipboard";
            textBoxClipboard.Size = new Size(465, 90);
            textBoxClipboard.TabIndex = 3;
            // 
            // textBoxDeviceName
            // 
            textBoxDeviceName.Location = new Point(282, 39);
            textBoxDeviceName.Margin = new Padding(4, 5, 4, 5);
            textBoxDeviceName.Name = "textBoxDeviceName";
            textBoxDeviceName.Size = new Size(199, 27);
            textBoxDeviceName.TabIndex = 4;
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(16, 492);
            textBoxLog.Margin = new Padding(4, 5, 4, 5);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ReadOnly = true;
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(465, 152);
            textBoxLog.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 303);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // listBoxHistory
            // 
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(16, 354);
            listBoxHistory.Margin = new Padding(4, 5, 4, 5);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(465, 104);
            listBoxHistory.TabIndex = 7;
            // 
            // lblClipboardData
            // 
            lblClipboardData.AutoSize = true;
            lblClipboardData.Location = new Point(16, 146);
            lblClipboardData.Margin = new Padding(4, 0, 4, 0);
            lblClipboardData.Name = "lblClipboardData";
            lblClipboardData.Size = new Size(159, 20);
            lblClipboardData.TabIndex = 8;
            lblClipboardData.Text = "Current clipboard data";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(13, 272);
            lblSource.Margin = new Padding(4, 0, 4, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(88, 20);
            lblSource.TabIndex = 9;
            lblSource.Text = "Source: N/A";
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(16, 323);
            lblHistory.Margin = new Padding(4, 0, 4, 0);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(59, 20);
            lblHistory.TabIndex = 10;
            lblHistory.Text = "History:";
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Location = new Point(282, 14);
            lblDeviceName.Margin = new Padding(4, 0, 4, 0);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(98, 20);
            lblDeviceName.TabIndex = 11;
            lblDeviceName.Text = "Device Name";
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(16, 462);
            lblLog.Margin = new Padding(4, 0, 4, 0);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(37, 20);
            lblLog.TabIndex = 12;
            lblLog.Text = "Log:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 663);
            Controls.Add(lblLog);
            Controls.Add(lblDeviceName);
            Controls.Add(lblHistory);
            Controls.Add(lblSource);
            Controls.Add(lblClipboardData);
            Controls.Add(listBoxHistory);
            Controls.Add(lblStatus);
            Controls.Add(textBoxLog);
            Controls.Add(textBoxDeviceName);
            Controls.Add(textBoxClipboard);
            Controls.Add(btnSaveDeviceName);
            Controls.Add(btnRetrieveFromServer);
            Controls.Add(btnSendClipboard);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Clipboard Sync Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
