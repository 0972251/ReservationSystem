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
            this.Medewerker = new System.Windows.Forms.Button();
            this.Klant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(323, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ik ben een...";
            // 
            // Medewerker
            // 
            this.Medewerker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Medewerker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Medewerker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medewerker.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medewerker.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Medewerker.Location = new System.Drawing.Point(413, 225);
            this.Medewerker.Margin = new System.Windows.Forms.Padding(2);
            this.Medewerker.Name = "Medewerker";
            this.Medewerker.Size = new System.Drawing.Size(172, 64);
            this.Medewerker.TabIndex = 8;
            this.Medewerker.Text = "MEDEWERKER";
            this.Medewerker.UseVisualStyleBackColor = false;
            this.Medewerker.Click += new System.EventHandler(this.Medewerker_Click);
            // 
            // Klant
            // 
            this.Klant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Klant.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Klant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Klant.Font = new System.Drawing.Font("Arial", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Klant.Location = new System.Drawing.Point(215, 225);
            this.Klant.Margin = new System.Windows.Forms.Padding(2);
            this.Klant.Name = "Klant";
            this.Klant.Size = new System.Drawing.Size(172, 64);
            this.Klant.TabIndex = 7;
            this.Klant.Text = "KLANT";
            this.Klant.UseVisualStyleBackColor = false;
            this.Klant.Click += new System.EventHandler(this.Klant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieReservation.Properties.Resources.WhatsApp_Image_2020_05_18_at_13_34_34;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medewerker);
            this.Controls.Add(this.Klant);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Medewerker;
        private System.Windows.Forms.Button Klant;
    }
}

