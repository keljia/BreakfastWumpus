using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Caves
{
	/// <summary>
	/// represents a cave
	/// </summary>
	public class Cave
	{
		/// <summary>
		/// number of this cave
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// the other caves this cave is connected to
		/// </summary>
		public List<Cave> Connections { get; private set; }

		/// <summary>
		/// default constructor
		/// </summary>
		public Cave()
		{
			// set the default number to -1
			this.Number = -1;

			// create the empty connection list
			this.Connections = new List<Cave>();
		}

		/// <summary>
		/// overloaded constructor. creates a cave with the given number.
		/// </summary>
		public Cave(int number) : this()
		{
			this.Number = number;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            String s =  Number.ToString();
            for (int i = 0; i < Connections.Count; i++)
            {
                s += Connections[i];
            }


            return Number.ToString();
        }
	}
}
