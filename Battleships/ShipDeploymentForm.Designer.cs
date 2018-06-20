namespace Battleships
{
    partial class ShipDeploymentForm
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
            System.Windows.Forms.GroupBox ship0GroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipDeploymentForm));
            System.Windows.Forms.GroupBox ship1GroupBox;
            System.Windows.Forms.GroupBox ship2GroupBox;
            System.Windows.Forms.GroupBox ship3GroupBox;
            System.Windows.Forms.GroupBox ship4GroupBox;
            this.deleteShip0Button = new System.Windows.Forms.Button();
            this.deployShip0Button = new System.Windows.Forms.Button();
            this.deployShip1Button = new System.Windows.Forms.Button();
            this.deleteShip1Button = new System.Windows.Forms.Button();
            this.deleteShip2Button = new System.Windows.Forms.Button();
            this.deployShip2Button = new System.Windows.Forms.Button();
            this.deleteShip3Button = new System.Windows.Forms.Button();
            this.deployShip3Button = new System.Windows.Forms.Button();
            this.deleteShip4Button = new System.Windows.Forms.Button();
            this.deployShip4Button = new System.Windows.Forms.Button();
            this.shipRotateButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.deckPictureBox = new System.Windows.Forms.PictureBox();
            ship0GroupBox = new System.Windows.Forms.GroupBox();
            ship1GroupBox = new System.Windows.Forms.GroupBox();
            ship2GroupBox = new System.Windows.Forms.GroupBox();
            ship3GroupBox = new System.Windows.Forms.GroupBox();
            ship4GroupBox = new System.Windows.Forms.GroupBox();
            ship0GroupBox.SuspendLayout();
            ship1GroupBox.SuspendLayout();
            ship2GroupBox.SuspendLayout();
            ship3GroupBox.SuspendLayout();
            ship4GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ship0GroupBox
            // 
            ship0GroupBox.Controls.Add(this.deleteShip0Button);
            ship0GroupBox.Controls.Add(this.deployShip0Button);
            ship0GroupBox.Location = new System.Drawing.Point(12, 12);
            ship0GroupBox.Name = "ship0GroupBox";
            ship0GroupBox.Size = new System.Drawing.Size(198, 61);
            ship0GroupBox.TabIndex = 1;
            ship0GroupBox.TabStop = false;
            ship0GroupBox.Text = "Patrol Boat";
            // 
            // deleteShip0Button
            // 
            this.deleteShip0Button.BackgroundImage = global::Battleships.Properties.Resources.delete;
            this.deleteShip0Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteShip0Button.Enabled = false;
            this.deleteShip0Button.FlatAppearance.BorderSize = 0;
            this.deleteShip0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShip0Button.Location = new System.Drawing.Point(153, 16);
            this.deleteShip0Button.Name = "deleteShip0Button";
            this.deleteShip0Button.Size = new System.Drawing.Size(39, 39);
            this.deleteShip0Button.TabIndex = 6;
            this.deleteShip0Button.UseVisualStyleBackColor = true;
            this.deleteShip0Button.Click += new System.EventHandler(this.DeleteShip0ButtonClick);
            // 
            // deployShip0Button
            // 
            this.deployShip0Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deployShip0Button.BackgroundImage")));
            this.deployShip0Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deployShip0Button.FlatAppearance.BorderSize = 0;
            this.deployShip0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deployShip0Button.Location = new System.Drawing.Point(6, 16);
            this.deployShip0Button.Name = "deployShip0Button";
            this.deployShip0Button.Size = new System.Drawing.Size(141, 39);
            this.deployShip0Button.TabIndex = 0;
            this.deployShip0Button.UseVisualStyleBackColor = true;
            this.deployShip0Button.Click += new System.EventHandler(this.Ship0ButtonClick);
            // 
            // ship1GroupBox
            // 
            ship1GroupBox.Controls.Add(this.deployShip1Button);
            ship1GroupBox.Controls.Add(this.deleteShip1Button);
            ship1GroupBox.Location = new System.Drawing.Point(12, 79);
            ship1GroupBox.Name = "ship1GroupBox";
            ship1GroupBox.Size = new System.Drawing.Size(198, 61);
            ship1GroupBox.TabIndex = 7;
            ship1GroupBox.TabStop = false;
            ship1GroupBox.Text = "Submarine";
            // 
            // deployShip1Button
            // 
            this.deployShip1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deployShip1Button.BackgroundImage")));
            this.deployShip1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deployShip1Button.FlatAppearance.BorderSize = 0;
            this.deployShip1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deployShip1Button.Location = new System.Drawing.Point(6, 16);
            this.deployShip1Button.Name = "deployShip1Button";
            this.deployShip1Button.Size = new System.Drawing.Size(141, 39);
            this.deployShip1Button.TabIndex = 1;
            this.deployShip1Button.UseVisualStyleBackColor = true;
            this.deployShip1Button.Click += new System.EventHandler(this.Ship1ButtonClick);
            // 
            // deleteShip1Button
            // 
            this.deleteShip1Button.BackgroundImage = global::Battleships.Properties.Resources.delete;
            this.deleteShip1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteShip1Button.Enabled = false;
            this.deleteShip1Button.FlatAppearance.BorderSize = 0;
            this.deleteShip1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShip1Button.Location = new System.Drawing.Point(153, 16);
            this.deleteShip1Button.Name = "deleteShip1Button";
            this.deleteShip1Button.Size = new System.Drawing.Size(39, 39);
            this.deleteShip1Button.TabIndex = 7;
            this.deleteShip1Button.UseVisualStyleBackColor = true;
            this.deleteShip1Button.Click += new System.EventHandler(this.DeleteShip1ButtonClick);
            // 
            // ship2GroupBox
            // 
            ship2GroupBox.Controls.Add(this.deleteShip2Button);
            ship2GroupBox.Controls.Add(this.deployShip2Button);
            ship2GroupBox.Location = new System.Drawing.Point(12, 146);
            ship2GroupBox.Name = "ship2GroupBox";
            ship2GroupBox.Size = new System.Drawing.Size(198, 61);
            ship2GroupBox.TabIndex = 12;
            ship2GroupBox.TabStop = false;
            ship2GroupBox.Text = "Destroyer";
            // 
            // deleteShip2Button
            // 
            this.deleteShip2Button.BackgroundImage = global::Battleships.Properties.Resources.delete;
            this.deleteShip2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteShip2Button.Enabled = false;
            this.deleteShip2Button.FlatAppearance.BorderSize = 0;
            this.deleteShip2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShip2Button.Location = new System.Drawing.Point(153, 16);
            this.deleteShip2Button.Name = "deleteShip2Button";
            this.deleteShip2Button.Size = new System.Drawing.Size(39, 39);
            this.deleteShip2Button.TabIndex = 6;
            this.deleteShip2Button.UseVisualStyleBackColor = true;
            this.deleteShip2Button.Click += new System.EventHandler(this.DeleteShip2ButtonClick);
            // 
            // deployShip2Button
            // 
            this.deployShip2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deployShip2Button.BackgroundImage")));
            this.deployShip2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deployShip2Button.FlatAppearance.BorderSize = 0;
            this.deployShip2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deployShip2Button.Location = new System.Drawing.Point(6, 16);
            this.deployShip2Button.Name = "deployShip2Button";
            this.deployShip2Button.Size = new System.Drawing.Size(141, 39);
            this.deployShip2Button.TabIndex = 2;
            this.deployShip2Button.UseVisualStyleBackColor = true;
            this.deployShip2Button.Click += new System.EventHandler(this.Ship2ButtonClick);
            // 
            // ship3GroupBox
            // 
            ship3GroupBox.Controls.Add(this.deleteShip3Button);
            ship3GroupBox.Controls.Add(this.deployShip3Button);
            ship3GroupBox.Location = new System.Drawing.Point(12, 213);
            ship3GroupBox.Name = "ship3GroupBox";
            ship3GroupBox.Size = new System.Drawing.Size(198, 61);
            ship3GroupBox.TabIndex = 13;
            ship3GroupBox.TabStop = false;
            ship3GroupBox.Text = "Battleship";
            // 
            // deleteShip3Button
            // 
            this.deleteShip3Button.BackgroundImage = global::Battleships.Properties.Resources.delete;
            this.deleteShip3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteShip3Button.Enabled = false;
            this.deleteShip3Button.FlatAppearance.BorderSize = 0;
            this.deleteShip3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShip3Button.Location = new System.Drawing.Point(153, 16);
            this.deleteShip3Button.Name = "deleteShip3Button";
            this.deleteShip3Button.Size = new System.Drawing.Size(39, 39);
            this.deleteShip3Button.TabIndex = 6;
            this.deleteShip3Button.UseVisualStyleBackColor = true;
            this.deleteShip3Button.Click += new System.EventHandler(this.DeleteShip3ButtonClick);
            // 
            // deployShip3Button
            // 
            this.deployShip3Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deployShip3Button.BackgroundImage")));
            this.deployShip3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deployShip3Button.FlatAppearance.BorderSize = 0;
            this.deployShip3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deployShip3Button.Location = new System.Drawing.Point(6, 16);
            this.deployShip3Button.Name = "deployShip3Button";
            this.deployShip3Button.Size = new System.Drawing.Size(141, 39);
            this.deployShip3Button.TabIndex = 3;
            this.deployShip3Button.UseVisualStyleBackColor = true;
            this.deployShip3Button.Click += new System.EventHandler(this.Ship3ButtonClick);
            // 
            // ship4GroupBox
            // 
            ship4GroupBox.Controls.Add(this.deleteShip4Button);
            ship4GroupBox.Controls.Add(this.deployShip4Button);
            ship4GroupBox.Location = new System.Drawing.Point(12, 280);
            ship4GroupBox.Name = "ship4GroupBox";
            ship4GroupBox.Size = new System.Drawing.Size(198, 61);
            ship4GroupBox.TabIndex = 14;
            ship4GroupBox.TabStop = false;
            ship4GroupBox.Text = "Aircraft Carrier";
            // 
            // deleteShip4Button
            // 
            this.deleteShip4Button.BackgroundImage = global::Battleships.Properties.Resources.delete;
            this.deleteShip4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteShip4Button.Enabled = false;
            this.deleteShip4Button.FlatAppearance.BorderSize = 0;
            this.deleteShip4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteShip4Button.Location = new System.Drawing.Point(153, 16);
            this.deleteShip4Button.Name = "deleteShip4Button";
            this.deleteShip4Button.Size = new System.Drawing.Size(39, 39);
            this.deleteShip4Button.TabIndex = 8;
            this.deleteShip4Button.UseVisualStyleBackColor = true;
            this.deleteShip4Button.Click += new System.EventHandler(this.DeleteShip4ButtonClick);
            // 
            // deployShip4Button
            // 
            this.deployShip4Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deployShip4Button.BackgroundImage")));
            this.deployShip4Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deployShip4Button.FlatAppearance.BorderSize = 0;
            this.deployShip4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deployShip4Button.Location = new System.Drawing.Point(6, 16);
            this.deployShip4Button.Name = "deployShip4Button";
            this.deployShip4Button.Size = new System.Drawing.Size(141, 39);
            this.deployShip4Button.TabIndex = 7;
            this.deployShip4Button.UseVisualStyleBackColor = true;
            this.deployShip4Button.Click += new System.EventHandler(this.Ship4ButtonClick);
            // 
            // shipRotateButton
            // 
            this.shipRotateButton.BackgroundImage = global::Battleships.Properties.Resources.rotateee;
            this.shipRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shipRotateButton.Enabled = false;
            this.shipRotateButton.FlatAppearance.BorderSize = 0;
            this.shipRotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shipRotateButton.Location = new System.Drawing.Point(29, 347);
            this.shipRotateButton.Name = "shipRotateButton";
            this.shipRotateButton.Size = new System.Drawing.Size(79, 80);
            this.shipRotateButton.TabIndex = 5;
            this.shipRotateButton.UseVisualStyleBackColor = true;
            this.shipRotateButton.Click += new System.EventHandler(this.ShipRotateButtonClick);
            // 
            // doneButton
            // 
            this.doneButton.BackgroundImage = global::Battleships.Properties.Resources.SVT_Play;
            this.doneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doneButton.Enabled = false;
            this.doneButton.FlatAppearance.BorderSize = 0;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Location = new System.Drawing.Point(124, 347);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(67, 80);
            this.doneButton.TabIndex = 11;
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButtonClick);
            // 
            // deckPictureBox
            // 
            this.deckPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deckPictureBox.Image = global::Battleships.Properties.Resources.bg;
            this.deckPictureBox.Location = new System.Drawing.Point(244, 28);
            this.deckPictureBox.Name = "deckPictureBox";
            this.deckPictureBox.Size = new System.Drawing.Size(377, 377);
            this.deckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deckPictureBox.TabIndex = 15;
            this.deckPictureBox.TabStop = false;
            this.deckPictureBox.Click += new System.EventHandler(this.DeckPictureBoxClick);
            this.deckPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DeckPictureBoxPaint);
            this.deckPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeckPictureBoxMouseMove);
            // 
            // ShipDeploymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 435);
            this.Controls.Add(this.shipRotateButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.deckPictureBox);
            this.Controls.Add(ship4GroupBox);
            this.Controls.Add(ship3GroupBox);
            this.Controls.Add(ship2GroupBox);
            this.Controls.Add(ship1GroupBox);
            this.Controls.Add(ship0GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShipDeploymentForm";
            this.Text = "Battleship: Place your ships!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShipDeploymentFormClosing);
            ship0GroupBox.ResumeLayout(false);
            ship1GroupBox.ResumeLayout(false);
            ship2GroupBox.ResumeLayout(false);
            ship3GroupBox.ResumeLayout(false);
            ship4GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deployShip0Button;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button deleteShip1Button;
        private System.Windows.Forms.Button deleteShip0Button;
        private System.Windows.Forms.Button shipRotateButton;
        private System.Windows.Forms.Button deployShip3Button;
        private System.Windows.Forms.Button deployShip2Button;
        private System.Windows.Forms.Button deployShip1Button;
        private System.Windows.Forms.Button deleteShip2Button;
        private System.Windows.Forms.Button deleteShip3Button;
        private System.Windows.Forms.Button deleteShip4Button;
        private System.Windows.Forms.Button deployShip4Button;
        private System.Windows.Forms.PictureBox deckPictureBox;
    }
}