using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ch10CardLib;

namespace Ch10CardLibTest
{
	class Program
	{
		static void Main(string[] args)
		{
			//Initialize Deck
			Console.WriteLine("initializing deck");
			Deck deck = new Deck();
			deck.Print();
			Console.ReadKey();

			//Shuffle
			Console.WriteLine("Shuffling deck");
			deck.Shuffle();
			deck.Print();
			Console.ReadKey();
		}
	}
}
