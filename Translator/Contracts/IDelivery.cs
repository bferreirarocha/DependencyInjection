using System;
using System.Threading.Tasks;

namespace Translator.Contracts
{
    public interface IDelivery
    {
        Task<DateTime> OrderCoffe(Action<string> alert);
        DateTime OrderLunch();
        DateTime OrderDinner();

    }
}
