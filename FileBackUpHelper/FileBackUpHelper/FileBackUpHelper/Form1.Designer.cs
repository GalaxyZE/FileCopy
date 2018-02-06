namespace FileBackUpHelper
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTargetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.WatchDog = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(256, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourcePathToolStripMenuItem,
            this.targetPathToolStripMenuItem,
            this.autoBackUpToolStripMenuItem,
            this.interfaceToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.nowToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // sourcePathToolStripMenuItem
            // 
            this.sourcePathToolStripMenuItem.Name = "sourcePathToolStripMenuItem";
            this.sourcePathToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sourcePathToolStripMenuItem.Text = "SourcePath";
            this.sourcePathToolStripMenuItem.Click += new System.EventHandler(this.sourcePathToolStripMenuItem_Click);
            // 
            // targetPathToolStripMenuItem
            // 
            this.targetPathToolStripMenuItem.Name = "targetPathToolStripMenuItem";
            this.targetPathToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.targetPathToolStripMenuItem.Text = "TargetPath";
            this.targetPathToolStripMenuItem.Click += new System.EventHandler(this.targetPathToolStripMenuItem_Click);
            // 
            // autoBackUpToolStripMenuItem
            // 
            this.autoBackUpToolStripMenuItem.Name = "autoBackUpToolStripMenuItem";
            this.autoBackUpToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.autoBackUpToolStripMenuItem.Text = "AutoBackUp";
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.interfaceToolStripMenuItem.Text = "Interface";
            this.interfaceToolStripMenuItem.Click += new System.EventHandler(this.interfaceToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTargetToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteTargetToolStripMenuItem
            // 
            this.deleteTargetToolStripMenuItem.Name = "deleteTargetToolStripMenuItem";
            this.deleteTargetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteTargetToolStripMenuItem.Text = "DeleteTarget";
            this.deleteTargetToolStripMenuItem.Click += new System.EventHandler(this.deleteTargetToolStripMenuItem_Click);
            // 
            // nowToolStripMenuItem
            // 
            this.nowToolStripMenuItem.Name = "nowToolStripMenuItem";
            this.nowToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nowToolStripMenuItem.Text = "Now";
            this.nowToolStripMenuItem.Click += new System.EventHandler(this.nowToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(144, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WatchDog
            // 
            this.WatchDog.Tick += new System.EventHandler(this.WatchDog_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "BackupHelper";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowBackUpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // nowBackUpToolStripMenuItem
            // 
            this.nowBackUpToolStripMenuItem.Name = "nowBackUpToolStripMenuItem";
            this.nowBackUpToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nowBackUpToolStripMenuItem.Text = "NowBackUp";
            this.nowBackUpToolStripMenuItem.Click += new System.EventHandler(this.nowBackUpToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 141);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetPathToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem autoBackUpToolStripMenuItem;
        private System.Windows.Forms.Timer WatchDog;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTargetToolStripMenuItem;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem nowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

