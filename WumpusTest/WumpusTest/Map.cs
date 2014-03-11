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
    public partial class mapForm : Form
    {
        #region variables
        private static Random gen = new Random();
        Room[] map;
        #endregion
        public mapForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            newMap(1);
            mapText.Text = toString();
        }
        public void newMap(int difficulty)
        {
            map = new Room[30];
            String difficultStr = difficultyText.Text;
            int difficult = 5 + (Convert.ToInt32(difficultStr)*5);
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = new Room();
            }
            for (int i = 0; i < difficult; i++)
            {
                int tempRoom = gen.Next(30);
                while (map[tempRoom].getContents() == -1)
                {
                    tempRoom = gen.Next(30);
                }
                map[tempRoom].setContents(-1);
            }
            int wumpusRoom = gen.Next(30);
            map[wumpusRoom].setWumpus(true);
        }
        public int roomContains(int roomNumber)
        {
            int contain = map[roomNumber].getContents();
            return contain;
        }
        public string toString()
        {
            String str="";
            for (int i = 0; i < map.Length; i++)
            {
                str += "Room " + (i + 1) + " " + map[i].toString() + Environment.NewLine;
            }
            return str;
        }
        private void toStringButton_Click(object sender, EventArgs e)
        {
            String inputStr = inputText.Text;
            int input = Convert.ToInt32(inputStr)-1;
            String output = "Room " + (input+1) + ": ";
            output += Environment.NewLine + "Has Wumpus: " + map[input].getWumpus();
            output += Environment.NewLine + "Has Bats: " + map[input].getBats();
            output += Environment.NewLine + "Has Pits: " + map[input].getPit();
            output += Environment.NewLine + "Been Used: " + map[input].getUsed();
            outputText.Text = output;
        }
    }
    public class Room
    {
        #region variables
        private int contents;
        private bool hasWumpus;
        private bool used;
        private static Random gen = new Random();
        #endregion
        public Room()
        {
            contents = gen.Next(2);
            hasWumpus = false;
            used = false;
        }
        public void setContents(int set)
        {
            contents = set;
        }
        public void setWumpus(bool wump)
        {
            hasWumpus = wump;
        }
        public void setUsed(bool use)
        {
            used = use;
        }
        public int getContents()
        {
            return contents;
        }
        public bool getBats()
        {
            if (contents == 0)
            {
                return true;
            }
            return false;
        }
        public bool getPit()
        {
            if (contents == 1)
            {
                return true;
            }
            return false;
        }
        public bool getWumpus()
        {
            return hasWumpus;
        }
        public bool getUsed()
        {
            return used;
        }
        public String toString()
        {
            String str = "contains ";
            if (contents == 0)
            {
                str += "bats ";
            }
            else if (contents == 1)
            {
                str += "a pit ";
            }
            else
            {
                str += "nothing ";
            }
            if (hasWumpus)
            {
                if (str.Equals("contains nothing "))
                {
                    str += "but ";
                }
                else
                {
                    str += "and ";
                }
                str += "the wumpus";
            }
            return str;
        }
    }
}
