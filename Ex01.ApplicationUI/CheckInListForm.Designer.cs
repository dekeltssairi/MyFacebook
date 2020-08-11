namespace Ex01.ApplicationUI
{
    partial class CheckInListForm
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
            this.f_CheckinListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // f_CheckinListBox
            // 
            this.f_CheckinListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.f_CheckinListBox.FormattingEnabled = true;
            this.f_CheckinListBox.HorizontalScrollbar = true;
            this.f_CheckinListBox.Location = new System.Drawing.Point(154, 82);
            this.f_CheckinListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.f_CheckinListBox.Name = "f_CheckinListBox";
            this.f_CheckinListBox.Size = new System.Drawing.Size(281, 186);
            this.f_CheckinListBox.TabIndex = 0;
            // 
            // CheckInListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.f_CheckinListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckInListForm";
            this.Text = "CheckInListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox f_CheckinListBox;
    }
}