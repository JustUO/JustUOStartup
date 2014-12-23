namespace JustUOStartup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logo = new System.Windows.Forms.PictureBox();
            this.Shardname = new System.Windows.Forms.TextBox();
            this.ClientPathLabel = new System.Windows.Forms.Label();
            this.ClientBrowse = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Label();
            this.Gobutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.results = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Expansion = new System.Windows.Forms.ComboBox();
            this.Expansionlabel = new System.Windows.Forms.Label();
            this.saveslabel = new System.Windows.Forms.Label();
            this.rewardslabel = new System.Windows.Forms.Label();
            this.skillcaplabel = new System.Windows.Forms.Label();
            this.statcaplabel = new System.Windows.Forms.Label();
            this.housedecaylabel = new System.Windows.Forms.Label();
            this.bondinglabel = new System.Windows.Forms.Label();
            this.optionslabel = new System.Windows.Forms.Label();
            this.Saves = new System.Windows.Forms.NumericUpDown();
            this.Rewards = new System.Windows.Forms.NumericUpDown();
            this.Housedecay = new System.Windows.Forms.NumericUpDown();
            this.Bonding = new System.Windows.Forms.NumericUpDown();
            this.Skillcap = new System.Windows.Forms.TextBox();
            this.Statcap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Housedecay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bonding)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Location = new System.Drawing.Point(75, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(500, 225);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Shardname
            // 
            this.Shardname.Location = new System.Drawing.Point(125, 300);
            this.Shardname.Name = "Shardname";
            this.Shardname.Size = new System.Drawing.Size(392, 20);
            this.Shardname.TabIndex = 1;
            // 
            // ClientPathLabel
            // 
            this.ClientPathLabel.AutoSize = true;
            this.ClientPathLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPathLabel.Location = new System.Drawing.Point(125, 335);
            this.ClientPathLabel.Name = "ClientPathLabel";
            this.ClientPathLabel.Size = new System.Drawing.Size(269, 15);
            this.ClientPathLabel.TabIndex = 3;
            this.ClientPathLabel.Text = "Please Browse to the location of your UO client:";
            // 
            // ClientBrowse
            // 
            this.ClientBrowse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientBrowse.Location = new System.Drawing.Point(400, 330);
            this.ClientBrowse.Name = "ClientBrowse";
            this.ClientBrowse.Size = new System.Drawing.Size(92, 23);
            this.ClientBrowse.TabIndex = 2;
            this.ClientBrowse.Text = "Browse";
            this.ClientBrowse.UseVisualStyleBackColor = false;
            this.ClientBrowse.Click += new System.EventHandler(this.ClientBrowse_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(300, 550);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(87, 19);
            this.start.TabIndex = 5;
            this.start.Text = "Lets do this!";
            // 
            // Gobutton
            // 
            this.Gobutton.Location = new System.Drawing.Point(400, 550);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(75, 23);
            this.Gobutton.TabIndex = 10;
            this.Gobutton.Text = "Go!";
            this.Gobutton.UseVisualStyleBackColor = true;
            this.Gobutton.Click += new System.EventHandler(this.Go_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(125, 360);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(392, 20);
            this.results.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(150, 275);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(356, 15);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Please type the name to be used for your shard in the box below:";
            // 
            // Expansion
            // 
            this.Expansion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Expansion.FormattingEnabled = true;
            this.Expansion.Location = new System.Drawing.Point(125, 425);
            this.Expansion.Name = "Expansion";
            this.Expansion.Size = new System.Drawing.Size(80, 21);
            this.Expansion.TabIndex = 3;
            string[] Expansions = new string[]{"None", "T2A", "UOR", "AOS", "ML", "SA", "HS"};
            this.Expansion.Items.AddRange(Expansions);
            this.Expansion.SelectedIndex = 6;
            // 
            // Expansionlabel
            // 
            this.Expansionlabel.AutoSize = true;
            this.Expansionlabel.Location = new System.Drawing.Point(125, 450);
            this.Expansionlabel.Name = "Expansionlabel";
            this.Expansionlabel.Size = new System.Drawing.Size(56, 13);
            this.Expansionlabel.TabIndex = 16;
            this.Expansionlabel.Text = "Expansion";
            // 
            // saveslabel
            // 
            this.saveslabel.AutoSize = true;
            this.saveslabel.Location = new System.Drawing.Point(275, 450);
            this.saveslabel.Name = "saveslabel";
            this.saveslabel.Size = new System.Drawing.Size(110, 13);
            this.saveslabel.TabIndex = 17;
            this.saveslabel.Text = "Save Frequency (min)";
            // 
            // rewardslabel
            // 
            this.rewardslabel.AutoSize = true;
            this.rewardslabel.Location = new System.Drawing.Point(425, 450);
            this.rewardslabel.Name = "rewardslabel";
            this.rewardslabel.Size = new System.Drawing.Size(147, 13);
            this.rewardslabel.TabIndex = 18;
            this.rewardslabel.Text = "Vet Reward Frequency (days)";
            // 
            // skillcaplabel
            // 
            this.skillcaplabel.AutoSize = true;
            this.skillcaplabel.Location = new System.Drawing.Point(125, 500);
            this.skillcaplabel.Name = "skillcaplabel";
            this.skillcaplabel.Size = new System.Drawing.Size(83, 13);
            this.skillcaplabel.TabIndex = 19;
            this.skillcaplabel.Text = "Total Skills Cap ";
            // 
            // statcaplabel
            // 
            this.statcaplabel.AutoSize = true;
            this.statcaplabel.Location = new System.Drawing.Point(275, 500);
            this.statcaplabel.Name = "statcaplabel";
            this.statcaplabel.Size = new System.Drawing.Size(75, 13);
            this.statcaplabel.TabIndex = 20;
            this.statcaplabel.Text = "Total Stat Cap";
            // 
            // housedecaylabel
            // 
            this.housedecaylabel.AutoSize = true;
            this.housedecaylabel.Location = new System.Drawing.Point(425, 500);
            this.housedecaylabel.Name = "housedecaylabel";
            this.housedecaylabel.Size = new System.Drawing.Size(129, 13);
            this.housedecaylabel.TabIndex = 21;
            this.housedecaylabel.Text = "House Decay Time (days)";
            // 
            // bondinglabel
            // 
            this.bondinglabel.AutoSize = true;
            this.bondinglabel.Location = new System.Drawing.Point(125, 550);
            this.bondinglabel.Name = "bondinglabel";
            this.bondinglabel.Size = new System.Drawing.Size(122, 13);
            this.bondinglabel.TabIndex = 22;
            this.bondinglabel.Text = "Pet Bonding Time (days)";
            // 
            // optionslabel
            // 
            this.optionslabel.AutoSize = true;
            this.optionslabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionslabel.Location = new System.Drawing.Point(170, 396);
            this.optionslabel.Name = "optionslabel";
            this.optionslabel.Size = new System.Drawing.Size(280, 15);
            this.optionslabel.TabIndex = 23;
            this.optionslabel.Text = "Please select the following options for your shard:";
            // 
            // Saves
            // 
            this.Saves.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Saves.Location = new System.Drawing.Point(275, 425);
            this.Saves.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Saves.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Saves.Name = "Saves";
            this.Saves.Size = new System.Drawing.Size(80, 20);
            this.Saves.TabIndex = 4;
            this.Saves.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Rewards
            // 
            this.Rewards.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rewards.Location = new System.Drawing.Point(425, 425);
            this.Rewards.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Rewards.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Rewards.Name = "Rewards";
            this.Rewards.Size = new System.Drawing.Size(80, 20);
            this.Rewards.TabIndex = 5;
            this.Rewards.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Housedecay
            // 
            this.Housedecay.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Housedecay.Location = new System.Drawing.Point(425, 475);
            this.Housedecay.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Housedecay.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Housedecay.Name = "Housedecay";
            this.Housedecay.Size = new System.Drawing.Size(80, 20);
            this.Housedecay.TabIndex = 8;
            this.Housedecay.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // Bonding
            // 
            this.Bonding.Location = new System.Drawing.Point(125, 525);
            this.Bonding.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Bonding.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bonding.Name = "Bonding";
            this.Bonding.Size = new System.Drawing.Size(80, 20);
            this.Bonding.TabIndex = 9;
            this.Bonding.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Skillcap
            // 
            this.Skillcap.Location = new System.Drawing.Point(125, 475);
            this.Skillcap.MaxLength = 5;
            this.Skillcap.Name = "Skillcap";
            this.Skillcap.Size = new System.Drawing.Size(100, 20);
            this.Skillcap.TabIndex = 6;
            this.Skillcap.Text = "7000";
            // 
            // Statcap
            // 
            this.Statcap.Location = new System.Drawing.Point(275, 475);
            this.Statcap.MaxLength = 5;
            this.Statcap.Name = "Statcap";
            this.Statcap.Size = new System.Drawing.Size(100, 20);
            this.Statcap.TabIndex = 7;
            this.Statcap.Text = "225";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(634, 612);
            this.Controls.Add(this.Statcap);
            this.Controls.Add(this.Skillcap);
            this.Controls.Add(this.Bonding);
            this.Controls.Add(this.Housedecay);
            this.Controls.Add(this.Rewards);
            this.Controls.Add(this.Saves);
            this.Controls.Add(this.optionslabel);
            this.Controls.Add(this.bondinglabel);
            this.Controls.Add(this.housedecaylabel);
            this.Controls.Add(this.statcaplabel);
            this.Controls.Add(this.skillcaplabel);
            this.Controls.Add(this.rewardslabel);
            this.Controls.Add(this.saveslabel);
            this.Controls.Add(this.Expansionlabel);
            this.Controls.Add(this.Expansion);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.results);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ClientBrowse);
            this.Controls.Add(this.ClientPathLabel);
            this.Controls.Add(this.Shardname);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "JustUO Setup";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Housedecay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bonding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox Shardname;
        private System.Windows.Forms.Label ClientPathLabel;
        private System.Windows.Forms.Button ClientBrowse;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox Expansion;
        private System.Windows.Forms.Label Expansionlabel;
        private System.Windows.Forms.Label saveslabel;
        private System.Windows.Forms.Label rewardslabel;
        private System.Windows.Forms.Label skillcaplabel;
        private System.Windows.Forms.Label statcaplabel;
        private System.Windows.Forms.Label housedecaylabel;
        private System.Windows.Forms.Label bondinglabel;
        private System.Windows.Forms.Label optionslabel;
        private System.Windows.Forms.NumericUpDown Saves;
        private System.Windows.Forms.NumericUpDown Rewards;
        private System.Windows.Forms.NumericUpDown Housedecay;
        private System.Windows.Forms.NumericUpDown Bonding;
        private System.Windows.Forms.TextBox Skillcap;
        private System.Windows.Forms.TextBox Statcap;

    }
}

