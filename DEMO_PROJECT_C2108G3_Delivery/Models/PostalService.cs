namespace DEMO_PROJECT_C2108G3_Delivery.Models
{
	public class PostalService : Base
	{
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Country { get; set; } = "";
        public decimal? Latitude { get; set; } = 0;
        public decimal? Longtitude { get; set; } = 0;

    }
}
