using System;
class triangle : Shapes
{
  private static int startpoint = 1;
  private static double increase = 1;
  private static string eqra;
  public static void Triangle()
  {
    Console.WriteLine("1. RightAngle\n2. Equilateral");
    eqra = Console.ReadLine();
    Console.WriteLine("What is the increase per line");
    increase=Convert.ToDouble(Console.ReadLine());
    DrawShape(shapeheight, drawletter);
  }
  public static/*override*/ void DrawShape(int shapeheight, char drawletter)
  {
  if (eqra == "1"){
  increase=1/increase;
  for (int i = 0;  i < shapeheight; i++)
    {
      for (double j = 0; j < startpoint; j+=increase)
      {
        Console.Write(drawletter);
      }
    startpoint++;
    Console.WriteLine();
    }    startpoint = 1;
    }
    else if (eqra == "2"){
    increase=1/increase;
    for (int i = 0;  i < shapeheight; i++)
      {
        double len= Math.Floor((shapeheight/(2*increase)) - ((i/increase)/2));
        for (int k=1; k<len; k++)
        {Console.Write(' ');}
        for (double j = 0; j < startpoint; j+=increase)
        {
          Console.Write(drawletter);
        }
      startpoint++;
      Console.WriteLine();
      }
      startpoint = 1;
    } else {Console.WriteLine("That was invald");}
  }    
}