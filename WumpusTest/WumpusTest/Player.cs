using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
    public partial class playerForm : Form
    {
        private Player p1 = new Player();
        public playerForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void getStatusButton_Click(object sender, EventArgs e)
        {
            statusText.Text = p1.toString();
        }
    }
    public class Player
    {
        #region variables
        private int roomNumber;
        private int arrows;
        private int gold;
        private int score;
        private String name;
        private int[] connectingRooms= new int[3]; 
        #endregion
        public Player()
        {
            name = "Player 1";
            roomNumber = -1;
            arrows = 0;
            gold = 0;
            score = 0;
        }
        public Player(String name)
        {
            this.name = name;
            roomNumber = -1;
            arrows = 0;
            gold = 0;
            score = 0;
        }
        public int getRoomNumber()
        {
            return roomNumber;
        }
        public int getArrows()
        {
            return arrows;
        }
        public int getGold()
        {
            return gold;
        }
        public int getScore()
        {
            return score;
        }
        public void setRoomNumber(int room)
        {
            roomNumber = room;
        }
        public void setArrows(int arrows)
        {
            this.arrows = arrows;
        }
        public void buyArrow()
        {
            if(gold>=5){
                arrows++;
                gold-=5;
            }
        }
        public void setGold(int gold)
        {
            this.gold = gold;
        }
        public void earnGold(int earned){
            gold += earned;
        }
        public void updateScore(int earned)
        {
            score += earned;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
        public void getConnectingRooms(int[] rooms)
        {
            connectingRooms = rooms;
        }
        public String toString()
        {
            String str = "";
            str += "Name: " + name + Environment.NewLine;
            str += "Current Room: " + roomNumber + Environment.NewLine;
            str += "Arrows: " + arrows + Environment.NewLine;
            str += "Gold: " + gold + Environment.NewLine;
            str += "Score: " + score + Environment.NewLine;
            return str;
        }
    }
}
