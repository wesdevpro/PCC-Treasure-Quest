using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TheTreasureQuest
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder();
        } 

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
        }
    }
}