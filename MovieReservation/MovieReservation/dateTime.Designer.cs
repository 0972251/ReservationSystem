namespace MovieReservation
{
    partial class dateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dateTime));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxClassification = new System.Windows.Forms.PictureBox();
            this.pictureBoxAge = new System.Windows.Forms.PictureBox();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(308, 145);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(836, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ticket Kiezen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(304, 228);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(697, 216);
            this.labelDescription.TabIndex = 39;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(59, 113);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(66, 25);
            this.labelTitle.TabIndex = 38;
            this.labelTitle.Text = "Joker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(589, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tijd";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(595, 143);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Datum";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(60, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 48;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxClassification
            // 
            this.pictureBoxClassification.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClassification.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClassification.Image")));
            this.pictureBoxClassification.Location = new System.Drawing.Point(147, 375);
            this.pictureBoxClassification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClassification.Name = "pictureBoxClassification";
            this.pictureBoxClassification.Size = new System.Drawing.Size(75, 68);
            this.pictureBoxClassification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClassification.TabIndex = 43;
            this.pictureBoxClassification.TabStop = false;
            // 
            // pictureBoxAge
            // 
            this.pictureBoxAge.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAge.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAge.Image")));
            this.pictureBoxAge.Location = new System.Drawing.Point(64, 375);
            this.pictureBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAge.Name = "pictureBoxAge";
            this.pictureBoxAge.Size = new System.Drawing.Size(77, 68);
            this.pictureBoxAge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAge.TabIndex = 42;
            this.pictureBoxAge.TabStop = false;
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMovie.Image")));
            this.pictureBoxMovie.Location = new System.Drawing.Point(64, 160);
            this.pictureBoxMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(157, 210);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovie.TabIndex = 34;
            this.pictureBoxMovie.TabStop = false;
            this.pictureBoxMovie.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MovieReservation.Properties.Resources.WhatsApp_Image_2020_05_18_at_13_34_34;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBoxClassification);
            this.Controls.Add(this.pictureBoxAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxMovie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "dateTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dateTime";
            this.Load += new System.EventHandler(this.dateTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBoxClassification;
        private System.Windows.Forms.PictureBox pictureBoxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private System.Windows.Forms.Button button2;
    }
}