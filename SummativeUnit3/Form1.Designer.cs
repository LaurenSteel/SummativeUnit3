﻿namespace SummativeUnit3
{
    partial class chooseYourOwnAdventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chooseYourOwnAdventure));
            this.situationLabel = new System.Windows.Forms.Label();
            this.aOutputLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.bOutputLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.cOutputLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // situationLabel
            // 
            this.situationLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situationLabel.Location = new System.Drawing.Point(12, 9);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(306, 437);
            this.situationLabel.TabIndex = 0;
            // 
            // aOutputLabel
            // 
            this.aOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOutputLabel.Location = new System.Drawing.Point(42, 446);
            this.aOutputLabel.Name = "aOutputLabel";
            this.aOutputLabel.Size = new System.Drawing.Size(896, 74);
            this.aOutputLabel.TabIndex = 1;
            // 
            // aLabel
            // 
            this.aLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.Location = new System.Drawing.Point(12, 446);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(35, 30);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "A.";
            // 
            // bLabel
            // 
            this.bLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(12, 542);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(35, 26);
            this.bLabel.TabIndex = 3;
            // 
            // bOutputLabel
            // 
            this.bOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOutputLabel.Location = new System.Drawing.Point(42, 542);
            this.bOutputLabel.Name = "bOutputLabel";
            this.bOutputLabel.Size = new System.Drawing.Size(896, 74);
            this.bOutputLabel.TabIndex = 4;
            // 
            // cLabel
            // 
            this.cLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(12, 625);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(35, 29);
            this.cLabel.TabIndex = 5;
            // 
            // cOutputLabel
            // 
            this.cOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOutputLabel.Location = new System.Drawing.Point(42, 625);
            this.cOutputLabel.Name = "cOutputLabel";
            this.cOutputLabel.Size = new System.Drawing.Size(896, 74);
            this.cOutputLabel.TabIndex = 6;
            // 
            // imageLabel
            // 
            this.imageLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Image = global::SummativeUnit3.Properties.Resources.forestStart;
            this.imageLabel.Location = new System.Drawing.Point(324, 9);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(614, 420);
            this.imageLabel.TabIndex = 7;
            // 
            // chooseYourOwnAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(958, 708);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.cOutputLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.bOutputLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.aOutputLabel);
            this.Controls.Add(this.situationLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chooseYourOwnAdventure";
            this.Text = "Plane Crash";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chooseYourOwnAdventure_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label situationLabel;
        private System.Windows.Forms.Label aOutputLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label bOutputLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label cOutputLabel;
        private System.Windows.Forms.Label imageLabel;
    }
}

