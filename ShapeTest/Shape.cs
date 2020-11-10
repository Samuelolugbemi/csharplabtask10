namespace ShapeTest
{
  public class Shape : Location
  {
    protected Location c;

    public double Area()
    {

    }

    public double Perimeter()
    {

    }

    public override string ToString()
    {

    }
  }
  public class Rectangle : Shape
  {
    protected double side1;
    protected double side2;
  }
  public class Circle : Shape
  {
    protected double radius;
  }
}