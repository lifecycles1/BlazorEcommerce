namespace BlazorEcommerce.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<string> PlaceOrder();
        Task<List<OrderOverviewResponseDto>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
