namespace Battleships
{
    partial class MainGameForm
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
            System.Windows.Forms.Label opponentFleetLabel;
            System.Windows.Forms.Label yourFleetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameForm));
            this.deck1PictureBox = new System.Windows.Forms.PictureBox();
            this.deck2PictureBox = new System.Windows.Forms.PictureBox();
            opponentFleetLabel = new System.Windows.Forms.Label();
            yourFleetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deck1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // opponentFleetLabel
            // 
            opponentFleetLabel.BackColor = System.Drawing.Color.Transparent;
            opponentFleetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            opponentFleetLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            opponentFleetLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            opponentFleetLabel.Location = new System.Drawing.Point(8, 392);
            opponentFleetLabel.Name = "opponentFleetLabel";
            opponentFleetLabel.Size = new System.Drawing.Size(377, 23);
            opponentFleetLabel.TabIndex = 81;
            opponentFleetLabel.Text = "COMPUTER\'S FLEET";
            opponentFleetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourFleetLabel
            // 
            yourFleetLabel.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yourFleetLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            yourFleetLabel.Location = new System.Drawing.Point(408, 392);
            yourFleetLabel.Name = "yourFleetLabel";
            yourFleetLabel.Size = new System.Drawing.Size(377, 23);
            yourFleetLabel.TabIndex = 82;
            yourFleetLabel.Text = "YOUR FLEET";
            yourFleetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deck1PictureBox
            // 
            this.deck1PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deck1PictureBox.Image = global::Battleships.Properties.Resources.bg;
            this.deck1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.deck1PictureBox.Name = "deck1PictureBox";
            this.deck1PictureBox.Size = new System.Drawing.Size(377, 377);
            this.deck1PictureBox.TabIndex = 36;
            this.deck1PictureBox.TabStop = false;
            this.deck1PictureBox.Click += new System.EventHandler(this.deckPictureBoxClick);
            this.deck1PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.deck1PictureBoxPaint);
            this.deck1PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.deck1PictureBoxMouseMove);
            // 
            // deck2PictureBox
            // 
            this.deck2PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.deck2PictureBox.Image = global::Battleships.Properties.Resources.bg;
            this.deck2PictureBox.Location = new System.Drawing.Point(408, 12);
            this.deck2PictureBox.Name = "deck2PictureBox";
            this.deck2PictureBox.Size = new System.Drawing.Size(377, 377);
            this.deck2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deck2PictureBox.TabIndex = 57;
            this.deck2PictureBox.TabStop = false;
            this.deck2PictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.deck2PictureBoxPaint);
            // 
            // MainGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 424);
            this.Controls.Add(yourFleetLabel);
            this.Controls.Add(opponentFleetLabel);
            this.Controls.Add(this.deck2PictureBox);
            this.Controls.Add(this.deck1PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGameForm";
            this.Text = "Battleship: Sink the ships!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.deck1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck2PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox deck1PictureBox;
        private System.Windows.Forms.PictureBox deck2PictureBox;
    }
}