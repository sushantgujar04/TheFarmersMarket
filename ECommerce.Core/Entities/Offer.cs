using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Entities
{
    public class Offer : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Limit { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime StartDate { get; set; } = DateTime.UtcNow;
        public DateTime EndDate { get; set; }
        public List<OfferItem> OfferItems { get; set; }
        public int MinimumQty { get; set; }
    }
}
