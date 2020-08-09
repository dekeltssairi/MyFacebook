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
            this.f_CheckinListBox.FormattingEnabled = true;
            this.f_CheckinListBox.ItemHeight = 16;
            this.f_CheckinListBox.Location = new System.Drawing.Point(205, 101);
            this.f_CheckinListBox.Name = "f_CheckinListBox";
            this.f_CheckinListBox.Size = new System.Drawing.Size(373, 228);
            this.f_CheckinListBox.TabIndex = 0;
            // 
            // CheckInListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f_CheckinListBox);
            this.Name = "CheckInListForm";
            this.Text = "CheckInListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox f_CheckinListBox;
    }
}