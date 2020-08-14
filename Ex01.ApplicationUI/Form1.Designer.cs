namespace Ex01.ApplicationUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonShowMyEvents = new System.Windows.Forms.Button();
            this.buttonShowMyPost = new System.Windows.Forms.Button();
            this.helloUserLabel = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.f_EventpictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.f_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.f_ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.f_lastPostStaus = new System.Windows.Forms.TextBox();
            this.f_PostCommentslistBox = new System.Windows.Forms.ListBox();
            this.buttonMostDiggingFriend = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.Covid19_button = new System.Windows.Forms.Button();
            this.f_CheckinsButton = new System.Windows.Forms.Button();
            this.f_ShowFriendsButton = new System.Windows.Forms.Button();
            this.f_Postbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowMyEvents);
            this.splitContainer1.Panel1.Controls.Add(this.buttonShowMyPost);
            this.splitContainer1.Panel1.Controls.Add(this.helloUserLabel);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxEvents);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.f_EventpictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLogin);
            this.splitContainer1.Panel1.Controls.Add(this.f_RememberMeCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.f_ProfilePictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.f_lastPostStaus);
            this.splitContainer1.Panel2.Controls.Add(this.f_PostCommentslistBox);
            this.splitContainer1.Panel2.Controls.Add(this.buttonMostDiggingFriend);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLogout);
            this.splitContainer1.Panel2.Controls.Add(this.Covid19_button);
            this.splitContainer1.Panel2.Controls.Add(this.f_CheckinsButton);
            this.splitContainer1.Panel2.Controls.Add(this.f_ShowFriendsButton);
            this.splitContainer1.Panel2.Controls.Add(this.f_Postbutton);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Size = new System.Drawing.Size(1392, 730);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex01.ApplicationUI.Properties.Resources.people;
            this.pictureBox2.Location = new System.Drawing.Point(15, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // buttonShowMyEvents
            // 
            this.buttonShowMyEvents.Location = new System.Drawing.Point(12, 572);
            this.buttonShowMyEvents.Name = "buttonShowMyEvents";
            this.buttonShowMyEvents.Size = new System.Drawing.Size(253, 23);
            this.buttonShowMyEvents.TabIndex = 92;
            this.buttonShowMyEvents.Text = "Show My Events!";
            this.buttonShowMyEvents.UseVisualStyleBackColor = true;
            this.buttonShowMyEvents.Click += new System.EventHandler(this.buttonShowMyEvents_Click);
            // 
            // buttonShowMyPost
            // 
            this.buttonShowMyPost.Location = new System.Drawing.Point(10, 421);
            this.buttonShowMyPost.Name = "buttonShowMyPost";
            this.buttonShowMyPost.Size = new System.Drawing.Size(253, 23);
            this.buttonShowMyPost.TabIndex = 91;
            this.buttonShowMyPost.Text = "Show My Post!";
            this.buttonShowMyPost.UseVisualStyleBackColor = true;
            this.buttonShowMyPost.Click += new System.EventHandler(this.buttonShowMyPost_Click);
            // 
            // helloUserLabel
            // 
            this.helloUserLabel.AutoSize = true;
            this.helloUserLabel.Location = new System.Drawing.Point(9, 132);
            this.helloUserLabel.Name = "helloUserLabel";
            this.helloUserLabel.Size = new System.Drawing.Size(70, 17);
            this.helloUserLabel.TabIndex = 90;
            this.helloUserLabel.Text = "hello user";
            this.helloUserLabel.UseMnemonic = false;
            this.helloUserLabel.Visible = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(15, 601);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(250, 116);
            this.listBoxEvents.TabIndex = 89;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 450);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 116);
            this.listBox1.TabIndex = 88;
            // 
            // f_EventpictureBox
            // 
            this.f_EventpictureBox.Location = new System.Drawing.Point(12, 171);
            this.f_EventpictureBox.Name = "f_EventpictureBox";
            this.f_EventpictureBox.Size = new System.Drawing.Size(178, 50);
            this.f_EventpictureBox.TabIndex = 87;
            this.f_EventpictureBox.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(57, 21);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 35);
            this.buttonLogin.TabIndex = 86;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // f_RememberMeCheckBox
            // 
            this.f_RememberMeCheckBox.AutoSize = true;
            this.f_RememberMeCheckBox.Location = new System.Drawing.Point(12, 84);
            this.f_RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.f_RememberMeCheckBox.Name = "f_RememberMeCheckBox";
            this.f_RememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.f_RememberMeCheckBox.TabIndex = 85;
            this.f_RememberMeCheckBox.Text = "Remember me";
            this.f_RememberMeCheckBox.UseVisualStyleBackColor = true;
            this.f_RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // f_ProfilePictureBox
            // 
            this.f_ProfilePictureBox.Location = new System.Drawing.Point(12, 228);
            this.f_ProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.f_ProfilePictureBox.Name = "f_ProfilePictureBox";
            this.f_ProfilePictureBox.Size = new System.Drawing.Size(178, 172);
            this.f_ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f_ProfilePictureBox.TabIndex = 84;
            this.f_ProfilePictureBox.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex01.ApplicationUI.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(1022, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex01.ApplicationUI.Properties.Resources.facebook_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 198);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 509);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 99);
            this.textBox1.TabIndex = 94;
            // 
            // f_lastPostStaus
            // 
            this.f_lastPostStaus.Location = new System.Drawing.Point(151, 240);
            this.f_lastPostStaus.Multiline = true;
            this.f_lastPostStaus.Name = "f_lastPostStaus";
            this.f_lastPostStaus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.f_lastPostStaus.Size = new System.Drawing.Size(485, 160);
            this.f_lastPostStaus.TabIndex = 93;
            // 
            // f_PostCommentslistBox
            // 
            this.f_PostCommentslistBox.FormattingEnabled = true;
            this.f_PostCommentslistBox.ItemHeight = 16;
            this.f_PostCommentslistBox.Location = new System.Drawing.Point(402, 444);
            this.f_PostCommentslistBox.Name = "f_PostCommentslistBox";
            this.f_PostCommentslistBox.Size = new System.Drawing.Size(234, 164);
            this.f_PostCommentslistBox.TabIndex = 92;
            // 
            // buttonMostDiggingFriend
            // 
            this.buttonMostDiggingFriend.Location = new System.Drawing.Point(861, 331);
            this.buttonMostDiggingFriend.Name = "buttonMostDiggingFriend";
            this.buttonMostDiggingFriend.Size = new System.Drawing.Size(196, 36);
            this.buttonMostDiggingFriend.TabIndex = 91;
            this.buttonMostDiggingFriend.Text = "Show Most digging friend";
            this.buttonMostDiggingFriend.UseVisualStyleBackColor = true;
            this.buttonMostDiggingFriend.Click += new System.EventHandler(this.buttonMostDiggingFriend_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(888, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 35);
            this.buttonLogout.TabIndex = 90;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Covid19_button
            // 
            this.Covid19_button.Location = new System.Drawing.Point(861, 389);
            this.Covid19_button.Name = "Covid19_button";
            this.Covid19_button.Size = new System.Drawing.Size(196, 34);
            this.Covid19_button.TabIndex = 89;
            this.Covid19_button.Text = "Covid-19 Location checks";
            this.Covid19_button.UseVisualStyleBackColor = true;
            this.Covid19_button.Click += new System.EventHandler(this.Covid19_button_Click);
            // 
            // f_CheckinsButton
            // 
            this.f_CheckinsButton.CausesValidation = false;
            this.f_CheckinsButton.Location = new System.Drawing.Point(861, 281);
            this.f_CheckinsButton.Name = "f_CheckinsButton";
            this.f_CheckinsButton.Size = new System.Drawing.Size(196, 23);
            this.f_CheckinsButton.TabIndex = 88;
            this.f_CheckinsButton.Text = "Show checkins";
            this.f_CheckinsButton.UseVisualStyleBackColor = true;
            this.f_CheckinsButton.Click += new System.EventHandler(this.f_CheckinsButton_Click);
            // 
            // f_ShowFriendsButton
            // 
            this.f_ShowFriendsButton.Location = new System.Drawing.Point(861, 240);
            this.f_ShowFriendsButton.Name = "f_ShowFriendsButton";
            this.f_ShowFriendsButton.Size = new System.Drawing.Size(196, 23);
            this.f_ShowFriendsButton.TabIndex = 87;
            this.f_ShowFriendsButton.Text = "Show Friends";
            this.f_ShowFriendsButton.UseVisualStyleBackColor = true;
            this.f_ShowFriendsButton.Click += new System.EventHandler(this.f_ShowFriendsButton_Click);
            // 
            // f_Postbutton
            // 
            this.f_Postbutton.Location = new System.Drawing.Point(561, 400);
            this.f_Postbutton.Name = "f_Postbutton";
            this.f_Postbutton.Size = new System.Drawing.Size(75, 23);
            this.f_Postbutton.TabIndex = 86;
            this.f_Postbutton.Text = "Post";
            this.f_Postbutton.UseVisualStyleBackColor = true;
            this.f_Postbutton.Click += new System.EventHandler(this.f_Postbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Post Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 730);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonShowMyEvents;
        private System.Windows.Forms.Button buttonShowMyPost;
        private System.Windows.Forms.Label helloUserLabel;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox f_EventpictureBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox f_RememberMeCheckBox;
        private System.Windows.Forms.PictureBox f_ProfilePictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox f_lastPostStaus;
        private System.Windows.Forms.ListBox f_PostCommentslistBox;
        private System.Windows.Forms.Button buttonMostDiggingFriend;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button Covid19_button;
        private System.Windows.Forms.Button f_CheckinsButton;
        private System.Windows.Forms.Button f_ShowFriendsButton;
        private System.Windows.Forms.Button f_Postbutton;
        private System.Windows.Forms.Label label1;
    }
}