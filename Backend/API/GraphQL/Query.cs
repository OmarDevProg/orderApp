using Core.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;



namespace API.GraphQL
{
    public class Query
    {
        [UseFiltering]
        public IQueryable<Customer> GetCustomers([Service] ICustomerService CustomerService)
        {
            return CustomerService.GetCustomersAndOrders();

        }

        [UseFiltering]
        public IQueryable<Order> GetOrders([Service] IOrderService OrderService)
        {

            return OrderService.GetOrders();
        }


    }
}