namespace AppLoadData.Model
{
    public  class GuiaSap
    {
		public int DeliverySapId { get; set; }
		public int UserId { get; set; }
		public long DeliveryId { get; set; }
		public string Position { get; set; }
		public string Material { get; set; }
		public string Warehouse { get; set; }
		public string Batch { get; set; }
		public int Quantity { get; set; }
		public string MaterialDesc { get; set; }
		public string DeliveryDate { get; set; }
		public decimal Price { get; set; }
		public string DeliveryOrder { get; set; }
		public int NewQuantity { get; set; }
		public string Comment { get; set; }
		public string UserRegister { get; set; }
		public string DateRegister { get; set; }
	}
}
