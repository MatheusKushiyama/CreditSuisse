using Domain.Categories.Generic;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Categories
{
    public class HighriskCategory : Category
    {
        public HighriskCategory(Category otherCategory) : base(otherCategory) { }
        public HighriskCategory() : base() { }
        public override TradeModel Classify(TradeModel trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector == "private")
            {
                trade.Category = "HIGHRISK";
                return trade;
            }
            return base.NextClassify(trade);
        }
    }
}
