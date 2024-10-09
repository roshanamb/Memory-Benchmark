// See https://aka.ms/new-console-template for more information

using DSAConcepts;

//Array Basic
System.Console.WriteLine("Arrays Basic :-----------------------------------");
Arrays arr = new Arrays();
arr.Print();

//Problem: Array Leader
System.Console.WriteLine("Problem: Array Leader----------------------------");
ArrayLeader.Print(ArrayLeader.Leaders(new int[] { 16, 17, 4, 3, 5, 2 }, 6));
ArrayLeader.Print(ArrayLeader.Leaders(new int[] { 10, 4, 2, 4, 1 }, 5));
ArrayLeader.Print(ArrayLeader.Leaders(new int[] { 5, 10, 20, 40 }, 4));
ArrayLeader.Print(ArrayLeader.Leaders(new int[] { 30, 10, 10, 5 }, 4));

//Problem: Equilibrium Point
System.Console.WriteLine("Problem: Equilibrium Point-----------------------");
System.Console.WriteLine("Equilibrium Point for [1] is {0}", Equilibrium.Point(new int[] { 1 }));
System.Console.WriteLine("Equilibrium Point for [1, 3, 5] is {0}", Equilibrium.Point(new int[] { 1, 3, 5 }));
System.Console.WriteLine("Equilibrium Point for [1, 3, 5, 2, 2] is {0}", Equilibrium.Point(new int[] { 1, 3, 5, 2, 2 }));
