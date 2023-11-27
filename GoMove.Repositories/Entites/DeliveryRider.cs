using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoMove.Repositories.Entites
{
    public partial class DeliveryRider
    {
        public int RiderId { get; set; }
        public String RiderName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public int? NationalId { get; set; }
        public List<String> DeliveryRegions { get; set; }
    }
}
