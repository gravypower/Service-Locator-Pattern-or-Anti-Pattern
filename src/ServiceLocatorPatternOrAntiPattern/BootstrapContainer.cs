using Chips.DependencyInjection;
using SimpleInjector;

namespace ServiceLocatorPatternOrAntiPattern
{
    public class BootstrapContainer : IBootstrap<Container>
    {
        public void Bootstrap(Container container)
        {
            container.Register<ILogAdaptor, SitecoreLogAdaptor>();
        }
    }
}
