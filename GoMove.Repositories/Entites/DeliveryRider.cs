using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoMove.Repositories.Entites.Models
{
    public partial class DeliveryRider
    {
        public int RiderId { get; set; }
        public string RiderName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? NationalId { get; set; }
        public List<string> DeliveryRegions { get; set; }
    }
}
