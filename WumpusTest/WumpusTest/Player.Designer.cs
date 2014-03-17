namespace WumpusTest
{
    partial class playerForm
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
            this.getStatusButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getStatusButton
            // 
            this.getStatusButton.Location = new System.Drawing.Point(12, 12);
            this.getStatusButton.Name = "getStatusButton";
            this.getStatusButton.Size = new System.Drawing.Size(160, 34);
            this.getStatusButton.TabIndex = 11;
            this.getStatusButton.Text = "Get Status";
            this.getStatusButton.UseVisualStyleBackColor = true;
            this.getStatusButton.Click += new System.EventHandler(this.getStatusButton_Click);
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusText.Location = new System.Drawing.Point(12, 52);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(160, 74);
            this.statusText.TabIndex = 1;
            // 
            // playerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 139);
            this.Controls.Add(this.getStatusButton);
            this.Controls.Add(this.statusText);
            this.Name = "playerForm";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.Button getStatusButton;
    }
}