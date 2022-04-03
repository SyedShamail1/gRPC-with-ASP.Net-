using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region GreeterService
            //A Hello request
            //var input = new HelloRequest
            //{
            //    Name = "Shamail"
            //};

            ////Setting up channel
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");

            ////Creating a client
            //var client = new Greeter.GreeterClient(channel);

            ////Getting a reply
            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            //var input = new HelloRequest
            //{
            //Name = "Shamail"
            //};
            #endregion

            #region Customer Service

            var input = new CustomerLookupModel
            {
                UserId = 1
            };

            //Setting up channel
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            //Creating a client
            var client = new Customer.CustomerClient(channel);

            //Getting a reply
            var reply = await client.GetCustomerInfoAsync(input);

            Console.WriteLine(reply.FirstName + " " + reply.LastName);

            #endregion

            Console.ReadLine();


        }
    }
}
