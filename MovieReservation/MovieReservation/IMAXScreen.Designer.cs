namespace MovieReservation
{
    partial class IMAXScreen
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
            this.IMAXLabel = new System.Windows.Forms.Label();
            this.TechPictureBox = new System.Windows.Forms.PictureBox();
            this.IMAXBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TechPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IMAXLabel
            // 
            this.IMAXLabel.AutoSize = true;
            this.IMAXLabel.BackColor = System.Drawing.Color.Transparent;
            this.IMAXLabel.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMAXLabel.ForeColor = System.Drawing.Color.White;
            this.IMAXLabel.Location = new System.Drawing.Point(131, 325);
            this.IMAXLabel.Name = "IMAXLabel";
            this.IMAXLabel.Size = new System.Drawing.Size(0, 36);
            this.IMAXLabel.TabIndex = 1;
            this.IMAXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TechPictureBox
            // 
            this.TechPictureBox.BackColor = System.Drawing.Color.White;
            this.TechPictureBox.Location = new System.Drawing.Point(-5, -15);
            this.TechPictureBox.Name = "TechPictureBox";
            this.TechPictureBox.Size = new System.Drawing.Size(1199, 721);
            this.TechPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TechPictureBox.TabIndex = 0;
            this.TechPictureBox.TabStop = false;
            // 
            // IMAXBackButton
            // 
            this.IMAXBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IMAXBackButton.BackColor = System.Drawing.Color.Gold;
            this.IMAXBackButton.Location = new System.Drawing.Point(13, 14);
            this.IMAXBackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IMAXBackButton.Name = "IMAXBackButton";
            this.IMAXBackButton.Size = new System.Drawing.Size(182, 57);
            this.IMAXBackButton.TabIndex = 171;
            this.IMAXBackButton.Text = "Terug";
            this.IMAXBackButton.UseVisualStyleBackColor = false;
            this.IMAXBackButton.Click += new System.EventHandler(this.IMAXBackButton_Click);
            // 
            // IMAXScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 666);
            this.Controls.Add(this.IMAXBackButton);
            this.Controls.Add(this.IMAXLabel);
            this.Controls.Add(this.TechPictureBox);
            this.MaximumSize = new System.Drawing.Size(1213, 722);
            this.MinimumSize = new System.Drawing.Size(1213, 722);
            this.Name = "IMAXScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technology";
            this.Load += new System.EventHandler(this.IMAXScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TechPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TechPictureBox;
        private System.Windows.Forms.Label IMAXLabel;
        private System.Windows.Forms.Button IMAXBackButton;
    }
}