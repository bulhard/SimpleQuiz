using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Statistics.Data.Models;
using SimpleQuiz.Statistics.Models.Statistics;
using System.Threading.Tasks;

namespace SimpleQuiz.Statistics.Services.Statistics
{
    public class StatisticsService : DataService<Statistic>, IStatisticsService
    {
        private readonly IMapper mapper;

        public StatisticsService(DbContext db, IMapper mapper) : base(db)
        {
            this.mapper = mapper;
        }

        public async Task AddPerson()
        {
            var statistics = await this.All().SingleOrDefaultAsync();

            statistics.TotalPeople++;

            await this.Data.SaveChangesAsync();
        }

        public async Task AddQuiz()
        {
            var statistics = await this.All().SingleOrDefaultAsync();

            statistics.TotalQuizzes++;

            await this.Data.SaveChangesAsync();
        }

        public async Task<StatisticsOutputModel> Get()
        {
            return await this.mapper
                .ProjectTo<StatisticsOutputModel>(this.All())
                .SingleOrDefaultAsync();
        }
    }
}