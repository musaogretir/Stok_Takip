using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    internal class category
    {
        public string categoryName { get; set; }
        public category[] subCategories { get; set; }

        public category(string name, category[] subCats)
        {
            this.categoryName = name;
            this.subCategories = subCats;
        }
    }
}
