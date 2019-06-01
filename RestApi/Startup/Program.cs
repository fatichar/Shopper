using Shopper.Core;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Shopper.RestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>().Build();

            new FirmContext().Database.EnsureCreated();
        }
    }
}
