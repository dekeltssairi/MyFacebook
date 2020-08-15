namespace Ex01.ApplicationUI
{
    partial class FormCovid19CheckedIn
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
            this.Locations_listBox = new System.Windows.Forms.ListBox();
            this.MyCheckins_button = new System.Windows.Forms.Button();
            this.CheckUserLocation_button = new System.Windows.Forms.Button();
            this.LocationDescription_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocationTimeToCheck_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddConfirmedSickLocation_button = new System.Windows.Forms.Button();
            this.CheckMyCheckins_button = new System.Windows.Forms.Button();
            this.LoadSickList_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultStatus_label = new System.Windows.Forms.Label();
            this.Friends_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Hour_textBox = new System.Windows.Forms.TextBox();
            this.Minute_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Second_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loadFriend_button = new System.Windows.Forms.Button();
            this.ConfirmedSickLocations_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Locations_listBox
            // 
            this.Locations_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Locations_listBox.FormattingEnabled = true;
            this.Locations_listBox.ItemHeight = 31;
            this.Locations_listBox.Location = new System.Drawing.Point(628, 127);
            this.Locations_listBox.Name = "Locations_listBox";
            this.Locations_listBox.Size = new System.Drawing.Size(929, 407);
            this.Locations_listBox.TabIndex = 0;
            this.Locations_listBox.SelectedIndexChanged += new System.EventHandler(this.Locations_listBox_SelectedIndexChanged);
            // 
            // MyCheckins_button
            // 
            this.MyCheckins_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyCheckins_button.Location = new System.Drawing.Point(628, 28);
            this.MyCheckins_button.Name = "MyCheckins_button";
            this.MyCheckins_button.Size = new System.Drawing.Size(307, 81);
            this.MyCheckins_button.TabIndex = 1;
            this.MyCheckins_button.Text = "My Checkins";
            this.MyCheckins_button.UseVisualStyleBackColor = true;
            this.MyCheckins_button.Click += new System.EventHandler(this.MyCheckins_button_Click);
            // 
            // CheckUserLocation_button
            // 
            this.CheckUserLocation_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckUserLocation_button.Location = new System.Drawing.Point(808, 572);
            this.CheckUserLocation_button.Name = "CheckUserLocation_button";
            this.CheckUserLocation_button.Size = new System.Drawing.Size(173, 170);
            this.CheckUserLocation_button.TabIndex = 2;
            this.CheckUserLocation_button.Text = "Check The Location";
            this.CheckUserLocation_button.UseVisualStyleBackColor = true;
            this.CheckUserLocation_button.Click += new System.EventHandler(this.CheckUserLocation_button_Click);
            // 
            // LocationDescription_textBox
            // 
            this.LocationDescription_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationDescription_textBox.Location = new System.Drawing.Point(203, 758);
            this.LocationDescription_textBox.Name = "LocationDescription_textBox";
            this.LocationDescription_textBox.Size = new System.Drawing.Size(467, 38);
            this.LocationDescription_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 761);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // LocationTimeToCheck_dateTimePicker
            // 
            this.LocationTimeToCheck_dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocationTimeToCheck_dateTimePicker.Location = new System.Drawing.Point(203, 825);
            this.LocationTimeToCheck_dateTimePicker.Name = "LocationTimeToCheck_dateTimePicker";
            this.LocationTimeToCheck_dateTimePicker.Size = new System.Drawing.Size(467, 38);
            this.LocationTimeToCheck_dateTimePicker.TabIndex = 5;
            this.LocationTimeToCheck_dateTimePicker.Value = new System.DateTime(2020, 9, 9, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 892);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time: (h:m:s)";
            // 
            // AddConfirmedSickLocation_button
            // 
            this.AddConfirmedSickLocation_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddConfirmedSickLocation_button.Location = new System.Drawing.Point(808, 764);
            this.AddConfirmedSickLocation_button.Name = "AddConfirmedSickLocation_button";
            this.AddConfirmedSickLocation_button.Size = new System.Drawing.Size(173, 170);
            this.AddConfirmedSickLocation_button.TabIndex = 7;
            this.AddConfirmedSickLocation_button.Text = "Add  A Confirmed Sick Location";
            this.AddConfirmedSickLocation_button.UseVisualStyleBackColor = true;
            this.AddConfirmedSickLocation_button.Click += new System.EventHandler(this.AddConfirmedSickLocation_button_Click);
            // 
            // CheckMyCheckins_button
            // 
            this.CheckMyCheckins_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckMyCheckins_button.Location = new System.Drawing.Point(1158, 28);
            this.CheckMyCheckins_button.Name = "CheckMyCheckins_button";
            this.CheckMyCheckins_button.Size = new System.Drawing.Size(389, 81);
            this.CheckMyCheckins_button.TabIndex = 8;
            this.CheckMyCheckins_button.Text = "Check My Checkins";
            this.CheckMyCheckins_button.UseVisualStyleBackColor = true;
            this.CheckMyCheckins_button.Click += new System.EventHandler(this.CheckMyCheckins_button_Click);
            // 
            // LoadSickList_button
            // 
            this.LoadSickList_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSickList_button.Location = new System.Drawing.Point(1081, 572);
            this.LoadSickList_button.Name = "LoadSickList_button";
            this.LoadSickList_button.Size = new System.Drawing.Size(476, 63);
            this.LoadSickList_button.TabIndex = 9;
            this.LoadSickList_button.Text = "Load Confirmed Sick Locations";
            this.LoadSickList_button.UseVisualStyleBackColor = true;
            this.LoadSickList_button.Click += new System.EventHandler(this.LoadSickList_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // ResultStatus_label
            // 
            this.ResultStatus_label.AutoSize = true;
            this.ResultStatus_label.Location = new System.Drawing.Point(150, 595);
            this.ResultStatus_label.Name = "ResultStatus_label";
            this.ResultStatus_label.Size = new System.Drawing.Size(0, 32);
            this.ResultStatus_label.TabIndex = 11;
            // 
            // Friends_listBox
            // 
            this.Friends_listBox.FormattingEnabled = true;
            this.Friends_listBox.ItemHeight = 31;
            this.Friends_listBox.Location = new System.Drawing.Point(26, 127);
            this.Friends_listBox.Name = "Friends_listBox";
            this.Friends_listBox.Size = new System.Drawing.Size(307, 407);
            this.Friends_listBox.TabIndex = 12;
            this.Friends_listBox.SelectedIndexChanged += new System.EventHandler(this.Friends_listBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 825);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date:";
            // 
            // Hour_textBox
            // 
            this.Hour_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Hour_textBox.Location = new System.Drawing.Point(206, 895);
            this.Hour_textBox.Name = "Hour_textBox";
            this.Hour_textBox.Size = new System.Drawing.Size(44, 38);
            this.Hour_textBox.TabIndex = 14;
            this.Hour_textBox.Text = "00";
            // 
            // Minute_textBox
            // 
            this.Minute_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Minute_textBox.Location = new System.Drawing.Point(285, 896);
            this.Minute_textBox.Name = "Minute_textBox";
            this.Minute_textBox.Size = new System.Drawing.Size(44, 38);
            this.Minute_textBox.TabIndex = 15;
            this.Minute_textBox.Text = "00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 896);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            // 
            // Second_TextBox
            // 
            this.Second_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Second_TextBox.Location = new System.Drawing.Point(370, 896);
            this.Second_TextBox.Name = "Second_TextBox";
            this.Second_TextBox.Size = new System.Drawing.Size(44, 38);
            this.Second_TextBox.TabIndex = 17;
            this.Second_TextBox.Text = "00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 896);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = ":";
            // 
            // loadFriend_button
            // 
            this.loadFriend_button.Location = new System.Drawing.Point(29, 28);
            this.loadFriend_button.Name = "loadFriend_button";
            this.loadFriend_button.Size = new System.Drawing.Size(221, 81);
            this.loadFriend_button.TabIndex = 19;
            this.loadFriend_button.Text = "Load Friends";
            this.loadFriend_button.UseVisualStyleBackColor = true;
            this.loadFriend_button.Click += new System.EventHandler(this.loadFriend_button_Click);
            // 
            // ConfirmedSickLocations_listBox
            // 
            this.ConfirmedSickLocations_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmedSickLocations_listBox.FormattingEnabled = true;
            this.ConfirmedSickLocations_listBox.ItemHeight = 31;
            this.ConfirmedSickLocations_listBox.Location = new System.Drawing.Point(1082, 676);
            this.ConfirmedSickLocations_listBox.Name = "ConfirmedSickLocations_listBox";
            this.ConfirmedSickLocations_listBox.Size = new System.Drawing.Size(475, 252);
            this.ConfirmedSickLocations_listBox.TabIndex = 20;
            // 
            // FormCovid19CheckedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1272);
            this.Controls.Add(this.ConfirmedSickLocations_listBox);
            this.Controls.Add(this.loadFriend_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Second_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Minute_textBox);
            this.Controls.Add(this.Hour_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Friends_listBox);
            this.Controls.Add(this.ResultStatus_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoadSickList_button);
            this.Controls.Add(this.CheckMyCheckins_button);
            this.Controls.Add(this.AddConfirmedSickLocation_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocationTimeToCheck_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationDescription_textBox);
            this.Controls.Add(this.CheckUserLocation_button);
            this.Controls.Add(this.MyCheckins_button);
            this.Controls.Add(this.Locations_listBox);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "FormCovid19CheckedIn";
            this.Text = "Covid19 CheckedIn Locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Locations_listBox;
        private System.Windows.Forms.Button MyCheckins_button;
        private System.Windows.Forms.Button CheckUserLocation_button;
        private System.Windows.Forms.TextBox LocationDescription_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker LocationTimeToCheck_dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddConfirmedSickLocation_button;
        private System.Windows.Forms.Button CheckMyCheckins_button;
        private System.Windows.Forms.Button LoadSickList_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ResultStatus_label;
        private System.Windows.Forms.ListBox Friends_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Hour_textBox;
        private System.Windows.Forms.TextBox Minute_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Second_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button loadFriend_button;
        private System.Windows.Forms.ListBox ConfirmedSickLocations_listBox;
    }
}