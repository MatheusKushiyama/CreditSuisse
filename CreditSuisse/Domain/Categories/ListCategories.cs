using Domain.Categories.Generic;
using System.Collections.Generic;

namespace Domain.Categories
{
    public static class ListCategories
    {
        public static Category GetListCategories ()
        {
            Category categories = 
                new PEP(
                new ExpiredCategory(
                new HighriskCategory(
                new MediumRiskCategory(
                            ))));
            return categories;
        }
        
    }
}
