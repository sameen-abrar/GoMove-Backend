using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoMove.Repositories.Entites
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public String OrganizationName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public int? TradeLicenseNumber { get; set; }
        public float? MonthlyEstimatedRevenue { get; set; }
    }
}
