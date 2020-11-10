namespace TaxationTest
{
    
  public class FixedProperty:ITaxable
  {

    protected string location;
    protected bool inCity; 
    protected decimal estimatedValue;

    public FixedProperty(string location, bool inCity, decimal value)
    {
      this.location = location;
      this.inCity = inCity;
      this.estimatedValue = value;
    }

    public FixedProperty(string location):this(location,true,1000000)
    {
    }

    public string Location{
      get
      {
        return location;
      }
    }

    public decimal TaxValue(){
    return estimatedValue * 0.5M;
    }
  }
}