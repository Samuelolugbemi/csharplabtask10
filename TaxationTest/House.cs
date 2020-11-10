namespace TaxationTest
{
  public class House: FixedProperty 
  {

    protected double area;

    public House(string location, bool inCity, double area, decimal value):base(location, inCity, value)
    {
    this.area = area;
    }

    public double Area
    {
      get
      {
      return area;
      }
    } 

    public decimal TaxValue(){
        return estimatedValue * 0.35M;
    }
  }
}