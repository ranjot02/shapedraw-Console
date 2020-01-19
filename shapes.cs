using System;
class Shapes
{
  protected static char drawletter;
  //protected string shapeownername;
  protected static int shapeheight;
  public static void Shape()
  {
    Console.WriteLine("What character should be used?");
    drawletter = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("What is the shapes height");
    shapeheight=int.Parse(Console.ReadLine());
  }
  public void GetShapeOwnerName()
  {

  }
  // public virtual void DrawShape(int shapeheight, char drawletter)
  // {
  //   Console.WriteLine("Drawing...");
  // }
}