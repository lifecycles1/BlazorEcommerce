namespace BlazorEcommerce.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder(int userId);
        Task<ServiceResponse<List<OrderOverviewResponseDto>>> GetOrders();
        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);
    }
}
