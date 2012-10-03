using NServiceBus;
using NServiceBus.Config;

namespace Subscriber2
{
    public class EndpointConfiguration : IConfigureThisEndpoint, AsA_Worker, IWantCustomInitialization
    {
        public void Init()
        {
            Configure.With()
               .Log4Net()
               .DefaultBuilder()
               .AzureConfigurationSource()
               .AzureMessageQueue()
               .JsonSerializer()
               //.DBSubcriptionStorage()
               .Sagas()
                   .NHibernateSagaPersister()
                   .NHibernateUnitOfWork()
               .UnicastBus()
                   .LoadMessageHandlers()
                   .IsTransactional(true)
               .CreateBus()
               .Start();
        }
    }
}