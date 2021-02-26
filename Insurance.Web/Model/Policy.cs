using System;

namespace Insurance.Web.Model
{
    public class Policy
    {
        public Guid Number { get; set; }
        public DateTime BeginningValidity { get; set; }
        public DateTime EndValidity { get; set; }
        public int Term { get; set; }
        public double NetBonus { get; set; }
        public double TotalBonus { get; set; }
        public Guid VendorId { get; set; }
        public double VendorCommision { get; set; }
        public string Observations { get; set; }
    }
}
