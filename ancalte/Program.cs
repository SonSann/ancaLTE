using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ancalte
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                //可添加多个监听地址如 .UseUrls("http://localhost:8000", "http://localhost:9000")；5000默认端口
                .UseUrls("http://localhost:8000")
                .UseApplicationInsights()
                .Build();
            host.Run();
        }
    }
}
