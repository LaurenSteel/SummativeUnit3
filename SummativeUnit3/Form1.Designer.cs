namespace SummativeUnit3
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
            this.SuspendLayout();
            // 
            // situationLabel
            // 
            this.situationLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situationLabel.Location = new System.Drawing.Point(12, 9);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(306, 196);
            this.situationLabel.TabIndex = 0;
            // 
            // aOutputLabel
            // 
            this.aOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOutputLabel.Location = new System.Drawing.Point(42, 215);
            this.aOutputLabel.Name = "aOutputLabel";
            this.aOutputLabel.Size = new System.Drawing.Size(613, 74);
            this.aOutputLabel.TabIndex = 1;
            // 
            // aLabel
            // 
            this.aLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.Location = new System.Drawing.Point(12, 215);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(25, 25);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "A.";
            // 
            // bLabel
            // 
            this.bLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.Location = new System.Drawing.Point(12, 305);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(25, 25);
            this.bLabel.TabIndex = 3;
            this.bLabel.Text = "B.";
            // 
            // bOutputLabel
            // 
            this.bOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOutputLabel.Location = new System.Drawing.Point(42, 305);
            this.bOutputLabel.Name = "bOutputLabel";
            this.bOutputLabel.Size = new System.Drawing.Size(613, 74);
            this.bOutputLabel.TabIndex = 4;
            // 
            // cLabel
            // 
            this.cLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.Location = new System.Drawing.Point(12, 392);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(25, 25);
            this.cLabel.TabIndex = 5;
            this.cLabel.Text = "C.";
            // 
            // cOutputLabel
            // 
            this.cOutputLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOutputLabel.Location = new System.Drawing.Point(42, 392);
            this.cOutputLabel.Name = "cOutputLabel";
            this.cOutputLabel.Size = new System.Drawing.Size(613, 74);
            this.cOutputLabel.TabIndex = 6;
            // 
            // chooseYourOwnAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(681, 479);
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
    }
}

