namespace Springfield
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Title = new System.Windows.Forms.Label();
            this.reactor2Title = new System.Windows.Forms.Label();
            this.reactor1StatusLabel = new System.Windows.Forms.Label();
            this.reactor2StatusLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(92, 29);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(407, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            // 
            // reactor1Title
            // 
            this.reactor1Title.AutoSize = true;
            this.reactor1Title.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Title.Location = new System.Drawing.Point(124, 92);
            this.reactor1Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reactor1Title.Name = "reactor1Title";
            this.reactor1Title.Size = new System.Drawing.Size(99, 22);
            this.reactor1Title.TabIndex = 1;
            this.reactor1Title.Text = "Reactor 1";
            // 
            // reactor2Title
            // 
            this.reactor2Title.AutoSize = true;
            this.reactor2Title.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Title.Location = new System.Drawing.Point(362, 92);
            this.reactor2Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reactor2Title.Name = "reactor2Title";
            this.reactor2Title.Size = new System.Drawing.Size(99, 22);
            this.reactor2Title.TabIndex = 2;
            this.reactor2Title.Text = "Reactor 2";
            // 
            // reactor1StatusLabel
            // 
            this.reactor1StatusLabel.BackColor = System.Drawing.Color.Green;
            this.reactor1StatusLabel.Location = new System.Drawing.Point(96, 130);
            this.reactor1StatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reactor1StatusLabel.Name = "reactor1StatusLabel";
            this.reactor1StatusLabel.Size = new System.Drawing.Size(163, 116);
            this.reactor1StatusLabel.TabIndex = 3;
            // 
            // reactor2StatusLabel
            // 
            this.reactor2StatusLabel.BackColor = System.Drawing.Color.Green;
            this.reactor2StatusLabel.Location = new System.Drawing.Point(336, 130);
            this.reactor2StatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.reactor2StatusLabel.Name = "reactor2StatusLabel";
            this.reactor2StatusLabel.Size = new System.Drawing.Size(163, 116);
            this.reactor2StatusLabel.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(128, 275);
            this.startButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(355, 32);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(37, 358);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(536, 37);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(608, 432);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactor2StatusLabel);
            this.Controls.Add(this.reactor1StatusLabel);
            this.Controls.Add(this.reactor2Title);
            this.Controls.Add(this.reactor1Title);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Springfield Nuclear Power Plant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Title;
        private System.Windows.Forms.Label reactor2Title;
        private System.Windows.Forms.Label reactor1StatusLabel;
        private System.Windows.Forms.Label reactor2StatusLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

