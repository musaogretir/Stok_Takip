using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    public class category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int parentId { get; set; }
        public List<category> childCategories { get; set; }
        public int stockAmount { get; set; }

        public category(int CategoryId, string CategoryName, int ParentId, List<category> ChildCategories, int StockAmount)
        {
            categoryId = CategoryId;
            categoryName = CategoryName;
            parentId = ParentId;
            childCategories = ChildCategories;
            stockAmount = StockAmount;
        }

        public int getParentID() => parentId;

        /*
        public List<category> getChildCategories()
        {
            List<category> resultingCategories = new List<category>();

            foreach (category c in this.childCategories)
            {
                    category childCategory = new category(c.categoryId, c.categoryName, c.parentId, new List<category>());
                    resultingCategories.Add(childCategory);
            }         
            
            return resultingCategories;
        }
        */
    }
}
