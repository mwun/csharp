using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
	public class Deck
	{
		private Card[] _cards;

		public Deck()
		{
			_cards = new Card[52];
			for (int i = 0; i < 4; i++)
				for (int j = 0; j < 13; j++)
				{
					_cards[i * 13 + j] = new Card((Suit)(i), (Rank)(j+1));
				}
		}

		public void Shuffle()
		{
			Card[] newDeck = new Card[52];
			bool[] assigned = new bool[52];
			Random sourceGen = new Random();
			for (int i = 0; i < 52; i++)
			{
				int destCard = 0;
				bool foundCard = false;
				while (foundCard == false)
				{
					destCard = sourceGen.Next(52);
					if (assigned[destCard] == false)
						foundCard = true;
				}
				assigned[destCard] = true;
				newDeck[destCard] = _cards[i];
			}
			newDeck.CopyTo(_cards, 0);
		}

		public Card getCard(int cardNum)
		{
			if (cardNum > 0 && cardNum <= 52)
				return _cards[cardNum - 1];
			else 
				throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 1 and 52"));
		}

		public void Print()
		{
			for (int i = 1; i != 53; i++)
			{
				Console.WriteLine(getCard(i));
			}
		}
	}
}
