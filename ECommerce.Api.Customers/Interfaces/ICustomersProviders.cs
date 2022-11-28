using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Customers.Interfaces
{
    public interface ICustomersProviders
    {
        Task<(bool isSuccess, IEnumerable<Models.Customer> Customers, string ErrorMessage)> GetCustomersAsync();
        Task<(bool isSuccess, Models.Customer Customer, string ErrorMessage)> GetCustomerAsync(int id);
    }
}
