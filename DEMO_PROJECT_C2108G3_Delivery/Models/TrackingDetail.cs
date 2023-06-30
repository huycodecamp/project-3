using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO_PROJECT_C2108G3_Delivery.Models
{
	public class TrackingDetail : Base
	{
        public int? TrackingId { get; set; }
        public int? Postal_From { get; set; }
        public int? Postal_To { get; set; }
        public int? Sort { get; set; }
        public decimal? Fee { get; set; }

        //[ForeignKey("TrackingId")]
        //public Tracking GetTracking { get; set; }
    }
}
