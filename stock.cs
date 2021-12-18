using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    internal class stock
    {
        public category stockCategory { get; set; }
        public string stockName { get; set;}
        public string stockBrand { get; set;}
        public int stockAmount { get; set;}
        public DateTime stockDate { get; set;}

        public stock(category c, string sName, string sBrand, string sBarcode, int sAmount, DateTime d)
        {
            stockCategory = c;
            stockName = sName;
            stockBrand = sBrand;
            stockAmount = sAmount;
            stockDate = d;
        }



    }
}
