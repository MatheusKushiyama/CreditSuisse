using Domain.Model;
using System.Collections.Generic;

namespace Domain.Categories.Generic
{
    public abstract class Category
    {
        public Category OtherCategory { get; set; }

        public Category(Category otherCategory)
        {
            this.OtherCategory = otherCategory;
        }
        public Category()
        {
            this.OtherCategory = null;
        }
        public abstract TradeModel Classify(TradeModel trade);

        protected TradeModel NextClassify(TradeModel trade)
        {            
            if (OtherCategory == null)
            {
                trade.Category = "WITHOUT CLASSIFICATION";
                return trade;
            }                 
            return OtherCategory.Classify(trade);
        }
    }
}
