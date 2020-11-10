namespace TaxationTest
{
  public class Vehicle:ITaxable
  {

    protected int registrationNumber;
    protected double maxVelocity;
    protected decimal value;

    public Vehicle(int registrationNumber, double maxVelocity, decimal value)
    {
      this.registrationNumber = registrationNumber;
      this.maxVelocity = maxVelocity;
      this.value = value;
    }

    public int RegistrationNumber
    {
      get
      {
        return registrationNumber;
      }
    }

    public decimal TaxValue()
    {
        return (decimal)this.maxVelocity * value * 0.25M;
    }

  }
}