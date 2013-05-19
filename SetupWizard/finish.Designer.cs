namespace SetupWizard
{
    partial class finish
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.derpPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.derpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(323, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Hooray! We\'re done!!";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(332, 134);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Exit!!";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // derpPicBox
            // 
            this.derpPicBox.Image = global::SetupWizard.Properties.Resources.betterthanexpected;
            this.derpPicBox.Location = new System.Drawing.Point(20, 48);
            this.derpPicBox.Name = "derpPicBox";
            this.derpPicBox.Size = new System.Drawing.Size(285, 244);
            this.derpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.derpPicBox.TabIndex = 1;
            this.derpPicBox.TabStop = false;
            // 
            // finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.derpPicBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "finish";
            this.Size = new System.Drawing.Size(428, 295);
            ((System.ComponentModel.ISupportInitialize)(this.derpPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox derpPicBox;
        private System.Windows.Forms.Button closeButton;
    }
}
