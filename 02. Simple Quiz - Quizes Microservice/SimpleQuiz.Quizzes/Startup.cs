using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleQuiz.Common.Infrastructure;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data;
using SimpleQuiz.Quizzes.Services.People;
using SimpleQuiz.Quizzes.Services.Quizzes;

namespace SimpleQuiz.Quizzes
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddWebService<QuizzesDbContext>(this.Configuration)
                .AddTransient<IDataSeeder, QuizzesDataSeeder>()
                .AddTransient<IQuizzesService, QuizzesService>()
                .AddTransient<IPeopleService, PeopleService>()
                //.AddTransient<ICarAdService, CarAdService>()
                //.AddTransient<IManufacturerService, ManufacturerService>()
                .AddMessaging();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app
                .UseWebService(env)
                .Initialize();
    }
}