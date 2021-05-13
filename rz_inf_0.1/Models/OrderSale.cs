namespace rz_inf_0._1.Models {
    class OrderSale {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOrder { get; set; }
        public bool RequirePayment { get; set; }
        public double AmountTotal { get; set; }
        public double AmountUntaxed { get; set; }
    }
}
