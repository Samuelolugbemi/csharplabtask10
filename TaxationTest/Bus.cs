using System;

namespace TaxationTest
{
    
  public class Bus: Vehicle
  {

    protected int numberOfSeats;

    public Bus(int numberOfSeats, int regNumber, decimal value):base(regNumber, 80, value)
    {
      this.numberOfSeats = numberOfSeats;
    }

    public int NumberOfSeats
    {
      get
      {
      return numberOfSeats;
      }
    } 
    public decimal TaxValue()
    {
        return (decimal)numberOfSeats * 500M;
    }
  }
}