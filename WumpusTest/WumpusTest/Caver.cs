using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Caves
{
	/// <summary>
	/// utility methods for caves
	/// </summary>
	public static class Caver
	{
		/// <summary>
		/// maximum number of connections a cave can have to other caves
		/// </summary>
		public const int MaxConnectionsPerCave = 3;

		/// <summary>
		/// creates a list (of given size) of interconnected caves.
		/// the caves in the list are randomly connected to other caves.
		/// </summary>
		public static List<Cave> CreateCavesList(int size)
		{
			// create the list of caves
			List<Cave> result = new List<Cave>();
			for (int i = 0; i < size; i++)
			{
				result.Add(new Cave(i));
			}

			// create random connections to each cave
			Random rand = new Random();
			for (int i = 0; i < size; i++)
			{
				Cave c = result[i];
				for (int j = 0; j < Caver.MaxConnectionsPerCave; j++)
				{
					int r1 = -1;
					// search for a unconnected cave
					while ((r1 = rand.Next(0, 30)) == i || c.Connections.Contains(result[r1]));

					// make the forward connection
					c.Connections.Add(result[r1]);

					// make the reverse connection
					if (!result[r1].Connections.Contains(c))
					{
						result[r1].Connections.Add(c);
					}
				}
			}

			return result;
		}
	}
}
