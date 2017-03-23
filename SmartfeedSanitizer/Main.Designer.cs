namespace SmartfeedSanitizer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.invButton = new System.Windows.Forms.Button();
            this.copyToClipboard = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextbox = new System.Windows.Forms.RichTextBox();
            this.TopToggle = new System.Windows.Forms.CheckBox();
            this.grabOnFocusCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // invButton
            // 
            this.invButton.Location = new System.Drawing.Point(8, 293);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(136, 23);
            this.invButton.TabIndex = 3;
            this.invButton.Text = "Remove Invalids";
            this.invButton.UseVisualStyleBackColor = true;
            this.invButton.Click += new System.EventHandler(this.invButton_Click);
            // 
            // copyToClipboard
            // 
            this.copyToClipboard.Location = new System.Drawing.Point(153, 293);
            this.copyToClipboard.Name = "copyToClipboard";
            this.copyToClipboard.Size = new System.Drawing.Size(136, 23);
            this.copyToClipboard.TabIndex = 4;
            this.copyToClipboard.Text = "Copy to Clipboard";
            this.copyToClipboard.UseVisualStyleBackColor = true;
            this.copyToClipboard.Click += new System.EventHandler(this.copyToClipboard_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(8, 160);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(39, 13);
            this.Output.TabIndex = 5;
            this.Output.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.EnableAutoDragDrop = true;
            this.inputTextBox.Location = new System.Drawing.Point(8, 31);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(281, 116);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(8, 176);
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(278, 111);
            this.outputTextbox.TabIndex = 2;
            this.outputTextbox.Text = "";
            // 
            // TopToggle
            // 
            this.TopToggle.AutoSize = true;
            this.TopToggle.Location = new System.Drawing.Point(222, 8);
            this.TopToggle.Name = "TopToggle";
            this.TopToggle.Size = new System.Drawing.Size(67, 17);
            this.TopToggle.TabIndex = 1;
            this.TopToggle.Text = "Topmost";
            this.TopToggle.UseVisualStyleBackColor = true;
            this.TopToggle.CheckStateChanged += new System.EventHandler(this.TopToggle_CheckStateChanged);
            // 
            // grabOnFocusCheckBox
            // 
            this.grabOnFocusCheckBox.AutoSize = true;
            this.grabOnFocusCheckBox.Location = new System.Drawing.Point(123, 8);
            this.grabOnFocusCheckBox.Name = "grabOnFocusCheckBox";
            this.grabOnFocusCheckBox.Size = new System.Drawing.Size(96, 17);
            this.grabOnFocusCheckBox.TabIndex = 7;
            this.grabOnFocusCheckBox.Text = "Grab on Focus";
            this.grabOnFocusCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Clipboard on Focus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 324);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grabOnFocusCheckBox);
            this.Controls.Add(this.TopToggle);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.copyToClipboard);
            this.Controls.Add(this.invButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SmartFeed Sanitizer";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button copyToClipboard;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextbox;
        private System.Windows.Forms.CheckBox TopToggle;
        private System.Windows.Forms.CheckBox grabOnFocusCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

