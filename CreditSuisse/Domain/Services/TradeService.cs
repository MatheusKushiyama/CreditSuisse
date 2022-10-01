using Domain.Categories;
using Domain.Categories.Generic;
using Domain.InterfaceService;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class TradeService : ITradeService
    {
        public List<TradeModel> Classify(List<TradeModel> listTradeModels)
        {
            Category catedories = ListCategories.GetListCategories();

            var listTradeToReturn = new List<TradeModel>();

            foreach(var trade in listTradeModels)
            {
                listTradeToReturn.Add(catedories.Classify(trade));
            }
            return listTradeToReturn;
        }
    }
}
