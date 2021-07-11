namespace Enfolder
{
    partial class EnfolderForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnfolderForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.fileToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.directoryToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.directoryCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subfolderButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.itemTimer = new System.Windows.Forms.Timer(this.components);
            this.enfolderToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripStatusLabel,
                                    this.fileCountToolStripStatusLabel,
                                    this.directoryToolStripStatusLabel,
                                    this.directoryCountToolStripStatusLabel,
                                    this.enfolderToolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(290, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // fileToolStripStatusLabel
            // 
            this.fileToolStripStatusLabel.Name = "fileToolStripStatusLabel";
            this.fileToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.fileToolStripStatusLabel.Text = "Files:";
            // 
            // fileCountToolStripStatusLabel
            // 
            this.fileCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCountToolStripStatusLabel.Name = "fileCountToolStripStatusLabel";
            this.fileCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.fileCountToolStripStatusLabel.Text = "0";
            // 
            // directoryToolStripStatusLabel
            // 
            this.directoryToolStripStatusLabel.Name = "directoryToolStripStatusLabel";
            this.directoryToolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
            this.directoryToolStripStatusLabel.Text = "Directories:";
            // 
            // directoryCountToolStripStatusLabel
            // 
            this.directoryCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directoryCountToolStripStatusLabel.Name = "directoryCountToolStripStatusLabel";
            this.directoryCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.directoryCountToolStripStatusLabel.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.messageLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subfolderButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.itemListBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 240);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // messageLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.messageLabel, 2);
            this.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(3, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(284, 25);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Files and directories:";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subfolderButton
            // 
            this.subfolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subfolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subfolderButton.Location = new System.Drawing.Point(3, 208);
            this.subfolderButton.Name = "subfolderButton";
            this.subfolderButton.Size = new System.Drawing.Size(139, 29);
            this.subfolderButton.TabIndex = 1;
            this.subfolderButton.Text = "&Subfolder";
            this.subfolderButton.UseVisualStyleBackColor = true;
            this.subfolderButton.Click += new System.EventHandler(this.OnSubfolderButtonClick);
            // 
            // browseButton
            // 
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(148, 208);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(139, 29);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "&Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.OnBrowseButtonClick);
            // 
            // itemListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.itemListBox, 2);
            this.itemListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(3, 28);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(284, 174);
            this.itemListBox.Sorted = true;
            this.itemListBox.TabIndex = 0;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Set enfolder move destination";
            // 
            // itemTimer
            // 
            this.itemTimer.Enabled = false;
            this.itemTimer.Tick += new System.EventHandler(this.OnItemTimerTick);
            // 
            // enfolderToolStripProgressBar
            // 
            this.enfolderToolStripProgressBar.Name = "enfolderToolStripProgressBar";
            this.enfolderToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.enfolderToolStripProgressBar.Visible = false;
            // 
            // EnfolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnfolderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item collection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnEnfolderFormFormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripProgressBar enfolderToolStripProgressBar;
        private System.Windows.Forms.Timer itemTimer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button subfolderButton;
        private System.Windows.Forms.ToolStripStatusLabel directoryCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel directoryToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fileCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel fileToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
