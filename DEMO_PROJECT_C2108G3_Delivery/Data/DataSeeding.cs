using DEMO_PROJECT_C2108G3_Delivery.Models;

namespace DEMO_PROJECT_C2108G3_Delivery.Data
{
	public static class DataSeeding
	{
		
		public static void SeedingPostalService(ApplicationDbContext _context)
		{
			
			if(_context.PostalServices.Count() <= 0)
			{
				var postalServices = new List<PostalService>
			{
				new PostalService
				{
					City = "Hanoi",
					State = "Hanoi",
					Country = "Vietnam",
					Latitude = 21.0285m,
					Longtitude = 105.8542m
				},
				new PostalService
				{
					City = "Ho Chi Minh City",
					State = "Ho Chi Minh",
					Country = "Vietnam",
					Latitude = 10.8231m,
					Longtitude = 106.6297m
				},
				new PostalService
				{
					City = "Da Nang",
					State = "Da Nang",
					Country = "Vietnam",
					Latitude = 16.0544m,
					Longtitude = 108.2022m
				},
				new PostalService
				{
					City = "Hai Phong",
					State = "Hai Phong",
					Country = "Vietnam",
					Latitude = 20.8449m,
					Longtitude = 106.6881m
				},
				new PostalService
				{
					City = "Can Tho",
					State = "Can Tho",
					Country = "Vietnam",
					Latitude = 10.0458m,
					Longtitude = 105.7469m
				},
				new PostalService
				{
					City = "Nha Trang",
					State = "Khanh Hoa",
					Country = "Vietnam",
					Latitude = 12.2388m,
					Longtitude = 109.1967m
				},
				new PostalService
				{
					City = "Da Lat",
					State = "Lam Dong",
					Country = "Vietnam",
					Latitude = 11.9404m,
					Longtitude = 108.4587m
				},
				new PostalService
				{
					City = "Hue",
					State = "Thua Thien Hue",
					Country = "Vietnam",
					Latitude = 16.4637m,
					Longtitude = 107.5909m
				},
				new PostalService
				{
					City = "Vung Tau",
					State = "Ba Ria - Vung Tau",
					Country = "Vietnam",
					Latitude = 10.3459m,
					Longtitude = 107.0842m
				},
				new PostalService
				{
					City = "Phu Quoc",
					State = "Kien Giang",
					Country = "Vietnam",
					Latitude = 10.2270m,
					Longtitude = 103.9637m
				}
			};

				_context.PostalServices.AddRange(postalServices);
				_context.SaveChanges();
			}
			

		}
	}
}
