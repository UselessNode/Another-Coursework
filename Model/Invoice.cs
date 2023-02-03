using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxix.Model
{
    internal class Invoice
    {
        public int Id { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        public Supplier SuplierId { get; set; }
        public Product ProductId { get; set; }

        public double Volume { get; set; }
        public double Price { get; set; }
    }
}