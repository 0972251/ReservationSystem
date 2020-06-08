namespace MovieReservation
{
    partial class DolbyScreen
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
            this.Dolbylabel = new System.Windows.Forms.Label();
            this.DolbyPictureBox = new System.Windows.Forms.PictureBox();
            this.DolbyBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DolbyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Dolbylabel
            // 
            this.Dolbylabel.AutoSize = true;
            this.Dolbylabel.BackColor = System.Drawing.Color.Transparent;
            this.Dolbylabel.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Dolbylabel.ForeColor = System.Drawing.Color.White;
            this.Dolbylabel.Location = new System.Drawing.Point(597, 250);
            this.Dolbylabel.Name = "Dolbylabel";
            this.Dolbylabel.Size = new System.Drawing.Size(87, 36);
            this.Dolbylabel.TabIndex = 1;
            this.Dolbylabel.Text = "label1";
            this.Dolbylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DolbyPictureBox
            // 
            this.DolbyPictureBox.Location = new System.Drawing.Point(1, -1);
            this.DolbyPictureBox.MaximumSize = new System.Drawing.Size(1213, 722);
            this.DolbyPictureBox.MinimumSize = new System.Drawing.Size(1213, 722);
            this.DolbyPictureBox.Name = "DolbyPictureBox";
            this.DolbyPictureBox.Size = new System.Drawing.Size(1213, 722);
            this.DolbyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DolbyPictureBox.TabIndex = 0;
            this.DolbyPictureBox.TabStop = false;
            // 
            // DolbyBackButton
            // 
            this.DolbyBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DolbyBackButton.BackColor = System.Drawing.Color.Gold;
            this.DolbyBackButton.Location = new System.Drawing.Point(13, 23);
            this.DolbyBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DolbyBackButton.Name = "DolbyBackButton";
            this.DolbyBackButton.Size = new System.Drawing.Size(182, 57);
            this.DolbyBackButton.TabIndex = 172;
            this.DolbyBackButton.Text = "Terug";
            this.DolbyBackButton.UseVisualStyleBackColor = false;
            this.DolbyBackButton.Click += new System.EventHandler(this.DolbyBackButton_Click);
            // 
            // DolbyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 666);
            this.Controls.Add(this.DolbyBackButton);
            this.Controls.Add(this.Dolbylabel);
            this.Controls.Add(this.DolbyPictureBox);
            this.MaximumSize = new System.Drawing.Size(1213, 722);
            this.MinimumSize = new System.Drawing.Size(1213, 722);
            this.Name = "DolbyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolbyScreen";
            this.Load += new System.EventHandler(this.DolbyScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DolbyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DolbyPictureBox;
        private System.Windows.Forms.Label Dolbylabel;
        private System.Windows.Forms.Button DolbyBackButton;
    }
}