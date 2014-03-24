using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09ex03
{
  class MyClass
  {
    public int val;
  }

  struct MyStruct
  {
    public int val;
  }

  class Program
  {
    static void Main(string[] args)
    {
      MyClass objectA = new MyClass();
      MyClass objectB = objectA;
      objectA.val = 10;
      objectB.val = 20;
      MyStruct structA = new MyStruct();
      MyStruct structB = structA;
      structA.val = 30;
      structB.val = 40;
      Console.WriteLine("objectA.val = {0}", objectA.val);
      Console.WriteLine("objectB.val = {0}", objectB.val);
      Console.WriteLine("structA.val = {0}", structA.val);
      Console.WriteLine("structB.val = {0}", structB.val);
      Console.ReadKey();
    }
  }
}
