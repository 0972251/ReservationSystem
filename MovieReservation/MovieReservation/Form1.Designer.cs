namespace MovieReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.Klant = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welkom bij SmartCinema";
            // 
            // Klant
            // 
            this.Klant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Klant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Klant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Klant.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F);
            this.Klant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Klant.Location = new System.Drawing.Point(321, 230);
            this.Klant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klant.Name = "Klant";
            this.Klant.Size = new System.Drawing.Size(191, 57);
            this.Klant.TabIndex = 7;
            this.Klant.Text = "Bezoeker";
            this.Klant.UseVisualStyleBackColor = false;
            this.Klant.Click += new System.EventHandler(this.Klant_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(559, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Medewerker";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieReservation.Properties.Resources.WhatsApp_Image_2020_05_18_at_13_34_34;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Klant);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Klant;
        private System.Windows.Forms.Button button1;
    }
}

