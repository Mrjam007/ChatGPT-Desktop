namespace ChatGPT_desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1 = new ToolStrip();
            Refresh = new ToolStripButton();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            BTNshow = new ToolStripMenuItem();
            BTNquit = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 28);
            webView21.Name = "webView21";
            webView21.Size = new Size(794, 381);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // toolStrip1
            // 
            toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { Refresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(66, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // Refresh
            // 
            Refresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Refresh.Image = (Image)resources.GetObject("Refresh.Image");
            Refresh.ImageTransparentColor = Color.Magenta;
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(23, 22);
            Refresh.Text = "Refresh";
            Refresh.Click += toolStripButton1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { BTNshow, BTNquit });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // BTNshow
            // 
            BTNshow.Name = "BTNshow";
            BTNshow.Size = new Size(103, 22);
            BTNshow.Text = "Show";
            // 
            // BTNquit
            // 
            BTNquit.Image = (Image)resources.GetObject("BTNquit.Image");
            BTNquit.Name = "BTNquit";
            BTNquit.Size = new Size(103, 22);
            BTNquit.Text = "Quit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(794, 409);
            Controls.Add(toolStrip1);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.Manual;
            Text = "GPT DESKTOP";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ToolStrip toolStrip1;
        private ToolStripButton Refresh;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem BTNshow;
        private ToolStripMenuItem BTNquit;
    }
}
