using Domain.Categories.Generic;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Categories
{
    public class ExpiredCategory : Category
    {
        public ExpiredCategory(Category otherCategory) : base(otherCategory) { }
        public ExpiredCategory() : base() { }

        public override TradeModel Classify(TradeModel trade)
        {
            var dataDiference = trade.NextPaymentDate.Subtract(DateTime.Now).TotalDays;

            if (dataDiference < -30)
            {
                trade.Category = "EXPIRED";
                return trade;
            }
            return base.NextClassify(trade);
        }
    }
}
