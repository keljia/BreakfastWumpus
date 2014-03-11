namespace WumpusTest
{
    partial class mapForm
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
            this.MapGenerator = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mapText = new System.Windows.Forms.TextBox();
            this.toStringButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.difficultyText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MapGenerator
            // 
            this.MapGenerator.Location = new System.Drawing.Point(120, 5);
            this.MapGenerator.Name = "MapGenerator";
            this.MapGenerator.Size = new System.Drawing.Size(111, 23);
            this.MapGenerator.TabIndex = 0;
            this.MapGenerator.Text = "Generate Map";
            this.MapGenerator.UseVisualStyleBackColor = true;
            this.MapGenerator.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(89, 450);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(25, 20);
            this.inputText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room Number:";
            // 
            // mapText
            // 
            this.mapText.Location = new System.Drawing.Point(8, 37);
            this.mapText.Multiline = true;
            this.mapText.Name = "mapText";
            this.mapText.Size = new System.Drawing.Size(223, 399);
            this.mapText.TabIndex = 6;
            // 
            // toStringButton
            // 
            this.toStringButton.Location = new System.Drawing.Point(8, 476);
            this.toStringButton.Name = "toStringButton";
            this.toStringButton.Size = new System.Drawing.Size(106, 46);
            this.toStringButton.TabIndex = 11;
            this.toStringButton.Text = "Full Data";
            this.toStringButton.UseVisualStyleBackColor = true;
            this.toStringButton.Click += new System.EventHandler(this.toStringButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(120, 450);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(111, 72);
            this.outputText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Input Difficulty:";
            // 
            // difficultyText
            // 
            this.difficultyText.Location = new System.Drawing.Point(89, 7);
            this.difficultyText.Name = "difficultyText";
            this.difficultyText.Size = new System.Drawing.Size(25, 20);
            this.difficultyText.TabIndex = 14;
            // 
            // mapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 531);
            this.Controls.Add(this.difficultyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.toStringButton);
            this.Controls.Add(this.mapText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.MapGenerator);
            this.Name = "mapForm";
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MapGenerator;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mapText;
        private System.Windows.Forms.Button toStringButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox difficultyText;
    }
}