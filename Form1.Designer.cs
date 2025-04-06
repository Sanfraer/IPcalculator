namespace IPcalculator
{
    partial class Form1
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.maskLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.firstHostTextBox = new System.Windows.Forms.TextBox();
            this.lastHostTextBox = new System.Windows.Forms.TextBox();
            this.broadcastTextBox = new System.Windows.Forms.TextBox();
            this.networkAddressTextBox = new System.Windows.Forms.TextBox();
            this.numberOfHostsTextBox = new System.Windows.Forms.TextBox();
            this.decimalValueTextBox = new System.Windows.Forms.TextBox();
            this.binaryValueTextBox = new System.Windows.Forms.TextBox();
            this.prefixLengthTextBox = new System.Windows.Forms.TextBox();
            this.firstHostLabel = new System.Windows.Forms.Label();
            this.lastHostLabel = new System.Windows.Forms.Label();
            this.broadcastLabel = new System.Windows.Forms.Label();
            this.networkAddressLabel = new System.Windows.Forms.Label();
            this.numberOfHostsLabel = new System.Windows.Forms.Label();
            this.decimalValueLabel = new System.Windows.Forms.Label();
            this.binaryValueLabel = new System.Windows.Forms.Label();
            this.prefixLengthLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.maskComboBox = new System.Windows.Forms.ComboBox();
            this.subnet1Label = new System.Windows.Forms.Label();
            this.subnet1NetworkTextBox = new System.Windows.Forms.TextBox();
            this.subnet1MinHostTextBox = new System.Windows.Forms.TextBox();
            this.subnet1MaxHostTextBox = new System.Windows.Forms.TextBox();
            this.subnet1BroadcastTextBox = new System.Windows.Forms.TextBox();
            this.subnet1NumberOfHostsTextBox = new System.Windows.Forms.TextBox();
            this.subnet2Label = new System.Windows.Forms.Label();
            this.subnet2NetworkTextBox = new System.Windows.Forms.TextBox();
            this.subnet2MinHostTextBox = new System.Windows.Forms.TextBox();
            this.subnet2MaxHostTextBox = new System.Windows.Forms.TextBox();
            this.subnet2BroadcastTextBox = new System.Windows.Forms.TextBox();
            this.subnet2NumberOfHostsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(128, 64);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(50, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP адрес";
            // 
            // maskLabel
            // 
            this.maskLabel.AutoSize = true;
            this.maskLabel.Location = new System.Drawing.Point(128, 39);
            this.maskLabel.Name = "maskLabel";
            this.maskLabel.Size = new System.Drawing.Size(40, 13);
            this.maskLabel.TabIndex = 1;
            this.maskLabel.Text = "Маска";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 87);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // firstHostTextBox
            // 
            this.firstHostTextBox.Location = new System.Drawing.Point(12, 147);
            this.firstHostTextBox.Name = "firstHostTextBox";
            this.firstHostTextBox.ReadOnly = true;
            this.firstHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstHostTextBox.TabIndex = 3;
            // 
            // lastHostTextBox
            // 
            this.lastHostTextBox.Location = new System.Drawing.Point(12, 173);
            this.lastHostTextBox.Name = "lastHostTextBox";
            this.lastHostTextBox.ReadOnly = true;
            this.lastHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastHostTextBox.TabIndex = 4;
            // 
            // broadcastTextBox
            // 
            this.broadcastTextBox.Location = new System.Drawing.Point(12, 199);
            this.broadcastTextBox.Name = "broadcastTextBox";
            this.broadcastTextBox.ReadOnly = true;
            this.broadcastTextBox.Size = new System.Drawing.Size(100, 20);
            this.broadcastTextBox.TabIndex = 5;
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(12, 225);
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.networkAddressTextBox.TabIndex = 6;
            // 
            // numberOfHostsTextBox
            // 
            this.numberOfHostsTextBox.Location = new System.Drawing.Point(12, 251);
            this.numberOfHostsTextBox.Name = "numberOfHostsTextBox";
            this.numberOfHostsTextBox.ReadOnly = true;
            this.numberOfHostsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfHostsTextBox.TabIndex = 7;
            // 
            // decimalValueTextBox
            // 
            this.decimalValueTextBox.Location = new System.Drawing.Point(12, 277);
            this.decimalValueTextBox.Name = "decimalValueTextBox";
            this.decimalValueTextBox.ReadOnly = true;
            this.decimalValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.decimalValueTextBox.TabIndex = 8;
            // 
            // binaryValueTextBox
            // 
            this.binaryValueTextBox.Location = new System.Drawing.Point(12, 303);
            this.binaryValueTextBox.Name = "binaryValueTextBox";
            this.binaryValueTextBox.ReadOnly = true;
            this.binaryValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.binaryValueTextBox.TabIndex = 9;
            // 
            // prefixLengthTextBox
            // 
            this.prefixLengthTextBox.Location = new System.Drawing.Point(12, 329);
            this.prefixLengthTextBox.Name = "prefixLengthTextBox";
            this.prefixLengthTextBox.ReadOnly = true;
            this.prefixLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.prefixLengthTextBox.TabIndex = 10;
            // 
            // firstHostLabel
            // 
            this.firstHostLabel.AutoSize = true;
            this.firstHostLabel.Location = new System.Drawing.Point(118, 150);
            this.firstHostLabel.Name = "firstHostLabel";
            this.firstHostLabel.Size = new System.Drawing.Size(125, 13);
            this.firstHostLabel.TabIndex = 11;
            this.firstHostLabel.Text = "IP адрес первого хоста";
            // 
            // lastHostLabel
            // 
            this.lastHostLabel.AutoSize = true;
            this.lastHostLabel.Location = new System.Drawing.Point(118, 176);
            this.lastHostLabel.Name = "lastHostLabel";
            this.lastHostLabel.Size = new System.Drawing.Size(143, 13);
            this.lastHostLabel.TabIndex = 12;
            this.lastHostLabel.Text = "IP адрес последнего хоста";
            // 
            // broadcastLabel
            // 
            this.broadcastLabel.AutoSize = true;
            this.broadcastLabel.Location = new System.Drawing.Point(118, 202);
            this.broadcastLabel.Name = "broadcastLabel";
            this.broadcastLabel.Size = new System.Drawing.Size(149, 13);
            this.broadcastLabel.TabIndex = 13;
            this.broadcastLabel.Text = "Широковещательный адрес";
            // 
            // networkAddressLabel
            // 
            this.networkAddressLabel.AutoSize = true;
            this.networkAddressLabel.Location = new System.Drawing.Point(118, 228);
            this.networkAddressLabel.Name = "networkAddressLabel";
            this.networkAddressLabel.Size = new System.Drawing.Size(64, 13);
            this.networkAddressLabel.TabIndex = 14;
            this.networkAddressLabel.Text = "Адрес сети";
            // 
            // numberOfHostsLabel
            // 
            this.numberOfHostsLabel.AutoSize = true;
            this.numberOfHostsLabel.Location = new System.Drawing.Point(118, 254);
            this.numberOfHostsLabel.Name = "numberOfHostsLabel";
            this.numberOfHostsLabel.Size = new System.Drawing.Size(103, 13);
            this.numberOfHostsLabel.TabIndex = 15;
            this.numberOfHostsLabel.Text = "Количество хостов";
            // 
            // decimalValueLabel
            // 
            this.decimalValueLabel.AutoSize = true;
            this.decimalValueLabel.Location = new System.Drawing.Point(118, 280);
            this.decimalValueLabel.Name = "decimalValueLabel";
            this.decimalValueLabel.Size = new System.Drawing.Size(87, 13);
            this.decimalValueLabel.TabIndex = 16;
            this.decimalValueLabel.Text = "Значение 10 СС";
            // 
            // binaryValueLabel
            // 
            this.binaryValueLabel.AutoSize = true;
            this.binaryValueLabel.Location = new System.Drawing.Point(118, 306);
            this.binaryValueLabel.Name = "binaryValueLabel";
            this.binaryValueLabel.Size = new System.Drawing.Size(138, 13);
            this.binaryValueLabel.TabIndex = 17;
            this.binaryValueLabel.Text = "Бинарное значение (2 СС)";
            // 
            // prefixLengthLabel
            // 
            this.prefixLengthLabel.AutoSize = true;
            this.prefixLengthLabel.Location = new System.Drawing.Point(118, 332);
            this.prefixLengthLabel.Name = "prefixLengthLabel";
            this.prefixLengthLabel.Size = new System.Drawing.Size(88, 13);
            this.prefixLengthLabel.TabIndex = 18;
            this.prefixLengthLabel.Text = "Префикс маски";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(12, 61);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(110, 20);
            this.ipTextBox.TabIndex = 19;
            // 
            // maskComboBox
            // 
            this.maskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maskComboBox.FormattingEnabled = true;
            this.maskComboBox.Items.AddRange(new object[] {
            "255.0.0.0",
            "255.128.0.0",
            "255.192.0.0",
            "255.224.0.0",
            "255.240.0.0",
            "255.248.0.0",
            "255.252.0.0",
            "255.254.0.0",
            "255.255.0.0",
            "255.255.128.0",
            "255.255.192.0",
            "255.255.224.0",
            "255.255.240.0",
            "255.255.248.0",
            "255.255.252.0",
            "255.255.254.0",
            "255.255.255.0",
            "255.255.255.128",
            "255.255.255.192",
            "255.255.255.224",
            "255.255.255.240",
            "255.255.255.248",
            "255.255.255.252"});
            this.maskComboBox.Location = new System.Drawing.Point(12, 36);
            this.maskComboBox.Name = "maskComboBox";
            this.maskComboBox.Size = new System.Drawing.Size(110, 21);
            this.maskComboBox.TabIndex = 20;
            // 
            // subnet1Label
            // 
            this.subnet1Label.AutoSize = true;
            this.subnet1Label.Location = new System.Drawing.Point(12, 369);
            this.subnet1Label.Name = "subnet1Label";
            this.subnet1Label.Size = new System.Drawing.Size(57, 13);
            this.subnet1Label.TabIndex = 21;
            this.subnet1Label.Text = "1 подсеть";
            // 
            // subnet1NetworkTextBox
            // 
            this.subnet1NetworkTextBox.Location = new System.Drawing.Point(12, 385);
            this.subnet1NetworkTextBox.Name = "subnet1NetworkTextBox";
            this.subnet1NetworkTextBox.ReadOnly = true;
            this.subnet1NetworkTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet1NetworkTextBox.TabIndex = 22;
            // 
            // subnet1MinHostTextBox
            // 
            this.subnet1MinHostTextBox.Location = new System.Drawing.Point(12, 411);
            this.subnet1MinHostTextBox.Name = "subnet1MinHostTextBox";
            this.subnet1MinHostTextBox.ReadOnly = true;
            this.subnet1MinHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet1MinHostTextBox.TabIndex = 23;
            // 
            // subnet1MaxHostTextBox
            // 
            this.subnet1MaxHostTextBox.Location = new System.Drawing.Point(12, 437);
            this.subnet1MaxHostTextBox.Name = "subnet1MaxHostTextBox";
            this.subnet1MaxHostTextBox.ReadOnly = true;
            this.subnet1MaxHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet1MaxHostTextBox.TabIndex = 24;
            // 
            // subnet1BroadcastTextBox
            // 
            this.subnet1BroadcastTextBox.Location = new System.Drawing.Point(12, 463);
            this.subnet1BroadcastTextBox.Name = "subnet1BroadcastTextBox";
            this.subnet1BroadcastTextBox.ReadOnly = true;
            this.subnet1BroadcastTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet1BroadcastTextBox.TabIndex = 25;
            // 
            // subnet1NumberOfHostsTextBox
            // 
            this.subnet1NumberOfHostsTextBox.Location = new System.Drawing.Point(12, 489);
            this.subnet1NumberOfHostsTextBox.Name = "subnet1NumberOfHostsTextBox";
            this.subnet1NumberOfHostsTextBox.ReadOnly = true;
            this.subnet1NumberOfHostsTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet1NumberOfHostsTextBox.TabIndex = 26;
            // 
            // subnet2Label
            // 
            this.subnet2Label.AutoSize = true;
            this.subnet2Label.Location = new System.Drawing.Point(118, 369);
            this.subnet2Label.Name = "subnet2Label";
            this.subnet2Label.Size = new System.Drawing.Size(57, 13);
            this.subnet2Label.TabIndex = 27;
            this.subnet2Label.Text = "2 подсеть";
            // 
            // subnet2NetworkTextBox
            // 
            this.subnet2NetworkTextBox.Location = new System.Drawing.Point(121, 385);
            this.subnet2NetworkTextBox.Name = "subnet2NetworkTextBox";
            this.subnet2NetworkTextBox.ReadOnly = true;
            this.subnet2NetworkTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet2NetworkTextBox.TabIndex = 28;
            // 
            // subnet2MinHostTextBox
            // 
            this.subnet2MinHostTextBox.Location = new System.Drawing.Point(121, 411);
            this.subnet2MinHostTextBox.Name = "subnet2MinHostTextBox";
            this.subnet2MinHostTextBox.ReadOnly = true;
            this.subnet2MinHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet2MinHostTextBox.TabIndex = 29;
            // 
            // subnet2MaxHostTextBox
            // 
            this.subnet2MaxHostTextBox.Location = new System.Drawing.Point(121, 437);
            this.subnet2MaxHostTextBox.Name = "subnet2MaxHostTextBox";
            this.subnet2MaxHostTextBox.ReadOnly = true;
            this.subnet2MaxHostTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet2MaxHostTextBox.TabIndex = 30;
            // 
            // subnet2BroadcastTextBox
            // 
            this.subnet2BroadcastTextBox.Location = new System.Drawing.Point(121, 463);
            this.subnet2BroadcastTextBox.Name = "subnet2BroadcastTextBox";
            this.subnet2BroadcastTextBox.ReadOnly = true;
            this.subnet2BroadcastTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet2BroadcastTextBox.TabIndex = 31;
            // 
            // subnet2NumberOfHostsTextBox
            // 
            this.subnet2NumberOfHostsTextBox.Location = new System.Drawing.Point(121, 489);
            this.subnet2NumberOfHostsTextBox.Name = "subnet2NumberOfHostsTextBox";
            this.subnet2NumberOfHostsTextBox.ReadOnly = true;
            this.subnet2NumberOfHostsTextBox.Size = new System.Drawing.Size(100, 20);
            this.subnet2NumberOfHostsTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.subnet2NumberOfHostsTextBox);
            this.Controls.Add(this.subnet2BroadcastTextBox);
            this.Controls.Add(this.subnet2MaxHostTextBox);
            this.Controls.Add(this.subnet2MinHostTextBox);
            this.Controls.Add(this.subnet2NetworkTextBox);
            this.Controls.Add(this.subnet2Label);
            this.Controls.Add(this.subnet1NumberOfHostsTextBox);
            this.Controls.Add(this.subnet1BroadcastTextBox);
            this.Controls.Add(this.subnet1MaxHostTextBox);
            this.Controls.Add(this.subnet1MinHostTextBox);
            this.Controls.Add(this.subnet1NetworkTextBox);
            this.Controls.Add(this.subnet1Label);
            this.Controls.Add(this.maskComboBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.prefixLengthLabel);
            this.Controls.Add(this.binaryValueLabel);
            this.Controls.Add(this.decimalValueLabel);
            this.Controls.Add(this.numberOfHostsLabel);
            this.Controls.Add(this.networkAddressLabel);
            this.Controls.Add(this.broadcastLabel);
            this.Controls.Add(this.lastHostLabel);
            this.Controls.Add(this.firstHostLabel);
            this.Controls.Add(this.prefixLengthTextBox);
            this.Controls.Add(this.binaryValueTextBox);
            this.Controls.Add(this.decimalValueTextBox);
            this.Controls.Add(this.numberOfHostsTextBox);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.broadcastTextBox);
            this.Controls.Add(this.lastHostTextBox);
            this.Controls.Add(this.firstHostTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.maskLabel);
            this.Controls.Add(this.ipLabel);
            this.Name = "Form1";
            this.Text = "IP Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label maskLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox firstHostTextBox;
        private System.Windows.Forms.TextBox lastHostTextBox;
        private System.Windows.Forms.TextBox broadcastTextBox;
        private System.Windows.Forms.TextBox networkAddressTextBox;
        private System.Windows.Forms.TextBox numberOfHostsTextBox;
        private System.Windows.Forms.TextBox decimalValueTextBox;
        private System.Windows.Forms.TextBox binaryValueTextBox;
        private System.Windows.Forms.TextBox prefixLengthTextBox;
        private System.Windows.Forms.Label firstHostLabel;
        private System.Windows.Forms.Label lastHostLabel;
        private System.Windows.Forms.Label broadcastLabel;
        private System.Windows.Forms.Label networkAddressLabel;
        private System.Windows.Forms.Label numberOfHostsLabel;
        private System.Windows.Forms.Label decimalValueLabel;
        private System.Windows.Forms.Label binaryValueLabel;
        private System.Windows.Forms.Label prefixLengthLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.ComboBox maskComboBox;
        private System.Windows.Forms.Label subnet1Label;
        private System.Windows.Forms.TextBox subnet1NetworkTextBox;
        private System.Windows.Forms.TextBox subnet1MinHostTextBox;
        private System.Windows.Forms.TextBox subnet1MaxHostTextBox;
        private System.Windows.Forms.TextBox subnet1BroadcastTextBox;
        private System.Windows.Forms.TextBox subnet1NumberOfHostsTextBox;
        private System.Windows.Forms.Label subnet2Label;
        private System.Windows.Forms.TextBox subnet2NetworkTextBox;
        private System.Windows.Forms.TextBox subnet2MinHostTextBox;
        private System.Windows.Forms.TextBox subnet2MaxHostTextBox;
        private System.Windows.Forms.TextBox subnet2BroadcastTextBox;
        private System.Windows.Forms.TextBox subnet2NumberOfHostsTextBox;
    }
}
