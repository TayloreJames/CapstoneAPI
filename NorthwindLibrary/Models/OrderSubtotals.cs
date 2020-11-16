using System;
using System.Collections.Generic;

namespace NorthwindLibrary.Models
{
    public partial class OrderSubtotals
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
