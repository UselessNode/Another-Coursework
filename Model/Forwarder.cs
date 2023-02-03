using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxix.Model
{
    internal class Forwarder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Supplier SupplyCompanyId { get; set; }
    }
}
