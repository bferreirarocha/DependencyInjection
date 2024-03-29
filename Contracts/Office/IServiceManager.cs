﻿using OfficeService.Contracts;

using System.Threading.Tasks;

namespace Translator.Abstraction
{
    public interface IServiceManager
    {
        public Task Translate(Languages language, string text, ILawyer lawyer);
        public Task Order(FoodDeliveryType order, ILawyer lawyer);
    }
}