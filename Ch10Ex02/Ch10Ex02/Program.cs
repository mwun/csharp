﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex02
{
	public class ClassA
	{
		private int _state = -1;

		public int State
		{
			get { return _state; }
		}

		public class ClassB
		{
			public void SetPrivateState(ClassA target, int newState)
			{
				target._state = newState;
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ClassA myObject = new ClassA();
			Console.WriteLine("myObject.State = {0}", myObject.State);
			ClassA.ClassB myOtherObject = new ClassA.ClassB();
			myOtherObject.SetPrivateState(myObject, 999);
			Console.WriteLine("myObject.State = {0}", myObject.State);
			Console.ReadKey();
		}
	}
}
