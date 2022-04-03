using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;
        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if(request.UserId == 1)
            {
                output.FirstName = "Syed";
                output.LastName = "Shamail";
                output.IsAlive = true;
            }
            else if(request.UserId == 2)
            {
                output.FirstName = "Akber";
                output.LastName = "Khan";
                output.IsAlive = false;
            }
            else
            {
                output.FirstName = "Umer";
                output.LastName = "Mushtaq";
                output.IsAlive = false;
            }

            return Task.FromResult(output);
        }
    }
}
