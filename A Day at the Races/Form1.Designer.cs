namespace A_Day_at_the_Races
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.betButton = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.raceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetlabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.bettingParlorBox = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            this.bettingParlorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(100, 143);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 27;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click_1);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(181, 145);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(40, 20);
            this.betAmount.TabIndex = 28;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(57, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(33, 13);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(60, 117);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 21;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged_1);
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(550, 71);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(102, 63);
            this.raceButton.TabIndex = 25;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "bucks on dog number";
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(60, 94);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 20;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged_1);
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(343, 145);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(50, 20);
            this.dogNumber.TabIndex = 29;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(186, 119);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(35, 13);
            this.alBetLabel.TabIndex = 24;
            this.alBetLabel.Text = "label3";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(60, 71);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 19;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged_1);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(186, 96);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(35, 13);
            this.bobBetLabel.TabIndex = 23;
            this.bobBetLabel.Text = "label2";
            // 
            // joeBetlabel
            // 
            this.joeBetlabel.AutoSize = true;
            this.joeBetlabel.Location = new System.Drawing.Point(186, 73);
            this.joeBetlabel.Name = "joeBetlabel";
            this.joeBetlabel.Size = new System.Drawing.Size(35, 13);
            this.joeBetlabel.TabIndex = 22;
            this.joeBetlabel.Text = "label1";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(57, 43);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(35, 13);
            this.minimumBetLabel.TabIndex = 18;
            this.minimumBetLabel.Text = "label1";
            // 
            // bettingParlorBox
            // 
            this.bettingParlorBox.Controls.Add(this.minimumBetLabel);
            this.bettingParlorBox.Controls.Add(this.joeBetlabel);
            this.bettingParlorBox.Controls.Add(this.bobBetLabel);
            this.bettingParlorBox.Controls.Add(this.joeRadioButton);
            this.bettingParlorBox.Controls.Add(this.alBetLabel);
            this.bettingParlorBox.Controls.Add(this.dogNumber);
            this.bettingParlorBox.Controls.Add(this.bobRadioButton);
            this.bettingParlorBox.Controls.Add(this.label1);
            this.bettingParlorBox.Controls.Add(this.raceButton);
            this.bettingParlorBox.Controls.Add(this.alRadioButton);
            this.bettingParlorBox.Controls.Add(this.nameLabel);
            this.bettingParlorBox.Controls.Add(this.betAmount);
            this.bettingParlorBox.Controls.Add(this.betButton);
            this.bettingParlorBox.Location = new System.Drawing.Point(12, 338);
            this.bettingParlorBox.Name = "bettingParlorBox";
            this.bettingParlorBox.Size = new System.Drawing.Size(737, 252);
            this.bettingParlorBox.TabIndex = 18;
            this.bettingParlorBox.TabStop = false;
            this.bettingParlorBox.Text = "Betting Parlor";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::A_Day_at_the_Races.Properties.Resources._2020_06_15_18_15_22_dumb_looking_animals___Google_Search;
            this.pictureBox4.Location = new System.Drawing.Point(72, 255);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::A_Day_at_the_Races.Properties.Resources._2020_06_15_18_15_22_dumb_looking_animals___Google_Search;
            this.pictureBox3.Location = new System.Drawing.Point(72, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::A_Day_at_the_Races.Properties.Resources._2020_06_15_18_15_22_dumb_looking_animals___Google_Search;
            this.pictureBox2.Location = new System.Drawing.Point(72, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::A_Day_at_the_Races.Properties.Resources._2020_06_15_18_15_22_dumb_looking_animals___Google_Search;
            this.pictureBox1.Location = new System.Drawing.Point(72, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::A_Day_at_the_Races.Properties.Resources.gross2;
            this.racetrackPictureBox.Location = new System.Drawing.Point(72, 29);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(677, 276);
            this.racetrackPictureBox.TabIndex = 4;
            this.racetrackPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.bettingParlorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            this.bettingParlorBox.ResumeLayout(false);
            this.bettingParlorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetlabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.GroupBox bettingParlorBox;
    }
}

