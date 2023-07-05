using System.ComponentModel.DataAnnotations;

namespace DEMO_PROJECT_C2108G3_Delivery.Models
{
	public class Base
	{
		[Key]
        public int Id { get; set; }

        public int? LoaiId { get; set; } = 0;
        public int? TrangThaiId { get; set; } = 0;
        public DateTime? NgayTao { get; set; } = DateTime.Now;
        public string? IdNguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string? IdNguoiSua { get; set; }
        public bool? IsDelete { get; set; } = false;
		public DateTime? NgayXoa { get; set; }
	}
}
