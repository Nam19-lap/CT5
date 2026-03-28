namespace WebBanHang_HoaiNam.Models
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddItem(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void RemoveItem(int productId)
        {
            Items.RemoveAll(i => i.ProductId == productId);
        }

        // ✅ Tổng số lượng sản phẩm
        public int TotalQuantity()
        {
            return Items.Sum(i => i.Quantity);
        }

        // ✅ Tổng tiền giỏ hàng
        public decimal TotalPrice()
        {
            return Items.Sum(i => i.Price * i.Quantity);
        }

        // ✅ Xóa toàn bộ giỏ hàng
        public void Clear()
        {
            Items.Clear();
        }
    }

}
