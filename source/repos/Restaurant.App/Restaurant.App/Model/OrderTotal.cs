namespace Restaurant.App
{
    public class OrderTotal
    {
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Total { get; set; }

        public OrderTotal(float price, int quantity)
        {
            Total = price * quantity;
        }

    }
}
