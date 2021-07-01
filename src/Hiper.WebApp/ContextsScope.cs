using Hiper.SharedKernel.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hiper.WebApp
{
    public partial class Startup
    {
        public void AddContexts()
        {
            _ = _services.AddDbContext<CommonContext>(options => options.UseSqlite(Configuration.GetConnectionString("SandBox")));
            _ = _services.AddDbContext<ProductContext>(options => options.UseSqlite(Configuration.GetConnectionString("SandBox")));
            _ = _services.AddDbContext<OrderContext>(options => options.UseSqlite(Configuration.GetConnectionString("SandBox")));
        }
    }
}
