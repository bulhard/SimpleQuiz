using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data;
using SimpleQuiz.Quizzes.Data.Models;
using SimpleQuiz.Quizzes.Models.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Services.People
{
    public class PeopleService : DataService<Person>, IPeopleService
    {
        private readonly IMapper mapper;

        public PeopleService(QuizzesDbContext db, IMapper mapper) : base(db)
        {
            this.mapper = mapper;
        }

        public async Task<Person> FindById(int id)
        {
            return await Data.FindAsync<Person>(id);
        }

        public Task<Person> FindByUser(string userId)
        {
            return this.FindByUser(userId, person => person);
        }

        private async Task<T> FindByUser<T>(string userId, Expression<Func<Person, T>> selector)
        {
            var personData = await this
                .All()
                .Where(u => u.UserId == userId)
                .Select(selector)
                .FirstOrDefaultAsync();

            if (personData == null)
            {
                throw new InvalidOperationException("This user is not a person.");
            }

            return personData;
        }

        public async Task<IEnumerable<PersonDetailsOutputModel>> GetAll()
        {
            return await this.mapper
                .ProjectTo<PersonDetailsOutputModel>(this.All())
                .ToListAsync();
        }

        public async Task<PersonDetailsOutputModel> GetDetails(int id)
        {
            return await this.mapper
                .ProjectTo<PersonDetailsOutputModel>(this
                    .All()
                    .Where(d => d.Id == id))
                .FirstOrDefaultAsync();
        }

        public Task<int> GetIdByUser(string userId)
        {
            return this.FindByUser(userId, person => person.Id);
        }

        public async Task<bool> HasQuizzes(int personId, int quizId)
        {
            return await this
                .All()
                .Where(d => d.Id == personId)
                .AnyAsync(d => d.Quizzes
                    .Any(c => c.Id == quizId));
        }

        public async Task<bool> IsPerson(string userId)
        {
            return await this
                .All()
                .AnyAsync(d => d.UserId == userId);
        }
    }
}