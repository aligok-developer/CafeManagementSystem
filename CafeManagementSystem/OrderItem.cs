using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkodluSatis
{
    public class OrderItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string BarkodDeneme { get; set; }
        public string UrunGrup { get; set; }
        public Nullable<double> AlisFiyat { get; set; }
        public Nullable<double> SatisFiyat { get; set; }
        public Nullable<double> KdvTutari { get; set; }
        public string Birim { get; set; }

        public string GenelToplam { get; set; }
    }

}
