using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartfeedSanitizer
{
    public partial class Invalids : Form
    {
        private readonly string current;
        public string final;
        public Point location;

        public Invalids(string current, Point l)
        {
            this.current = current;
            location = l;
            InitializeComponent();
            invalidtextbox.Focus();
            invalidtextbox.Select();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            List<string> splitted = current.Split(',').ToList();
            string invalidIds = Functions.SanitizeString(invalidtextbox.Text);
            var invalidList = invalidIds.Split(',');
            foreach (string inv in invalidList)
            {
                if (splitted.Contains(inv))
                {
                    splitted.Remove(inv);
                }
            }
            final = String.Join(",", splitted.Select(x => x.ToString()).ToArray());
            Hide();
        }

        private void invalidtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RemoveButton_Click(this, new EventArgs());
            }
        }

        private void Invalids_Load(object sender, EventArgs e)
        {
            Location = location;
        }
    }
}
