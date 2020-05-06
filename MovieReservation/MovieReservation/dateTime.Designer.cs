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
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxClassification = new System.Windows.Forms.PictureBox();
            this.pictureBoxAge = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Speelduur: 122 minuten";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 97);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBoxClassification
            // 
            this.pictureBoxClassification.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClassification.Image")));
            this.pictureBoxClassification.Location = new System.Drawing.Point(147, 359);
            this.pictureBoxClassification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClassification.Name = "pictureBoxClassification";
            this.pictureBoxClassification.Size = new System.Drawing.Size(75, 68);
            this.pictureBoxClassification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClassification.TabIndex = 43;
            this.pictureBoxClassification.TabStop = false;
            // 
            // pictureBoxAge
            // 
            this.pictureBoxAge.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAge.Image")));
            this.pictureBoxAge.Location = new System.Drawing.Point(64, 359);
            this.pictureBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxAge.Name = "pictureBoxAge";
            this.pictureBoxAge.Size = new System.Drawing.Size(77, 68);
            this.pictureBoxAge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAge.TabIndex = 42;
            this.pictureBoxAge.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 55);
            this.button1.TabIndex = 40;
            this.button1.Text = "Volgende";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(387, 169);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(530, 153);
            this.labelDescription.TabIndex = 39;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(59, 113);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(61, 25);
            this.labelTitle.TabIndex = 38;
            this.labelTitle.Text = "Joker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tijd";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "11:30",
            "13:00",
            "17:00",
            "21:00"});
            this.comboBox2.Location = new System.Drawing.Point(676, 95);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Datum";
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMovie.Image")));
            this.pictureBoxMovie.Location = new System.Drawing.Point(64, 144);
            this.pictureBoxMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(157, 210);
            this.pictureBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovie.TabIndex = 34;
            this.pictureBoxMovie.TabStop = false;
            this.pictureBoxMovie.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 48;
            this.button2.Text = "Terug";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
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
            this.Name = "dateTime";
            this.Text = "dateTime";
            this.Load += new System.EventHandler(this.dateTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClassification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
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