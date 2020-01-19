using System;
class rectangle : Shapes
{
  private static int width;
  public static void Rectangle()
  {
    Console.WriteLine("Enter the width");
    width = int.Parse(Console.ReadLine());
    DrawShape(shapeheight, drawletter);
  }
  public static/*override*/ void DrawShape(int shapeheight, char drawletter)
  {
    //base.DrawShape();
    for (int i = 0;  i < shapeheight; i++)
    {
      for (int j = 0; j < width; j++)
      {
        Console.Write(drawletter);
      }
      Console.WriteLine();
    }
  }
}