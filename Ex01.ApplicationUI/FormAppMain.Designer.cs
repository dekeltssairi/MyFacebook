namespace Ex01.ApplicationUI
{
    partial class FormAppMain
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
            this.comboBoxActionType = new System.Windows.Forms.ComboBox();
            this.linkUserActions = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.cover_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.f_CheckinsButton = new System.Windows.Forms.Button();
            this.f_ShowFriendsButton = new System.Windows.Forms.Button();
            this.f_PostCommentslistBox = new System.Windows.Forms.ListBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.f_UserWellcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.f_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.f_ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.f_EventpictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.f_fetchEventsButton = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.f_Postbutton = new System.Windows.Forms.Button();
            this.f_lastPostStaus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_smallPictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.FormattingEnabled = true;
            this.comboBoxActionType.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.comboBoxActionType.Location = new System.Drawing.Point(120, 7);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(165, 21);
            this.comboBoxActionType.TabIndex = 23;
            // 
            // linkUserActions
            // 
            this.linkUserActions.AutoSize = true;
            this.linkUserActions.Location = new System.Drawing.Point(8, 9);
            this.linkUserActions.Name = "linkUserActions";
            this.linkUserActions.Size = new System.Drawing.Size(97, 13);
            this.linkUserActions.TabIndex = 14;
            this.linkUserActions.TabStop = true;
            this.linkUserActions.Text = "Fetch User Actions";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxActionType);
            this.tabPage2.Controls.Add(this.dataGridViewActions);
            this.tabPage2.Controls.Add(this.linkUserActions);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(649, 545);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            this.dataGridViewActions.AllowUserToOrderColumns = true;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActions.Location = new System.Drawing.Point(11, 33);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.RowHeadersWidth = 51;
            this.dataGridViewActions.Size = new System.Drawing.Size(815, 571);
            this.dataGridViewActions.TabIndex = 22;
            // 
            // cover_smallPictureBox
            // 
            this.cover_smallPictureBox.Location = new System.Drawing.Point(6, 67);
            this.cover_smallPictureBox.Name = "cover_smallPictureBox";
            this.cover_smallPictureBox.Size = new System.Drawing.Size(195, 156);
            this.cover_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cover_smallPictureBox.TabIndex = 54;
            this.cover_smallPictureBox.TabStop = false;
            // 
            // f_CheckinsButton
            // 
            this.f_CheckinsButton.Location = new System.Drawing.Point(525, 85);
            this.f_CheckinsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.f_CheckinsButton.Name = "f_CheckinsButton";
            this.f_CheckinsButton.Size = new System.Drawing.Size(94, 19);
            this.f_CheckinsButton.TabIndex = 53;
            this.f_CheckinsButton.Text = "Show Chekins";
            this.f_CheckinsButton.UseVisualStyleBackColor = true;
            this.f_CheckinsButton.Click += new System.EventHandler(this.f_CheckinsButton_Click);
            // 
            // f_ShowFriendsButton
            // 
            this.f_ShowFriendsButton.Location = new System.Drawing.Point(525, 51);
            this.f_ShowFriendsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.f_ShowFriendsButton.Name = "f_ShowFriendsButton";
            this.f_ShowFriendsButton.Size = new System.Drawing.Size(96, 19);
            this.f_ShowFriendsButton.TabIndex = 52;
            this.f_ShowFriendsButton.Text = "Show Friends";
            this.f_ShowFriendsButton.UseVisualStyleBackColor = true;
            this.f_ShowFriendsButton.Click += new System.EventHandler(this.f_ShowFriendsButton_Click);
            // 
            // f_PostCommentslistBox
            // 
            this.f_PostCommentslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_PostCommentslistBox.DisplayMember = "name";
            this.f_PostCommentslistBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_PostCommentslistBox.FormattingEnabled = true;
            this.f_PostCommentslistBox.ItemHeight = 19;
            this.f_PostCommentslistBox.Location = new System.Drawing.Point(214, 393);
            this.f_PostCommentslistBox.Name = "f_PostCommentslistBox";
            this.f_PostCommentslistBox.Size = new System.Drawing.Size(172, 118);
            this.f_PostCommentslistBox.TabIndex = 51;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(213, 35);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(63, 13);
            this.linkPosts.TabIndex = 49;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.f_UserWellcome);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.f_RememberMeCheckBox);
            this.tabPage1.Controls.Add(this.cover_smallPictureBox);
            this.tabPage1.Controls.Add(this.f_ProfilePictureBox);
            this.tabPage1.Controls.Add(this.f_CheckinsButton);
            this.tabPage1.Controls.Add(this.f_ShowFriendsButton);
            this.tabPage1.Controls.Add(this.f_PostCommentslistBox);
            this.tabPage1.Controls.Add(this.f_EventpictureBox);
            this.tabPage1.Controls.Add(this.linkPosts);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.f_fetchEventsButton);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.f_Postbutton);
            this.tabPage1.Controls.Add(this.f_lastPostStaus);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(649, 395);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(19, 13);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 59;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // f_UserWellcome
            // 
            this.f_UserWellcome.AutoSize = true;
            this.f_UserWellcome.Location = new System.Drawing.Point(56, 475);
            this.f_UserWellcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.f_UserWellcome.Name = "f_UserWellcome";
            this.f_UserWellcome.Size = new System.Drawing.Size(0, 13);
            this.f_UserWellcome.TabIndex = 57;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(544, 514);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // f_RememberMeCheckBox
            // 
            this.f_RememberMeCheckBox.AutoSize = true;
            this.f_RememberMeCheckBox.Location = new System.Drawing.Point(17, 42);
            this.f_RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.f_RememberMeCheckBox.Name = "f_RememberMeCheckBox";
            this.f_RememberMeCheckBox.Size = new System.Drawing.Size(94, 17);
            this.f_RememberMeCheckBox.TabIndex = 55;
            this.f_RememberMeCheckBox.Text = "Remember me";
            this.f_RememberMeCheckBox.UseVisualStyleBackColor = true;
            this.f_RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // f_ProfilePictureBox
            // 
            this.f_ProfilePictureBox.Location = new System.Drawing.Point(30, 261);
            this.f_ProfilePictureBox.Name = "f_ProfilePictureBox";
            this.f_ProfilePictureBox.Size = new System.Drawing.Size(138, 156);
            this.f_ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f_ProfilePictureBox.TabIndex = 41;
            this.f_ProfilePictureBox.TabStop = false;
            // 
            // f_EventpictureBox
            // 
            this.f_EventpictureBox.Location = new System.Drawing.Point(526, 429);
            this.f_EventpictureBox.Name = "f_EventpictureBox";
            this.f_EventpictureBox.Size = new System.Drawing.Size(74, 68);
            this.f_EventpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f_EventpictureBox.TabIndex = 42;
            this.f_EventpictureBox.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(214, 241);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(280, 147);
            this.listBoxEvents.TabIndex = 40;
            // 
            // f_fetchEventsButton
            // 
            this.f_fetchEventsButton.AutoSize = true;
            this.f_fetchEventsButton.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.f_fetchEventsButton.Location = new System.Drawing.Point(214, 209);
            this.f_fetchEventsButton.Name = "f_fetchEventsButton";
            this.f_fetchEventsButton.Size = new System.Drawing.Size(190, 30);
            this.f_fetchEventsButton.TabIndex = 48;
            this.f_fetchEventsButton.TabStop = true;
            this.f_fetchEventsButton.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.f_fetchEventsButton.UseCompatibleTextRendering = true;
            this.f_fetchEventsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.f_fetchEventsButton_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 19;
            this.listBoxPosts.Location = new System.Drawing.Point(215, 51);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(280, 118);
            this.listBoxPosts.TabIndex = 40;
            // 
            // f_Postbutton
            // 
            this.f_Postbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_Postbutton.Location = new System.Drawing.Point(375, 7);
            this.f_Postbutton.Name = "f_Postbutton";
            this.f_Postbutton.Size = new System.Drawing.Size(75, 23);
            this.f_Postbutton.TabIndex = 46;
            this.f_Postbutton.Text = "Post";
            this.f_Postbutton.UseVisualStyleBackColor = true;
            // 
            // f_lastPostStaus
            // 
            this.f_lastPostStaus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_lastPostStaus.Location = new System.Drawing.Point(283, 8);
            this.f_lastPostStaus.Name = "f_lastPostStaus";
            this.f_lastPostStaus.Size = new System.Drawing.Size(85, 20);
            this.f_lastPostStaus.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Post Status:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 421);
            this.tabControl1.TabIndex = 52;
            // 
            // FormAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 421);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormAppMain";
            this.Text = "FormAppMain";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_smallPictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActionType;
        private System.Windows.Forms.LinkLabel linkUserActions;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.PictureBox cover_smallPictureBox;
        private System.Windows.Forms.Button f_CheckinsButton;
        private System.Windows.Forms.Button f_ShowFriendsButton;
        private System.Windows.Forms.ListBox f_PostCommentslistBox;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox f_ProfilePictureBox;
        private System.Windows.Forms.PictureBox f_EventpictureBox;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel f_fetchEventsButton;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button f_Postbutton;
        private System.Windows.Forms.TextBox f_lastPostStaus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox f_RememberMeCheckBox;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label f_UserWellcome;
        private System.Windows.Forms.Button buttonLogin;
    }
}