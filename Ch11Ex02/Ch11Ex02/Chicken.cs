﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
	public class Chicken : Animal
	{
		public void LayEgg()
		{
			Console.WriteLine("{0} has layed an egg", name);
		}
		public Chicken(string newName): base(newName)
		{ 
		}
	}
}
