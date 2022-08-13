namespace RaceTrackSimulator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.BettorName = new System.Windows.Forms.Label();
            this.BatuhanButton = new System.Windows.Forms.RadioButton();
            this.BahadırButton = new System.Windows.Forms.RadioButton();
            this.MertButton = new System.Windows.Forms.RadioButton();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.winnerDog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // racetrack
            // 
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(7, 50);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(1032, 290);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 0;
            this.racetrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.BackColor = System.Drawing.Color.DarkGreen;
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(26, 61);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(153, 55);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog1.TabIndex = 1;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.BackColor = System.Drawing.Color.DarkGreen;
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(26, 132);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(153, 58);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog2.TabIndex = 2;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.BackColor = System.Drawing.Color.DarkGreen;
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(26, 206);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(153, 53);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog3.TabIndex = 3;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.BackColor = System.Drawing.Color.DarkGreen;
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(26, 275);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(153, 58);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog4.TabIndex = 4;
            this.dog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.alBet);
            this.groupBox1.Controls.Add(this.bobBet);
            this.groupBox1.Controls.Add(this.joeBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.DogNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BetAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.BettorName);
            this.groupBox1.Controls.Add(this.BatuhanButton);
            this.groupBox1.Controls.Add(this.BahadırButton);
            this.groupBox1.Controls.Add(this.MertButton);
            this.groupBox1.Controls.Add(this.MinimumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bet!!!";
            // 
            // alBet
            // 
            this.alBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBet.Location = new System.Drawing.Point(356, 88);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(290, 24);
            this.alBet.TabIndex = 13;
            this.alBet.Text = "label6";
            // 
            // bobBet
            // 
            this.bobBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBet.Location = new System.Drawing.Point(356, 64);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(290, 24);
            this.bobBet.TabIndex = 12;
            this.bobBet.Text = "label5";
            // 
            // joeBet
            // 
            this.joeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBet.Location = new System.Drawing.Point(356, 41);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(290, 23);
            this.joeBet.TabIndex = 11;
            this.joeBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(511, 126);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(135, 37);
            this.race.TabIndex = 9;
            this.race.Text = "Hoşt!!!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(374, 134);
            this.DogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(64, 26);
            this.DogNumber.TabIndex = 8;
            this.DogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kaçıncı Köpek:";
            // 
            // BetAmount
            // 
            this.BetAmount.Location = new System.Drawing.Point(175, 130);
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(63, 26);
            this.BetAmount.TabIndex = 6;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.Location = new System.Drawing.Point(92, 130);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(75, 27);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Bets";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // BettorName
            // 
            this.BettorName.AutoSize = true;
            this.BettorName.Location = new System.Drawing.Point(22, 134);
            this.BettorName.Name = "BettorName";
            this.BettorName.Size = new System.Drawing.Size(41, 20);
            this.BettorName.TabIndex = 4;
            this.BettorName.Text = "Mert";
            // 
            // BatuhanButton
            // 
            this.BatuhanButton.AutoSize = true;
            this.BatuhanButton.Location = new System.Drawing.Point(55, 100);
            this.BatuhanButton.Name = "BatuhanButton";
            this.BatuhanButton.Size = new System.Drawing.Size(88, 24);
            this.BatuhanButton.TabIndex = 3;
            this.BatuhanButton.Text = "Batuhan";
            this.BatuhanButton.UseVisualStyleBackColor = true;
            this.BatuhanButton.CheckedChanged += new System.EventHandler(this.alButton_CheckedChanged);
            // 
            // BahadırButton
            // 
            this.BahadırButton.AutoSize = true;
            this.BahadırButton.Location = new System.Drawing.Point(55, 74);
            this.BahadırButton.Name = "BahadırButton";
            this.BahadırButton.Size = new System.Drawing.Size(82, 24);
            this.BahadırButton.TabIndex = 2;
            this.BahadırButton.Text = "Bahadır";
            this.BahadırButton.UseVisualStyleBackColor = true;
            this.BahadırButton.CheckedChanged += new System.EventHandler(this.bobButton_CheckedChanged);
            // 
            // MertButton
            // 
            this.MertButton.AutoSize = true;
            this.MertButton.Checked = true;
            this.MertButton.Location = new System.Drawing.Point(55, 53);
            this.MertButton.Name = "MertButton";
            this.MertButton.Size = new System.Drawing.Size(59, 24);
            this.MertButton.TabIndex = 1;
            this.MertButton.TabStop = true;
            this.MertButton.Text = "Mert";
            this.MertButton.UseVisualStyleBackColor = true;
            this.MertButton.CheckedChanged += new System.EventHandler(this.joeButton_CheckedChanged);
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBet.Location = new System.Drawing.Point(39, 24);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(98, 17);
            this.MinimumBet.TabIndex = 0;
            this.MinimumBet.Text = "Minimum bet";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Greyhound Race";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.winnerDog);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(714, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Winner Dog!!!";
            // 
            // winnerDog
            // 
            this.winnerDog.Font = new System.Drawing.Font("Swis721 BlkCn BT", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.winnerDog.Location = new System.Drawing.Point(35, 26);
            this.winnerDog.Name = "winnerDog";
            this.winnerDog.Size = new System.Drawing.Size(258, 130);
            this.winnerDog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1054, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.racetrack);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BatuhanButton;
        private System.Windows.Forms.RadioButton BahadırButton;
        private System.Windows.Forms.RadioButton MertButton;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.Label BettorName;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label winnerDog;
    }
}

