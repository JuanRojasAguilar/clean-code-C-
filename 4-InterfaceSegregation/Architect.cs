namespace InterfaceSegregation
{
  public class Architect: IActivities
  {
    public Architect()
    {
    }
    public void Plan()
    {
      throw new ArgumentException();
    }

    public void Comunicate()
    {
      throw new ArgumentException();
    }

    public void Design()
    {
      throw new ArgumentException();
    }

    public void Develop()
    {
      throw new ArgumentException();
    }

    public void Test()
    {
      throw new ArgumentException();
    }
  }
}