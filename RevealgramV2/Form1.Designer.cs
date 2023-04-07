namespace RevealgramV2
{
    partial class revealgram
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(revealgram));
            this.followerPathButton = new System.Windows.Forms.Button();
            this.followerPathBox = new System.Windows.Forms.TextBox();
            this.followingPathBox = new System.Windows.Forms.TextBox();
            this.followingPathButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.followerLabel = new System.Windows.Forms.Label();
            this.followingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diffNumLabel = new System.Windows.Forms.Label();
            this.followerNumLabel = new System.Windows.Forms.Label();
            this.followingNumLabel = new System.Windows.Forms.Label();
            this.savePathButton = new System.Windows.Forms.Button();
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.reloadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // followerPathButton
            // 
            this.followerPathButton.Location = new System.Drawing.Point(19, 24);
            this.followerPathButton.Name = "followerPathButton";
            this.followerPathButton.Size = new System.Drawing.Size(75, 28);
            this.followerPathButton.TabIndex = 0;
            this.followerPathButton.Text = "Browse...";
            this.followerPathButton.UseVisualStyleBackColor = true;
            this.followerPathButton.Click += new System.EventHandler(this.followerPathButton_Click);
            // 
            // followerPathBox
            // 
            this.followerPathBox.Enabled = false;
            this.followerPathBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.followerPathBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.followerPathBox.Location = new System.Drawing.Point(100, 25);
            this.followerPathBox.Name = "followerPathBox";
            this.followerPathBox.Size = new System.Drawing.Size(391, 27);
            this.followerPathBox.TabIndex = 1;
            this.followerPathBox.Text = "Select followers.json";
            // 
            // followingPathBox
            // 
            this.followingPathBox.Enabled = false;
            this.followingPathBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.followingPathBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.followingPathBox.Location = new System.Drawing.Point(100, 64);
            this.followingPathBox.Name = "followingPathBox";
            this.followingPathBox.Size = new System.Drawing.Size(391, 27);
            this.followingPathBox.TabIndex = 2;
            this.followingPathBox.Text = "Select following.json";
            // 
            // followingPathButton
            // 
            this.followingPathButton.Location = new System.Drawing.Point(19, 64);
            this.followingPathButton.Name = "followingPathButton";
            this.followingPathButton.Size = new System.Drawing.Size(75, 27);
            this.followingPathButton.TabIndex = 3;
            this.followingPathButton.Text = "Browse...";
            this.followingPathButton.UseVisualStyleBackColor = true;
            this.followingPathButton.Click += new System.EventHandler(this.followingPathButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // followerLabel
            // 
            this.followerLabel.AutoSize = true;
            this.followerLabel.BackColor = System.Drawing.Color.Transparent;
            this.followerLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.followerLabel.ForeColor = System.Drawing.Color.White;
            this.followerLabel.Location = new System.Drawing.Point(53, 153);
            this.followerLabel.Name = "followerLabel";
            this.followerLabel.Size = new System.Drawing.Size(102, 24);
            this.followerLabel.TabIndex = 5;
            this.followerLabel.Text = "Followers:";
            // 
            // followingLabel
            // 
            this.followingLabel.AutoSize = true;
            this.followingLabel.BackColor = System.Drawing.Color.Transparent;
            this.followingLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.followingLabel.ForeColor = System.Drawing.Color.White;
            this.followingLabel.Location = new System.Drawing.Point(324, 153);
            this.followingLabel.Name = "followingLabel";
            this.followingLabel.Size = new System.Drawing.Size(103, 24);
            this.followingLabel.TabIndex = 6;
            this.followingLabel.Text = "Following:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "The number of people who don\'t follow you:";
            // 
            // diffNumLabel
            // 
            this.diffNumLabel.AutoSize = true;
            this.diffNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.diffNumLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diffNumLabel.ForeColor = System.Drawing.Color.White;
            this.diffNumLabel.Location = new System.Drawing.Point(243, 251);
            this.diffNumLabel.Name = "diffNumLabel";
            this.diffNumLabel.Size = new System.Drawing.Size(21, 24);
            this.diffNumLabel.TabIndex = 8;
            this.diffNumLabel.Text = "0";
            // 
            // followerNumLabel
            // 
            this.followerNumLabel.AutoSize = true;
            this.followerNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.followerNumLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.followerNumLabel.ForeColor = System.Drawing.Color.White;
            this.followerNumLabel.Location = new System.Drawing.Point(148, 153);
            this.followerNumLabel.Name = "followerNumLabel";
            this.followerNumLabel.Size = new System.Drawing.Size(21, 24);
            this.followerNumLabel.TabIndex = 9;
            this.followerNumLabel.Text = "0";
            // 
            // followingNumLabel
            // 
            this.followingNumLabel.AutoSize = true;
            this.followingNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.followingNumLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.followingNumLabel.ForeColor = System.Drawing.Color.White;
            this.followingNumLabel.Location = new System.Drawing.Point(420, 153);
            this.followingNumLabel.Name = "followingNumLabel";
            this.followingNumLabel.Size = new System.Drawing.Size(21, 24);
            this.followingNumLabel.TabIndex = 10;
            this.followingNumLabel.Text = "0";
            // 
            // savePathButton
            // 
            this.savePathButton.Location = new System.Drawing.Point(19, 306);
            this.savePathButton.Name = "savePathButton";
            this.savePathButton.Size = new System.Drawing.Size(75, 27);
            this.savePathButton.TabIndex = 11;
            this.savePathButton.Text = "Browse...";
            this.savePathButton.UseVisualStyleBackColor = true;
            this.savePathButton.Click += new System.EventHandler(this.savePathButton_Click);
            // 
            // savePathBox
            // 
            this.savePathBox.Enabled = false;
            this.savePathBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savePathBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.savePathBox.Location = new System.Drawing.Point(100, 306);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.Size = new System.Drawing.Size(391, 27);
            this.savePathBox.TabIndex = 12;
            this.savePathBox.Text = "Select Save Location";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(416, 339);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(416, 97);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 27);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Enabled = false;
            this.profileButton.Location = new System.Drawing.Point(313, 97);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(97, 27);
            this.profileButton.TabIndex = 16;
            this.profileButton.Text = "Show Profiles";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // reloadLabel
            // 
            this.reloadLabel.AutoSize = true;
            this.reloadLabel.BackColor = System.Drawing.Color.Transparent;
            this.reloadLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadLabel.Enabled = false;
            this.reloadLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reloadLabel.ForeColor = System.Drawing.Color.Transparent;
            this.reloadLabel.Location = new System.Drawing.Point(267, 88);
            this.reloadLabel.Name = "reloadLabel";
            this.reloadLabel.Size = new System.Drawing.Size(40, 37);
            this.reloadLabel.TabIndex = 17;
            this.reloadLabel.Text = "↻";
            this.reloadLabel.Click += new System.EventHandler(this.reloadLabel_Click);
            // 
            // revealgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 456);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.savePathBox);
            this.Controls.Add(this.savePathButton);
            this.Controls.Add(this.followingNumLabel);
            this.Controls.Add(this.followerNumLabel);
            this.Controls.Add(this.diffNumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.followerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.followingPathButton);
            this.Controls.Add(this.followingPathBox);
            this.Controls.Add(this.followerPathBox);
            this.Controls.Add(this.followerPathButton);
            this.Controls.Add(this.followingLabel);
            this.Controls.Add(this.reloadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "revealgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revealgram";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button followerPathButton;
        private TextBox followerPathBox;
        private TextBox followingPathBox;
        private Button followingPathButton;
        private PictureBox pictureBox1;
        private Label followerLabel;
        private Label followingLabel;
        private Label label1;
        private Label diffNumLabel;
        private Label followerNumLabel;
        private Label followingNumLabel;
        private Button savePathButton;
        private TextBox savePathBox;
        private Button saveButton;
        private Button checkButton;
        private Button profileButton;
        private Label reloadLabel;
    }
}