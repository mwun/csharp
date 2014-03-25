using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
	public class Card
	{
		public readonly Suit _suit;
		public readonly Rank _rank;

		public Card(Suit newSuit, Rank newRank)
		{
			_suit = newSuit;
			_rank = newRank;
		}

		private Card()
		{
		}

		public override string ToString()
		{
			return "The " + _rank + " of " + _suit + "s";
		}
	}
}
