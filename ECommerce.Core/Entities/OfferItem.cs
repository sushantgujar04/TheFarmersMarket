using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class OfferItem : BaseEntity
    {
        public Offer Offer { get; set; }
        public int OfferId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
