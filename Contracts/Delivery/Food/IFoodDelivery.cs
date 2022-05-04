using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    
    public interface IFoodDelivery
    {       
        Task<List<string>> GetMenu(); 
        enum Menu { }
    }
    
    public enum FoodDeliveryType
    {
        COFFEE,
        LUNCH,
        DINNER
    }
}
