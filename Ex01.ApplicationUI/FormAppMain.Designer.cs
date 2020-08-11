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
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.f_EventpictureBox = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.f_UserWellcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.f_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.f_ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.f_fetchEventsButton = new System.Windows.Forms.LinkLabel();
            this.f_Postbutton = new System.Windows.Forms.Button();
            this.f_lastPostStaus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loadingCircle1 = new MRG.Controls.UI.LoadingCircle();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_smallPictureBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).BeginInit();
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
            this.comboBoxActionType.Location = new System.Drawing.Point(160, 9);
            this.comboBoxActionType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(219, 24);
            this.comboBoxActionType.TabIndex = 23;
            // 
            // linkUserActions
            // 
            this.linkUserActions.AutoSize = true;
            this.linkUserActions.Location = new System.Drawing.Point(11, 11);
            this.linkUserActions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUserActions.Name = "linkUserActions";
            this.linkUserActions.Size = new System.Drawing.Size(127, 17);
            this.linkUserActions.TabIndex = 14;
            this.linkUserActions.TabStop = true;
            this.linkUserActions.Text = "Fetch User Actions";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxActionType);
            this.tabPage2.Controls.Add(this.dataGridViewActions);
            this.tabPage2.Controls.Add(this.linkUserActions);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(877, 661);
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
            this.dataGridViewActions.Location = new System.Drawing.Point(15, 41);
            this.dataGridViewActions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.RowHeadersWidth = 51;
            this.dataGridViewActions.Size = new System.Drawing.Size(1097, 875);
            this.dataGridViewActions.TabIndex = 22;
            // 
            // cover_smallPictureBox
            // 
            this.cover_smallPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cover_smallPictureBox.Location = new System.Drawing.Point(8, 82);
            this.cover_smallPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cover_smallPictureBox.Name = "cover_smallPictureBox";
            this.cover_smallPictureBox.Size = new System.Drawing.Size(868, 172);
            this.cover_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover_smallPictureBox.TabIndex = 54;
            this.cover_smallPictureBox.TabStop = false;
            // 
            // f_CheckinsButton
            // 
            this.f_CheckinsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.f_CheckinsButton.Location = new System.Drawing.Point(439, 16);
            this.f_CheckinsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f_CheckinsButton.Name = "f_CheckinsButton";
            this.f_CheckinsButton.Size = new System.Drawing.Size(125, 23);
            this.f_CheckinsButton.TabIndex = 53;
            this.f_CheckinsButton.Text = "Show Chekins";
            this.f_CheckinsButton.UseVisualStyleBackColor = true;
            this.f_CheckinsButton.Click += new System.EventHandler(this.f_CheckinsButton_Click);
            // 
            // f_ShowFriendsButton
            // 
            this.f_ShowFriendsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.f_ShowFriendsButton.Location = new System.Drawing.Point(292, 16);
            this.f_ShowFriendsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f_ShowFriendsButton.Name = "f_ShowFriendsButton";
            this.f_ShowFriendsButton.Size = new System.Drawing.Size(128, 23);
            this.f_ShowFriendsButton.TabIndex = 52;
            this.f_ShowFriendsButton.Text = "Show Friends";
            this.f_ShowFriendsButton.UseVisualStyleBackColor = true;
            this.f_ShowFriendsButton.Click += new System.EventHandler(this.f_ShowFriendsButton_Click);
            // 
            // f_PostCommentslistBox
            // 
            this.f_PostCommentslistBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.f_PostCommentslistBox.DisplayMember = "name";
            this.f_PostCommentslistBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_PostCommentslistBox.FormattingEnabled = true;
            this.f_PostCommentslistBox.HorizontalScrollbar = true;
            this.f_PostCommentslistBox.ItemHeight = 24;
            this.f_PostCommentslistBox.Location = new System.Drawing.Point(560, 394);
            this.f_PostCommentslistBox.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.f_PostCommentslistBox.Name = "f_PostCommentslistBox";
            this.f_PostCommentslistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_PostCommentslistBox.Size = new System.Drawing.Size(237, 124);
            this.f_PostCommentslistBox.TabIndex = 51;
            // 
            // linkPosts
            // 
            this.linkPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPosts.AutoSize = true;
            this.linkPosts.Location = new System.Drawing.Point(25, 302);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(82, 17);
            this.linkPosts.TabIndex = 49;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Fetch Posts";
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loadingCircle1);
            this.tabPage1.Controls.Add(this.f_CheckinsButton);
            this.tabPage1.Controls.Add(this.f_ShowFriendsButton);
            this.tabPage1.Controls.Add(this.linkPosts);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.f_EventpictureBox);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.f_UserWellcome);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.f_RememberMeCheckBox);
            this.tabPage1.Controls.Add(this.f_ProfilePictureBox);
            this.tabPage1.Controls.Add(this.f_PostCommentslistBox);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.f_fetchEventsButton);
            this.tabPage1.Controls.Add(this.f_Postbutton);
            this.tabPage1.Controls.Add(this.f_lastPostStaus);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cover_smallPictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(877, 661);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.HorizontalScrollbar = true;
            this.listBoxPosts.ItemHeight = 24;
            this.listBoxPosts.Location = new System.Drawing.Point(25, 320);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.listBoxPosts.MaximumSize = new System.Drawing.Size(532, 148);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxPosts.Size = new System.Drawing.Size(532, 124);
            this.listBoxPosts.TabIndex = 40;
            // 
            // f_EventpictureBox
            // 
            this.f_EventpictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.f_EventpictureBox.Location = new System.Drawing.Point(701, 271);
            this.f_EventpictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.f_EventpictureBox.Name = "f_EventpictureBox";
            this.f_EventpictureBox.Size = new System.Drawing.Size(99, 84);
            this.f_EventpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f_EventpictureBox.TabIndex = 42;
            this.f_EventpictureBox.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(25, 16);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 28);
            this.buttonLogin.TabIndex = 59;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // f_UserWellcome
            // 
            this.f_UserWellcome.AutoSize = true;
            this.f_UserWellcome.Location = new System.Drawing.Point(75, 585);
            this.f_UserWellcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.f_UserWellcome.Name = "f_UserWellcome";
            this.f_UserWellcome.Size = new System.Drawing.Size(0, 17);
            this.f_UserWellcome.TabIndex = 57;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(733, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 28);
            this.buttonLogout.TabIndex = 56;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // f_RememberMeCheckBox
            // 
            this.f_RememberMeCheckBox.AutoSize = true;
            this.f_RememberMeCheckBox.Location = new System.Drawing.Point(133, 21);
            this.f_RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.f_RememberMeCheckBox.Name = "f_RememberMeCheckBox";
            this.f_RememberMeCheckBox.Size = new System.Drawing.Size(122, 21);
            this.f_RememberMeCheckBox.TabIndex = 55;
            this.f_RememberMeCheckBox.Text = "Remember me";
            this.f_RememberMeCheckBox.UseVisualStyleBackColor = true;
            this.f_RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // f_ProfilePictureBox
            // 
            this.f_ProfilePictureBox.Location = new System.Drawing.Point(40, 98);
            this.f_ProfilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_ProfilePictureBox.Name = "f_ProfilePictureBox";
            this.f_ProfilePictureBox.Size = new System.Drawing.Size(184, 192);
            this.f_ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.f_ProfilePictureBox.TabIndex = 41;
            this.f_ProfilePictureBox.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.HorizontalScrollbar = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(25, 492);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.listBoxEvents.MaximumSize = new System.Drawing.Size(532, 148);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxEvents.Size = new System.Drawing.Size(532, 148);
            this.listBoxEvents.TabIndex = 40;
            // 
            // f_fetchEventsButton
            // 
            this.f_fetchEventsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.f_fetchEventsButton.AutoSize = true;
            this.f_fetchEventsButton.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.f_fetchEventsButton.Location = new System.Drawing.Point(25, 474);
            this.f_fetchEventsButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f_fetchEventsButton.Name = "f_fetchEventsButton";
            this.f_fetchEventsButton.Size = new System.Drawing.Size(94, 17);
            this.f_fetchEventsButton.TabIndex = 48;
            this.f_fetchEventsButton.TabStop = true;
            this.f_fetchEventsButton.Text = "Fetch Events ";
            this.f_fetchEventsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.f_fetchEventsButton_LinkClicked);
            // 
            // f_Postbutton
            // 
            this.f_Postbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_Postbutton.Location = new System.Drawing.Point(509, 279);
            this.f_Postbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_Postbutton.Name = "f_Postbutton";
            this.f_Postbutton.Size = new System.Drawing.Size(100, 28);
            this.f_Postbutton.TabIndex = 46;
            this.f_Postbutton.Text = "Post";
            this.f_Postbutton.UseVisualStyleBackColor = true;
            // 
            // f_lastPostStaus
            // 
            this.f_lastPostStaus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f_lastPostStaus.Location = new System.Drawing.Point(377, 279);
            this.f_lastPostStaus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_lastPostStaus.Name = "f_lastPostStaus";
            this.f_lastPostStaus.Size = new System.Drawing.Size(121, 22);
            this.f_lastPostStaus.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Post Status:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 690);
            this.tabControl1.TabIndex = 52;
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = false;
            this.loadingCircle1.Color = System.Drawing.Color.SkyBlue;
            this.loadingCircle1.InnerCircleRadius = 8;
            this.loadingCircle1.Location = new System.Drawing.Point(641, 40);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 10;
            this.loadingCircle1.OuterCircleRadius = 10;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(75, 23);
            this.loadingCircle1.SpokeThickness = 4;
            this.loadingCircle1.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle1.TabIndex = 60;
            this.loadingCircle1.Text = "loadingCircle1";
            // 
            // FormAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 690);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAppMain";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_smallPictureBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.f_EventpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_ProfilePictureBox)).EndInit();
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
        private MRG.Controls.UI.LoadingCircle loadingCircle1;
    }
}