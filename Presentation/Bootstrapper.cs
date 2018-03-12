using Business;
namespace Presentation
{
  public static class Bootstrapper
  {
    public static void Init()
    {
      DependencyInjector.Register<IBusiness, BusinessClass>();
      DependencyInjector.AddExtension<DependencyOfDependencyExtension>();
    }
  }
}
