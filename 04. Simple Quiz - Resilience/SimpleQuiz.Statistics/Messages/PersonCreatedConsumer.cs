using MassTransit;
using SimpleQuiz.Common.Messages.Quizzes;
using SimpleQuiz.Statistics.Services.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Statistics.Messages
{
    public class PersonCreatedConsumer : IConsumer<PersonCreatedMessage>
    {
        private readonly IStatisticsService statistics;

        public PersonCreatedConsumer(IStatisticsService statistics)
            => this.statistics = statistics;

        public async Task Consume(ConsumeContext<PersonCreatedMessage> context)
        {
            var message = context.Message;
            await this.statistics.AddPerson();
        }
    }
}