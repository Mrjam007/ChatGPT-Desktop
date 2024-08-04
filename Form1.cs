namespace ChatGPT_desktop
{
    public partial class Form1 : Form
    {
        bool _allowedToClose;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_allowedToClose)
            {
                base.OnFormClosing(e);
            }
            else
            {
                e.Cancel = true;
                this.Hide();
            }


            base.OnFormClosing(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadpage();
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            BTNshow.Click += BTNshow_Click;
            BTNquit.Click += BTNquit_Click;
        }



        private void BTNquit_Click(object sender, EventArgs e)
        {
            _allowedToClose = true;
            Application.Exit();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.Focus();
        }


        private void BTNshow_Click(object sender, EventArgs e)
        {
            ShowForm();
        }



        private async void loadpage()
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://chatgpt.com/");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            loadpage();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
        }
    }
}
