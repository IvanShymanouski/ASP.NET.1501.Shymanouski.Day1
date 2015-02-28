using System;
using tree;

class Program
{
	static void Main()
	{
        Apple obj1 = new Apple();
        obj1.AppleInfo();

        DutchApple obj2 = new DutchApple();
        obj2.DutchAppleInfo();

        PolishApple obj3 = new PolishApple();
        obj3.PolishAppleInfo();

        Console.ReadLine();
	}
}
