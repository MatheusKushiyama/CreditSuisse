using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.InterfaceService
{
    public interface ITradeService
    {
        List<TradeModel> Classify(List<TradeModel> listTradeModels);
    }
}
