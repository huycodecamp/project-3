namespace DEMO_PROJECT_C2108G3_Delivery.DataTransferObject
{
	public class ViewDTO<T> where T : class
	{
        public int StatusCode { get; set; } = 500;
        public string Message { get; set; } = "Khong thanh cong!";
        public List<T> Data { get; set; } = new List<T>();
    }
}
