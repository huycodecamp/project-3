﻿namespace DEMO_PROJECT_C2108G3_Delivery.DataTransferObject
{
	public class DataTableReposneDTO<T> where T : class
	{
		public int draw { get; set; } = 0;
		public int recordsTotal { get; set; } = 0;
		public int recordsFiltered { get; set; } = 0;
		public List<T> data { get; set; } = new List<T>();
	}
}
