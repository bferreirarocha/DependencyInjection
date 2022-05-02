using OfficeService.Contracts;
using OfficeService.Implementaton;
using System.Threading.Tasks;

namespace Translator.Abstraction
{
    public class ServiceManager: IServiceManager
    {
        public Lawyer _lawyer;
        public AbstractServicesFactory _factory;
        public IDelivery delivery;
        public ITranslator translator;
        public ServiceManager(ILawyer _lawyer)
        {
            _factory = new AbstractServicesFactory();    
        }
        public Task Translate(Languages language, string text, ILawyer lawyer)
        {    // To be implemented
            return Task.CompletedTask;  
        }
        public Task OrderCoffee(DeliveryType order, ILawyer lawyer) 
        {  // To be implemented
            return Task.CompletedTask;
        }

    }
}
