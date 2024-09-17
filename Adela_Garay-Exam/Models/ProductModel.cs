namespace ExamenMvvm.Models
{
    public class ProductModel
    {
        public decimal Product1 { get; set; }
        public decimal Product2 { get; set; }
        public decimal Product3 { get; set; }

        public decimal Subtotal => Product1 + Product2 + Product3;
        public decimal Discount
        {
            get
            {
                var total = Subtotal;
                if (total >= 10000)
                    return 0.30m;
                if (total >= 5000)
                    return 0.20m;
                if (total >= 1000)
                    return 0.10m;
                return 0.00m;
            }
        }
        public decimal TotalToPay => Subtotal - (Subtotal * Discount);
    }
}
