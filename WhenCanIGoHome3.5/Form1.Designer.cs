namespace WhenCanIGoHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arrivalPicker = new System.Windows.Forms.DateTimePicker();
            this.lunchtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.departurePicker = new System.Windows.Forms.DateTimePicker();
            this.goneHome = new System.Windows.Forms.CheckBox();
            this.departureBox = new System.Windows.Forms.GroupBox();
            this.nextDayButton = new System.Windows.Forms.CheckBox();
            this.arrivalBox = new System.Windows.Forms.GroupBox();
            this.setTimeToNowButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.lunchtimeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.robinTime = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flexField = new System.Windows.Forms.Label();
            this.departureBox.SuspendLayout();
            this.arrivalBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchtimeError)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "I came to work at:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lunch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Went home at:";
            // 
            // arrivalPicker
            // 
            this.arrivalPicker.CustomFormat = "HH:mm";
            this.arrivalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrivalPicker.Location = new System.Drawing.Point(104, 10);
            this.arrivalPicker.Name = "arrivalPicker";
            this.arrivalPicker.ShowUpDown = true;
            this.arrivalPicker.Size = new System.Drawing.Size(61, 20);
            this.arrivalPicker.TabIndex = 0;
            this.arrivalPicker.ValueChanged += new System.EventHandler(this.arrivalPicker_ValueChanged);
            // 
            // lunchtime
            // 
            this.lunchtime.Location = new System.Drawing.Point(52, 32);
            this.lunchtime.Name = "lunchtime";
            this.lunchtime.Size = new System.Drawing.Size(30, 20);
            this.lunchtime.TabIndex = 2;
            this.lunchtime.Text = "30";
            this.lunchtime.TextChanged += new System.EventHandler(this.lunchtime_TextChanged);
            this.lunchtime.Enter += new System.EventHandler(this.lunchtime_Enter);
            this.lunchtime.Leave += new System.EventHandler(this.lunchtime_Leave);
            this.lunchtime.Validating += new System.ComponentModel.CancelEventHandler(this.lunchtime_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "minutes";
            // 
            // departurePicker
            // 
            this.departurePicker.CustomFormat = "HH:mm";
            this.departurePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departurePicker.Location = new System.Drawing.Point(86, 16);
            this.departurePicker.Name = "departurePicker";
            this.departurePicker.ShowUpDown = true;
            this.departurePicker.Size = new System.Drawing.Size(61, 20);
            this.departurePicker.TabIndex = 1;
            this.departurePicker.ValueChanged += new System.EventHandler(this.departurePicker_ValueChanged);
            // 
            // goneHome
            // 
            this.goneHome.AutoSize = true;
            this.goneHome.Location = new System.Drawing.Point(12, 102);
            this.goneHome.Name = "goneHome";
            this.goneHome.Size = new System.Drawing.Size(112, 17);
            this.goneHome.TabIndex = 2;
            this.goneHome.Text = "I have gone home";
            this.goneHome.UseVisualStyleBackColor = true;
            this.goneHome.CheckedChanged += new System.EventHandler(this.goneHome_CheckedChanged);
            // 
            // departureBox
            // 
            this.departureBox.Controls.Add(this.nextDayButton);
            this.departureBox.Controls.Add(this.label3);
            this.departureBox.Controls.Add(this.departurePicker);
            this.departureBox.Enabled = false;
            this.departureBox.Location = new System.Drawing.Point(12, 125);
            this.departureBox.Name = "departureBox";
            this.departureBox.Size = new System.Drawing.Size(248, 46);
            this.departureBox.TabIndex = 3;
            this.departureBox.TabStop = false;
            this.departureBox.Text = "Departure:";
            // 
            // nextDayButton
            // 
            this.nextDayButton.AutoSize = true;
            this.nextDayButton.Location = new System.Drawing.Point(154, 18);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(66, 17);
            this.nextDayButton.TabIndex = 3;
            this.nextDayButton.Text = "next day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.CheckedChanged += new System.EventHandler(this.nextDayButton_CheckedChanged);
            // 
            // arrivalBox
            // 
            this.arrivalBox.Controls.Add(this.setTimeToNowButton);
            this.arrivalBox.Controls.Add(this.label1);
            this.arrivalBox.Controls.Add(this.label2);
            this.arrivalBox.Controls.Add(this.arrivalPicker);
            this.arrivalBox.Controls.Add(this.label4);
            this.arrivalBox.Controls.Add(this.lunchtime);
            this.arrivalBox.Location = new System.Drawing.Point(12, 27);
            this.arrivalBox.Name = "arrivalBox";
            this.arrivalBox.Size = new System.Drawing.Size(248, 68);
            this.arrivalBox.TabIndex = 1;
            this.arrivalBox.TabStop = false;
            this.arrivalBox.Text = "Arrival:";
            // 
            // setTimeToNowButton
            // 
            this.setTimeToNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimeToNowButton.Location = new System.Drawing.Point(173, 10);
            this.setTimeToNowButton.Margin = new System.Windows.Forms.Padding(0);
            this.setTimeToNowButton.Name = "setTimeToNowButton";
            this.setTimeToNowButton.Size = new System.Drawing.Size(75, 23);
            this.setTimeToNowButton.TabIndex = 1;
            this.setTimeToNowButton.Text = "Now";
            this.setTimeToNowButton.UseVisualStyleBackColor = true;
            this.setTimeToNowButton.Click += new System.EventHandler(this.setTimeToNowButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(9, 184);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(74, 16);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "resultLabel";
            // 
            // lunchtimeError
            // 
            this.lunchtimeError.ContainerControl = this;
            // 
            // robinTime
            // 
            this.robinTime.AutoSize = true;
            this.robinTime.Location = new System.Drawing.Point(12, 204);
            this.robinTime.Name = "robinTime";
            this.robinTime.Size = new System.Drawing.Size(53, 13);
            this.robinTime.TabIndex = 11;
            this.robinTime.Text = "robinTime";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "&?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem1.Text = "&Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem3.Text = "&?";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // flexField
            // 
            this.flexField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flexField.AutoSize = true;
            this.flexField.Location = new System.Drawing.Point(12, 230);
            this.flexField.Name = "flexField";
            this.flexField.Size = new System.Drawing.Size(23, 13);
            this.flexField.TabIndex = 13;
            this.flexField.Text = "flex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 252);
            this.Controls.Add(this.flexField);
            this.Controls.Add(this.robinTime);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.arrivalBox);
            this.Controls.Add(this.departureBox);
            this.Controls.Add(this.goneHome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "When can I go home?";
            this.departureBox.ResumeLayout(false);
            this.departureBox.PerformLayout();
            this.arrivalBox.ResumeLayout(false);
            this.arrivalBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lunchtimeError)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker arrivalPicker;
        private System.Windows.Forms.TextBox lunchtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker departurePicker;
        private System.Windows.Forms.CheckBox goneHome;
        private System.Windows.Forms.GroupBox departureBox;
        private System.Windows.Forms.GroupBox arrivalBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ErrorProvider lunchtimeError;
        private System.Windows.Forms.Label robinTime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label flexField;
        private System.Windows.Forms.Button setTimeToNowButton;
        private System.Windows.Forms.CheckBox nextDayButton;
    }
}

