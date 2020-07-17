using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleQuiz.Common.Infrastructure;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Identity.Data;
using SimpleQuiz.Identity.Infrastructure;
using SimpleQuiz.Identity.Services.Identity;

namespace SimpleQuiz.Identity
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddWebService<IdentityDbContext>(this.Configuration)
                .AddUserStorage()
                .AddTransient<IDataSeeder, IdentityDataSeeder>()
                .AddTransient<IIdentityService, IdentityService>()
                .AddTransient<ITokenGeneratorService, TokenGeneratorService>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app
                .UseWebService(env)
                .Initialize();
    }
}