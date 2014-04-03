using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Wumpus_Test
{
    public partial class WumpusForm : Form
    {

        Random gen = new Random();

        bool decision;
        int roomNumber = -1;
        private Wumpus wumpus;

        // Room numbers are randomly generated at this point to put into parameters.
        // Later build will take room numbers from Cave as parameters.
        int room1;
        int room2;
        int room3;

        public WumpusForm()
        {
            InitializeComponent();

        }

        private void ConstructorButton_Click(object sender, EventArgs e)
        {
            wumpus = new Wumpus();
            roomNumber = gen.Next(32);


            //Plays Sound. Need Common Sound Directory First
            Sound.playStartSound();

            room1 = gen.Next(32) + 1;
            room2 = gen.Next(32) + 1;
            room3 = gen.Next(32) + 1;

            while (room1 == room2 || room1 == room3 || room2 == room3 || 
                room1 == roomNumber || room2 == roomNumber|| room3 == roomNumber)
            {
                room1 = gen.Next(32) + 1;
                room2 = gen.Next(32) + 1;
                room3 = gen.Next(32) + 1;
            }

        }

        private void MoveConditions_CheckedChanged(object sender, EventArgs e)
        {
            decision = wumpus.WillMove(MoveConditions.Checked);
        }

        private void ReturnWumpusWillMove_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ReturnWumpusMoveBool_Click(object sender, EventArgs e)
        {
            ReturnWumpusWillMove.Text = decision.ToString();
        }

        private void ChangeRoom_Click(object sender, EventArgs e)
        {
            string str;

            if (wumpus.WillMove(MoveConditions.Checked))
            {
                wumpus.changeRoom(room1, room2, room3);

                changeRooms();

                while (room1 == room2 || room1 == room3 || room2 == room3)
                    changeRooms();

                roomNumber = wumpus.GetRoomNumber();

                while(room2 == roomNumber)
                    room2 = gen.Next(32) + 1;

                while(room3 == roomNumber)
                    room3 = gen.Next(32) + 1;

                str = "Changed!";             
            }

            else str = "Cannot Change!";
            
            ReturnRoomNumberChanged.Text = str;
        }

        private void CurrentRoomNumber_Click(object sender, EventArgs e)
        {
            string str;
            str = "Room number: " + roomNumber;
            ReturnCurrentRoomNumber.Text = str;
        }

        private void DisplayAdjacentRooms_Click(object sender, EventArgs e)
        {
            AdjacentRoom1.Text = room1.ToString();
            AdjacentRoom2.Text = room2.ToString();
            AdjacentRoom3.Text = room3.ToString();
        }

        public void changeRooms()
        {
            room1 = roomNumber;
            room2 = gen.Next(32) + 1;
            room3 = gen.Next(32) + 1;
        }
    }
}
