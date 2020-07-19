using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleQuiz.Common.Infrastructure;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Statistics.Data;
using SimpleQuiz.Statistics.Messages;
using SimpleQuiz.Statistics.Services.Statistics;

namespace SimpleQuiz.Statistics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
            => this.Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
            => services
                .AddWebService<StatisticsDbContext>(this.Configuration)
                .AddTransient<IDataSeeder, StatisticsDataSeeder>()
                .AddTransient<IStatisticsService, StatisticsService>()
                .AddMassTransit(x =>
                {
                    x.AddConsumer<PersonCreatedConsumer>();

                    x.UsingRabbitMq((context, cfg) =>
                    {
                        cfg.ReceiveEndpoint("event-listener", e =>
                        {
                            e.ConfigureConsumer<PersonCreatedConsumer>(context);
                        });
                    });
                })
                .AddMassTransitHostedService()
                // .AddMessaging(typeof(PersonCreatedConsumer))
                ;

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app
                .UseWebService(env)
                .Initialize();
    }
}