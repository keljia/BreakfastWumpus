namespace Wumpus_Test
{
    partial class WumpusForm
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
            this.Constructor = new System.Windows.Forms.Button();
            this.ReturnWumpusMoveBool = new System.Windows.Forms.Button();
            this.MoveConditions = new System.Windows.Forms.CheckBox();
            this.ChangeRoom = new System.Windows.Forms.Button();
            this.ReturnWumpusWillMove = new System.Windows.Forms.TextBox();
            this.ReturnRoomNumberChanged = new System.Windows.Forms.TextBox();
            this.CurrentRoomNumber = new System.Windows.Forms.Button();
            this.ReturnCurrentRoomNumber = new System.Windows.Forms.TextBox();
            this.DisplayAdjacentRooms = new System.Windows.Forms.Button();
            this.AdjacentRoom1 = new System.Windows.Forms.TextBox();
            this.AdjacentRoom2 = new System.Windows.Forms.TextBox();
            this.AdjacentRoom3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Constructor
            // 
            this.Constructor.Location = new System.Drawing.Point(12, 12);
            this.Constructor.Name = "Constructor";
            this.Constructor.Size = new System.Drawing.Size(139, 23);
            this.Constructor.TabIndex = 0;
            this.Constructor.Text = "Create Wumpus Object";
            this.Constructor.UseVisualStyleBackColor = true;
            this.Constructor.Click += new System.EventHandler(this.ConstructorButton_Click);
            // 
            // ReturnWumpusMoveBool
            // 
            this.ReturnWumpusMoveBool.Location = new System.Drawing.Point(328, 12);
            this.ReturnWumpusMoveBool.Name = "ReturnWumpusMoveBool";
            this.ReturnWumpusMoveBool.Size = new System.Drawing.Size(133, 23);
            this.ReturnWumpusMoveBool.TabIndex = 2;
            this.ReturnWumpusMoveBool.Text = "Wumpus Will Move";
            this.ReturnWumpusMoveBool.UseVisualStyleBackColor = true;
            this.ReturnWumpusMoveBool.Click += new System.EventHandler(this.ReturnWumpusMoveBool_Click);
            // 
            // MoveConditions
            // 
            this.MoveConditions.AutoSize = true;
            this.MoveConditions.Location = new System.Drawing.Point(12, 285);
            this.MoveConditions.Name = "MoveConditions";
            this.MoveConditions.Size = new System.Drawing.Size(126, 17);
            this.MoveConditions.TabIndex = 3;
            this.MoveConditions.Text = "Move Conditions Met";
            this.MoveConditions.UseVisualStyleBackColor = true;
            this.MoveConditions.CheckedChanged += new System.EventHandler(this.MoveConditions_CheckedChanged);
            // 
            // ChangeRoom
            // 
            this.ChangeRoom.Location = new System.Drawing.Point(478, 12);
            this.ChangeRoom.Name = "ChangeRoom";
            this.ChangeRoom.Size = new System.Drawing.Size(135, 23);
            this.ChangeRoom.TabIndex = 4;
            this.ChangeRoom.Text = "Change Room";
            this.ChangeRoom.UseVisualStyleBackColor = true;
            this.ChangeRoom.Click += new System.EventHandler(this.ChangeRoom_Click);
            // 
            // ReturnWumpusWillMove
            // 
            this.ReturnWumpusWillMove.Location = new System.Drawing.Point(328, 41);
            this.ReturnWumpusWillMove.Name = "ReturnWumpusWillMove";
            this.ReturnWumpusWillMove.ReadOnly = true;
            this.ReturnWumpusWillMove.Size = new System.Drawing.Size(133, 20);
            this.ReturnWumpusWillMove.TabIndex = 5;
            this.ReturnWumpusWillMove.TextChanged += new System.EventHandler(this.ReturnWumpusWillMove_TextChanged);
            // 
            // ReturnRoomNumberChanged
            // 
            this.ReturnRoomNumberChanged.Location = new System.Drawing.Point(478, 41);
            this.ReturnRoomNumberChanged.Name = "ReturnRoomNumberChanged";
            this.ReturnRoomNumberChanged.ReadOnly = true;
            this.ReturnRoomNumberChanged.Size = new System.Drawing.Size(135, 20);
            this.ReturnRoomNumberChanged.TabIndex = 6;
            // 
            // CurrentRoomNumber
            // 
            this.CurrentRoomNumber.Location = new System.Drawing.Point(158, 11);
            this.CurrentRoomNumber.Name = "CurrentRoomNumber";
            this.CurrentRoomNumber.Size = new System.Drawing.Size(131, 23);
            this.CurrentRoomNumber.TabIndex = 7;
            this.CurrentRoomNumber.Text = "Current Room Number";
            this.CurrentRoomNumber.UseVisualStyleBackColor = true;
            this.CurrentRoomNumber.Click += new System.EventHandler(this.CurrentRoomNumber_Click);
            // 
            // ReturnCurrentRoomNumber
            // 
            this.ReturnCurrentRoomNumber.Location = new System.Drawing.Point(158, 40);
            this.ReturnCurrentRoomNumber.Name = "ReturnCurrentRoomNumber";
            this.ReturnCurrentRoomNumber.ReadOnly = true;
            this.ReturnCurrentRoomNumber.Size = new System.Drawing.Size(131, 20);
            this.ReturnCurrentRoomNumber.TabIndex = 8;
            // 
            // DisplayAdjacentRooms
            // 
            this.DisplayAdjacentRooms.Location = new System.Drawing.Point(158, 105);
            this.DisplayAdjacentRooms.Name = "DisplayAdjacentRooms";
            this.DisplayAdjacentRooms.Size = new System.Drawing.Size(133, 23);
            this.DisplayAdjacentRooms.TabIndex = 9;
            this.DisplayAdjacentRooms.Text = "Show Adjacent Rooms";
            this.DisplayAdjacentRooms.UseVisualStyleBackColor = true;
            this.DisplayAdjacentRooms.Click += new System.EventHandler(this.DisplayAdjacentRooms_Click);
            // 
            // AdjacentRoom1
            // 
            this.AdjacentRoom1.Location = new System.Drawing.Point(158, 134);
            this.AdjacentRoom1.Name = "AdjacentRoom1";
            this.AdjacentRoom1.ReadOnly = true;
            this.AdjacentRoom1.Size = new System.Drawing.Size(131, 20);
            this.AdjacentRoom1.TabIndex = 10;
            // 
            // AdjacentRoom2
            // 
            this.AdjacentRoom2.Location = new System.Drawing.Point(158, 160);
            this.AdjacentRoom2.Name = "AdjacentRoom2";
            this.AdjacentRoom2.ReadOnly = true;
            this.AdjacentRoom2.Size = new System.Drawing.Size(131, 20);
            this.AdjacentRoom2.TabIndex = 11;
            // 
            // AdjacentRoom3
            // 
            this.AdjacentRoom3.Location = new System.Drawing.Point(158, 186);
            this.AdjacentRoom3.Name = "AdjacentRoom3";
            this.AdjacentRoom3.ReadOnly = true;
            this.AdjacentRoom3.Size = new System.Drawing.Size(131, 20);
            this.AdjacentRoom3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 314);
            this.Controls.Add(this.AdjacentRoom3);
            this.Controls.Add(this.AdjacentRoom2);
            this.Controls.Add(this.AdjacentRoom1);
            this.Controls.Add(this.DisplayAdjacentRooms);
            this.Controls.Add(this.ReturnCurrentRoomNumber);
            this.Controls.Add(this.CurrentRoomNumber);
            this.Controls.Add(this.ReturnRoomNumberChanged);
            this.Controls.Add(this.ReturnWumpusWillMove);
            this.Controls.Add(this.ChangeRoom);
            this.Controls.Add(this.MoveConditions);
            this.Controls.Add(this.ReturnWumpusMoveBool);
            this.Controls.Add(this.Constructor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Constructor;
        private System.Windows.Forms.Button ReturnWumpusMoveBool;
        private System.Windows.Forms.CheckBox MoveConditions;
        private System.Windows.Forms.Button ChangeRoom;
        private System.Windows.Forms.TextBox ReturnWumpusWillMove;
        private System.Windows.Forms.TextBox ReturnRoomNumberChanged;
        private System.Windows.Forms.Button CurrentRoomNumber;
        private System.Windows.Forms.TextBox ReturnCurrentRoomNumber;
        private System.Windows.Forms.Button DisplayAdjacentRooms;
        private System.Windows.Forms.TextBox AdjacentRoom1;
        private System.Windows.Forms.TextBox AdjacentRoom2;
        private System.Windows.Forms.TextBox AdjacentRoom3;
    }
}

