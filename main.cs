using System;

class MainClass
{    

  public static void Main (string[] args) {
    int sha = 0;
    do{
      Console.WriteLine("1.Rectangle\n2.Triange\n3.Exit");
      sha=int.Parse(Console.ReadLine());
      switch (sha)
      {
        case 1:
          rectangle.Shape();
          rectangle.Rectangle();
          break;
        case 2:
          triangle.Shape();
          triangle.Triangle();
          break;
        case 3:
          Console.WriteLine("Bye");
          Console.ReadLine();
          break;
      }
    } while (sha != 3);
  }
}