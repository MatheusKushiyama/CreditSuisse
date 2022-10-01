using Domain.Categories.Generic;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Categories
{
    public class MediumRiskCategory : Category
    {
        public MediumRiskCategory(Category otherCategory) : base(otherCategory) {}

        public MediumRiskCategory() : base() { }

        public override TradeModel Classify(TradeModel trade)
        {
            if(trade.Value> 1000000 && trade.ClientSector == "public")
            {
                trade.Category = "MEDIUMRISK";
                return trade;
            }
            return base.NextClassify(trade);

        }
    }
}
