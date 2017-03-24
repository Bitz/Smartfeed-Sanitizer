using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using SmartfeedSanitizer.Properties;
using static SmartfeedSanitizer.Functions;

namespace SmartfeedSanitizer
{
    public partial class MainWindow : Form
    {
        readonly KeyboardHook hook = new KeyboardHook();
        bool notifshown;
        const string HOTKEY = "CTRL+SHIFT+C";
        public MainWindow()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            inputTextBox.Focus();
            inputTextBox.Select();
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            QuickSanitize();
        }

        private void copyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextbox.Text);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextbox.Text = SanitizeString(inputTextBox.Text);
        }

        private void invButton_Click(object sender, EventArgs e)
        {
            int h = Height;
            int w = Width;
            string input = outputTextbox.Text;
            Point l = Location;
            l.Y = (h/2 - 60 ) + l.Y;
            l.X = (w/2 - 137) +  l.X;
            Invalids inv = new Invalids(input, l);
            inv.ShowDialog();
            outputTextbox.Text = inv.final;
        }
         
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length == 0 || (grabOnFocusCheckBox.Checked && Clipboard.ContainsText(TextDataFormat.Text)) )
            {
                inputTextBox.Text = Clipboard.GetText();
            }
            if (checkBox1.Checked && (outputTextbox.Text.Length > 0))
            {
                Clipboard.SetText(outputTextbox.Text);
            }
        }

        private void TopToggle_CheckStateChanged(object sender, EventArgs e)
        {
            TopMost = TopToggle.Checked;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            notifyIcon.Visible = true;
            if (!notifshown) {
                notifyIcon.ShowBalloonTip(20, "Smartfeed Sanitizer", $"Minimized to tray- the shortcut is {HOTKEY}!", ToolTipIcon.Info);
                notifshown = true;
            }
                       
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            hook.KeyPressed += hook_KeyPressed;
            hook.RegisterHotKey(SmartfeedSanitizer.ModifierKeys.Control | SmartfeedSanitizer.ModifierKeys.Shift, Keys.C);
            Location = Settings.Default.WindowLocation;
        }

        private void ExitContextMenu_Click(object sender, EventArgs e)
        {
           Exit();
        }

        private void ShowContextMenu_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Show();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { QuickSanitize(); }
            
        }

        private void sanitizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSanitize();
        }

        #region Helpers

        public void Exit()
        {
            notifyIcon.Visible = false;
            Settings.Default.WindowLocation = Location;
            Settings.Default.Save();
            Environment.Exit(1);
        }

        public void QuickSanitize() {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                inputTextBox.Text = Clipboard.GetText();
            }
            if (outputTextbox.Text.Length > 0)
            {
                Clipboard.SetText(outputTextbox.Text);
            }
            notifyIcon.ShowBalloonTip(20, "Smartfeed Sanitizer", "Cliboard sanitized!", ToolTipIcon.Info);
            try {
                SoundPlayer player = new SoundPlayer()
                {
                    SoundLocation = @"alert.wav"
                };
                player.Play();
            }
            catch (Exception)
            {
                // ignored
            }
        }


        #endregion

        
    }
}
