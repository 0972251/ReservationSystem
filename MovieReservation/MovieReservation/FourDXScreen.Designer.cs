namespace MovieReservation
{
    partial class FourDXScreen
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
            this.FourDXlabel = new System.Windows.Forms.Label();
            this.FourDXPictureBox = new System.Windows.Forms.PictureBox();
            this.FourDXBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FourDXPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FourDXlabel
            // 
            this.FourDXlabel.AutoSize = true;
            this.FourDXlabel.BackColor = System.Drawing.Color.Transparent;
            this.FourDXlabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FourDXlabel.ForeColor = System.Drawing.Color.LightCyan;
            this.FourDXlabel.Location = new System.Drawing.Point(643, 102);
            this.FourDXlabel.Name = "FourDXlabel";
            this.FourDXlabel.Size = new System.Drawing.Size(84, 34);
            this.FourDXlabel.TabIndex = 1;
            this.FourDXlabel.Text = "label1";
            this.FourDXlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FourDXPictureBox
            // 
            this.FourDXPictureBox.Location = new System.Drawing.Point(-11, -2);
            this.FourDXPictureBox.MaximumSize = new System.Drawing.Size(1213, 722);
            this.FourDXPictureBox.MinimumSize = new System.Drawing.Size(1213, 722);
            this.FourDXPictureBox.Name = "FourDXPictureBox";
            this.FourDXPictureBox.Size = new System.Drawing.Size(1213, 722);
            this.FourDXPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FourDXPictureBox.TabIndex = 0;
            this.FourDXPictureBox.TabStop = false;
            // 
            // FourDXBackButton
            // 
            this.FourDXBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FourDXBackButton.BackColor = System.Drawing.Color.Gold;
            this.FourDXBackButton.Location = new System.Drawing.Point(13, 14);
            this.FourDXBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FourDXBackButton.Name = "FourDXBackButton";
            this.FourDXBackButton.Size = new System.Drawing.Size(182, 57);
            this.FourDXBackButton.TabIndex = 171;
            this.FourDXBackButton.Text = "Terug";
            this.FourDXBackButton.UseVisualStyleBackColor = false;
            this.FourDXBackButton.Click += new System.EventHandler(this.FourDXBackButton_Click);
            // 
            // FourDXScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 666);
            this.Controls.Add(this.FourDXBackButton);
            this.Controls.Add(this.FourDXlabel);
            this.Controls.Add(this.FourDXPictureBox);
            this.MaximumSize = new System.Drawing.Size(1213, 722);
            this.MinimumSize = new System.Drawing.Size(1213, 722);
            this.Name = "FourDXScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FourDXScreen";
            this.Load += new System.EventHandler(this.FourDXScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FourDXPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FourDXPictureBox;
        private System.Windows.Forms.Label FourDXlabel;
        private System.Windows.Forms.Button FourDXBackButton;
    }
}