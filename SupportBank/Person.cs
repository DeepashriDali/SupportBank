namespace SupportBank
{
  public class Person
  {
    public string? PersonName {get; set;}
    public int AmountOwes {get; set;}
    public int AmountOwed {get; set;}

    public Person(string personName, int amountOwes, int amountOwed)

    {
        PersonName = personName;
        AmountOwes = amountOwes;
        AmountOwed = amountOwed;
    }

  }

}