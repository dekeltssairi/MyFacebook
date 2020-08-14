namespace Ex01.ApplicationUI
{
    partial class FormMosiftDiggingFriend
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
            this.friendNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.profilePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.numOfPostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // friendNameLabel
            // 
            this.friendNameLabel.AutoSize = true;
            this.friendNameLabel.Location = new System.Drawing.Point(317, 98);
            this.friendNameLabel.Name = "friendNameLabel";
            this.friendNameLabel.Size = new System.Drawing.Size(116, 17);
            this.friendNameLabel.TabIndex = 2;
            this.friendNameLabel.Text = "friendNameLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "This guy is Fucking digging";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Ex01.ApplicationUI.Properties.Resources.icons8_spade_100;
            this.pictureBox4.Location = new System.Drawing.Point(71, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(98, 123);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ex01.ApplicationUI.Properties.Resources.icon_חופר_ציור_csp27622896;
            this.pictureBox3.Location = new System.Drawing.Point(565, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(179, 151);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // profilePicturePictureBox
            // 
            this.profilePicturePictureBox.Location = new System.Drawing.Point(237, 194);
            this.profilePicturePictureBox.Name = "profilePicturePictureBox";
            this.profilePicturePictureBox.Size = new System.Drawing.Size(271, 186);
            this.profilePicturePictureBox.TabIndex = 0;
            this.profilePicturePictureBox.TabStop = false;
            // 
            // numOfPostLabel
            // 
            this.numOfPostLabel.AutoSize = true;
            this.numOfPostLabel.Location = new System.Drawing.Point(473, 407);
            this.numOfPostLabel.Name = "numOfPostLabel";
            this.numOfPostLabel.Size = new System.Drawing.Size(113, 17);
            this.numOfPostLabel.TabIndex = 6;
            this.numOfPostLabel.Text = "numOfPostLabel";
            // 
            // FormMosiftDiggingFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 457);
            this.Controls.Add(this.numOfPostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.friendNameLabel);
            this.Controls.Add(this.profilePicturePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMosiftDiggingFriend";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicturePictureBox;
        private System.Windows.Forms.Label friendNameLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numOfPostLabel;
    }
}