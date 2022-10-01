using Domain.Categories.Generic;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Categories
{
    public class PEP : Category
    {
        public PEP(Category otherCategory) : base(otherCategory) { }
        public PEP() : base() { }

        public override TradeModel Classify(TradeModel trade)
        {
            if (trade.IsPoliticallyExposed)
            {
                trade.Category = "PEP";
                return trade;
            }
            return base.NextClassify(trade);
        }
    }
}
