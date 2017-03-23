using System;
using System.Drawing;
using System.Windows.Forms;
using SmartfeedSanitizer.Properties;
using static SmartfeedSanitizer.Functions;

namespace SmartfeedSanitizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            inputTextBox.Focus();
            inputTextBox.Select();
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
            string input = outputTextbox.Text;
            Point l = Location;
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
            Settings.Default.WindowLocation = Location;
            Settings.Default.Save();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Location = Settings.Default.WindowLocation;
        }
    }
}
