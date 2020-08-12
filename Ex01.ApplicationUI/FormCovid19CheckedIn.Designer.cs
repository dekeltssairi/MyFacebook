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
            this.SuspendLayout();
            // 
            // Locations_listBox
            // 
            this.Locations_listBox.FormattingEnabled = true;
            this.Locations_listBox.ItemHeight = 31;
            this.Locations_listBox.Location = new System.Drawing.Point(51, 231);
            this.Locations_listBox.Name = "Locations_listBox";
            this.Locations_listBox.Size = new System.Drawing.Size(1236, 407);
            this.Locations_listBox.TabIndex = 0;
            // 
            // MyCheckins_button
            // 
            this.MyCheckins_button.Location = new System.Drawing.Point(42, 28);
            this.MyCheckins_button.Name = "MyCheckins_button";
            this.MyCheckins_button.Size = new System.Drawing.Size(307, 81);
            this.MyCheckins_button.TabIndex = 1;
            this.MyCheckins_button.Text = "My Checkins";
            this.MyCheckins_button.UseVisualStyleBackColor = true;
            this.MyCheckins_button.Click += new System.EventHandler(this.MyCheckins_button_Click);
            // 
            // CheckUserLocation_button
            // 
            this.CheckUserLocation_button.Location = new System.Drawing.Point(638, 660);
            this.CheckUserLocation_button.Name = "CheckUserLocation_button";
            this.CheckUserLocation_button.Size = new System.Drawing.Size(167, 170);
            this.CheckUserLocation_button.TabIndex = 2;
            this.CheckUserLocation_button.Text = "Check The Location";
            this.CheckUserLocation_button.UseVisualStyleBackColor = true;
            this.CheckUserLocation_button.Click += new System.EventHandler(this.CheckUserLocation_button_Click);
            // 
            // LocationDescription_textBox
            // 
            this.LocationDescription_textBox.Location = new System.Drawing.Point(811, 861);
            this.LocationDescription_textBox.Name = "LocationDescription_textBox";
            this.LocationDescription_textBox.Size = new System.Drawing.Size(467, 38);
            this.LocationDescription_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 861);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // LocationTimeToCheck_dateTimePicker
            // 
            this.LocationTimeToCheck_dateTimePicker.Location = new System.Drawing.Point(811, 922);
            this.LocationTimeToCheck_dateTimePicker.Name = "LocationTimeToCheck_dateTimePicker";
            this.LocationTimeToCheck_dateTimePicker.Size = new System.Drawing.Size(467, 38);
            this.LocationTimeToCheck_dateTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 928);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time:";
            // 
            // AddConfirmedSickLocation_button
            // 
            this.AddConfirmedSickLocation_button.Location = new System.Drawing.Point(1105, 660);
            this.AddConfirmedSickLocation_button.Name = "AddConfirmedSickLocation_button";
            this.AddConfirmedSickLocation_button.Size = new System.Drawing.Size(173, 170);
            this.AddConfirmedSickLocation_button.TabIndex = 7;
            this.AddConfirmedSickLocation_button.Text = "Add  A Confirmed Sick Location";
            this.AddConfirmedSickLocation_button.UseVisualStyleBackColor = true;
            this.AddConfirmedSickLocation_button.Click += new System.EventHandler(this.AddConfirmedSickLocation_button_Click);
            // 
            // CheckMyCheckins_button
            // 
            this.CheckMyCheckins_button.Location = new System.Drawing.Point(889, 28);
            this.CheckMyCheckins_button.Name = "CheckMyCheckins_button";
            this.CheckMyCheckins_button.Size = new System.Drawing.Size(389, 81);
            this.CheckMyCheckins_button.TabIndex = 8;
            this.CheckMyCheckins_button.Text = "Check My Checkins";
            this.CheckMyCheckins_button.UseVisualStyleBackColor = true;
            this.CheckMyCheckins_button.Click += new System.EventHandler(this.CheckMyCheckins_button_Click);
            // 
            // LoadSickList_button
            // 
            this.LoadSickList_button.Location = new System.Drawing.Point(384, 28);
            this.LoadSickList_button.Name = "LoadSickList_button";
            this.LoadSickList_button.Size = new System.Drawing.Size(482, 81);
            this.LoadSickList_button.TabIndex = 9;
            this.LoadSickList_button.Text = "Load Confirmed Sick Locations";
            this.LoadSickList_button.UseVisualStyleBackColor = true;
            this.LoadSickList_button.Click += new System.EventHandler(this.LoadSickList_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(883, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status:";
            // 
            // ResultStatus_label
            // 
            this.ResultStatus_label.AutoSize = true;
            this.ResultStatus_label.Location = new System.Drawing.Point(894, 746);
            this.ResultStatus_label.Name = "ResultStatus_label";
            this.ResultStatus_label.Size = new System.Drawing.Size(93, 32);
            this.ResultStatus_label.TabIndex = 11;
            this.ResultStatus_label.Text = "label4";
            // 
            // Friends_listBox
            // 
            this.Friends_listBox.FormattingEnabled = true;
            this.Friends_listBox.ItemHeight = 31;
            this.Friends_listBox.Location = new System.Drawing.Point(51, 682);
            this.Friends_listBox.Name = "Friends_listBox";
            this.Friends_listBox.Size = new System.Drawing.Size(276, 345);
            this.Friends_listBox.TabIndex = 12;
            // 
            // FormCovid19CheckedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 1094);
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
            this.Name = "FormCovid19CheckedIn";
            this.Text = "FormCovid19CheckedIn";
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
    }
}