using Data;
using Unity;
using Unity.Extension;

namespace Business
{
  public class DependencyOfDependencyExtension : UnityContainerExtension
  {
    protected override void Initialize()
    {
      Container.RegisterType<IData,DataClass>();
    }
  }
}
