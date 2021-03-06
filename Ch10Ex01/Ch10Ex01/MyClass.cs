﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Ex01
{
	public class MyClass
	{
		public readonly string Name;
		private int _intVal;

		public int Val
		{
			get { return _intVal; }
			set 
			{
				if (value >= 0 && value <= 10)
					_intVal = value;
				else
					throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value betwen 0 and 10."));
			}
		}

		public override string ToString()
		{
			return "Name: " + Name + "\nVal: " + Val;
		}

		private MyClass()
			: this("Default Name")
		{
		}

		public MyClass(string newName)
		{
			Name = newName;
			_intVal = 0;
		}
	}
}
