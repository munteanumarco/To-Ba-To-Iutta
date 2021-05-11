﻿
namespace To_Ba_To_Iutta
{
    partial class AsymmetricDecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsymmetricDecryptForm));
            this.inputLabel = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.keyNameLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.TextBox();
            this.getPublicKeyButton = new System.Windows.Forms.Button();
            this.manageKeysButton = new System.Windows.Forms.Button();
            this.keyPanel = new System.Windows.Forms.Panel();
            this.keyName = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.keyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.manageKeysButton);
            this.mainPanel.Controls.Add(this.getPublicKeyButton);
            this.mainPanel.Controls.Add(this.button);
            this.mainPanel.Controls.Add(this.keyPanel);
            this.mainPanel.Controls.Add(this.outputPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            this.mainPanel.Controls.Add(this.keyNameLabel);
            this.mainPanel.Controls.Add(this.outputLabel);
            this.mainPanel.Controls.Add(this.inputLabel);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Helvetica", 13F);
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(12, 12);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(55, 21);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input:";
            // 
            // button
            // 
            this.button.Cursor = System.Windows.Forms.Cursors.Default;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Minecraftia", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.Location = new System.Drawing.Point(614, 236);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(167, 58);
            this.button.TabIndex = 2;
            this.button.Text = "Decrypt";
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Helvetica", 13F);
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 308);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(69, 21);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output:";
            // 
            // keyNameLabel
            // 
            this.keyNameLabel.AutoSize = true;
            this.keyNameLabel.Font = new System.Drawing.Font("Helvetica", 13F);
            this.keyNameLabel.ForeColor = System.Drawing.Color.White;
            this.keyNameLabel.Location = new System.Drawing.Point(12, 238);
            this.keyNameLabel.Name = "keyNameLabel";
            this.keyNameLabel.Size = new System.Drawing.Size(96, 21);
            this.keyNameLabel.TabIndex = 6;
            this.keyNameLabel.Text = "Key name:";
            // 
            // input
            // 
            this.input.AcceptsTab = true;
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::To_Ba_To_Iutta.Properties.Settings.Default, "LastAsymmetricDecryptInput", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.input.Font = new System.Drawing.Font("Helvetica", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.Color.White;
            this.input.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.input.Location = new System.Drawing.Point(6, 6);
            this.input.MaxLength = 0;
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(655, 204);
            this.input.TabIndex = 0;
            this.input.Text = global::To_Ba_To_Iutta.Properties.Settings.Default.LastAsymmetricDecryptInput;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.input);
            this.inputPanel.Location = new System.Drawing.Point(114, 12);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(667, 216);
            this.inputPanel.TabIndex = 7;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.output);
            this.outputPanel.Location = new System.Drawing.Point(114, 302);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(667, 216);
            this.outputPanel.TabIndex = 8;
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Helvetica", 11F);
            this.output.ForeColor = System.Drawing.Color.White;
            this.output.Location = new System.Drawing.Point(6, 6);
            this.output.MaxLength = 0;
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(655, 204);
            this.output.TabIndex = 0;
            this.output.TabStop = false;
            // 
            // getPublicKeyButton
            // 
            this.getPublicKeyButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.getPublicKeyButton.FlatAppearance.BorderSize = 0;
            this.getPublicKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPublicKeyButton.Font = new System.Drawing.Font("Helvetica", 11F);
            this.getPublicKeyButton.ForeColor = System.Drawing.Color.White;
            this.getPublicKeyButton.Location = new System.Drawing.Point(114, 269);
            this.getPublicKeyButton.Name = "getPublicKeyButton";
            this.getPublicKeyButton.Size = new System.Drawing.Size(167, 25);
            this.getPublicKeyButton.TabIndex = 10;
            this.getPublicKeyButton.Text = "Get Public Key";
            this.getPublicKeyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getPublicKeyButton.UseVisualStyleBackColor = true;
            this.getPublicKeyButton.Click += new System.EventHandler(this.getPublicKeyButton_Click);
            // 
            // manageKeysButton
            // 
            this.manageKeysButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageKeysButton.FlatAppearance.BorderSize = 0;
            this.manageKeysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageKeysButton.Font = new System.Drawing.Font("Helvetica", 11F);
            this.manageKeysButton.ForeColor = System.Drawing.Color.White;
            this.manageKeysButton.Location = new System.Drawing.Point(289, 269);
            this.manageKeysButton.Name = "manageKeysButton";
            this.manageKeysButton.Size = new System.Drawing.Size(167, 25);
            this.manageKeysButton.TabIndex = 11;
            this.manageKeysButton.Text = "Manage Keys";
            this.manageKeysButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageKeysButton.UseVisualStyleBackColor = true;
            this.manageKeysButton.Click += new System.EventHandler(this.manageKeysButton_Click);
            // 
            // keyPanel
            // 
            this.keyPanel.BackColor = System.Drawing.Color.Transparent;
            this.keyPanel.Controls.Add(this.keyName);
            this.keyPanel.ForeColor = System.Drawing.Color.White;
            this.keyPanel.Location = new System.Drawing.Point(114, 236);
            this.keyPanel.Name = "keyPanel";
            this.keyPanel.Size = new System.Drawing.Size(494, 25);
            this.keyPanel.TabIndex = 9;
            // 
            // keyName
            // 
            this.keyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.keyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyName.Font = new System.Drawing.Font("Helvetica", 11F);
            this.keyName.ForeColor = System.Drawing.Color.White;
            this.keyName.Location = new System.Drawing.Point(8, 4);
            this.keyName.Name = "keyName";
            this.keyName.Size = new System.Drawing.Size(481, 18);
            this.keyName.TabIndex = 0;
            this.keyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyName_KeyDown);
            // 
            // AsymmetricDecryptForm
            // 
            this.AcceptButton = this.button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(794, 530);
            this.Name = "AsymmetricDecryptForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.keyPanel.ResumeLayout(false);
            this.keyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label keyNameLabel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button getPublicKeyButton;
        private System.Windows.Forms.Button manageKeysButton;
        private System.Windows.Forms.Panel keyPanel;
        private System.Windows.Forms.TextBox keyName;
    }
}