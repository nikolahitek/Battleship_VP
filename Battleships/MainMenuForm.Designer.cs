namespace Battleships
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.quitButton = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.DarkRed;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.FlatAppearance.BorderSize = 2;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quitButton.Location = new System.Drawing.Point(214, 193);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(201, 46);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButtonClick);
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEasy.FlatAppearance.BorderSize = 2;
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEasy.Location = new System.Drawing.Point(6, 26);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(187, 40);
            this.buttonEasy.TabIndex = 8;
            this.buttonEasy.Text = "EASY";
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHard.FlatAppearance.BorderSize = 2;
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHard.Location = new System.Drawing.Point(6, 118);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(187, 40);
            this.buttonHard.TabIndex = 13;
            this.buttonHard.Text = "HARD";
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.BackColor = System.Drawing.Color.Transparent;
            this.buttonMedium.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMedium.FlatAppearance.BorderSize = 2;
            this.buttonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedium.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedium.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMedium.Location = new System.Drawing.Point(6, 72);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(187, 40);
            this.buttonMedium.TabIndex = 14;
            this.buttonMedium.Text = "MEDIUM";
            this.buttonMedium.UseVisualStyleBackColor = false;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.buttonEasy);
            this.groupBox1.Controls.Add(this.buttonHard);
            this.groupBox1.Controls.Add(this.buttonMedium);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(215, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 164);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NEW GAME";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Battleships.Properties.Resources.welcome_backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Battleships: Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuFormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

