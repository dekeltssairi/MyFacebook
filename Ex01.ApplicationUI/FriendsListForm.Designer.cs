using System;

namespace Ex01.ApplicationUI
{
    partial class FriendsListForm
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
            this.f_FriendsListBox = new System.Windows.Forms.ListBox();
            this.f_PictureBox = new System.Windows.Forms.PictureBox();
            this.f_PostListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // f_FriendsListBox
            // 
            this.f_FriendsListBox.FormattingEnabled = true;
            this.f_FriendsListBox.ItemHeight = 16;
            this.f_FriendsListBox.Location = new System.Drawing.Point(45, 32);
            this.f_FriendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_FriendsListBox.Name = "f_FriendsListBox";
            this.f_FriendsListBox.Size = new System.Drawing.Size(192, 148);
            this.f_FriendsListBox.TabIndex = 0;
            this.f_FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // f_PictureBox
            // 
            this.f_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.f_PictureBox.Location = new System.Drawing.Point(565, 33);
            this.f_PictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_PictureBox.Name = "f_PictureBox";
            this.f_PictureBox.Size = new System.Drawing.Size(191, 148);
            this.f_PictureBox.TabIndex = 1;
            this.f_PictureBox.TabStop = false;
            // 
            // f_PostListBox
            // 
            this.f_PostListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.f_PostListBox.FormattingEnabled = true;
            this.f_PostListBox.HorizontalScrollbar = true;
            this.f_PostListBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.f_PostListBox.ItemHeight = 16;
            this.f_PostListBox.Location = new System.Drawing.Point(45, 207);
            this.f_PostListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.f_PostListBox.MaximumSize = new System.Drawing.Size(1332, 148);
            this.f_PostListBox.Name = "f_PostListBox";
            this.f_PostListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.f_PostListBox.Size = new System.Drawing.Size(709, 148);
            this.f_PostListBox.TabIndex = 2;
            this.f_PostListBox.UseWaitCursor = true;
            // 
            // FriendsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f_PostListBox);
            this.Controls.Add(this.f_PictureBox);
            this.Controls.Add(this.f_FriendsListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FriendsListForm";
            this.Text = "FriendsListForm";
            ((System.ComponentModel.ISupportInitialize)(this.f_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ListBox f_FriendsListBox;
        private System.Windows.Forms.PictureBox f_PictureBox;
        private System.Windows.Forms.ListBox f_PostListBox;
    }
}