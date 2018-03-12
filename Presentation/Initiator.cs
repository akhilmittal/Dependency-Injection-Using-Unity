using Business;
namespace Presentation
{
  public class Initiator
  {
    IBusiness _businessClass;
    public Initiator(IBusiness businessClass)
    {
      _businessClass = businessClass;
    }
    public string FetchData()
    {
      return _businessClass.GetBusinessData();
    }
  }
}
