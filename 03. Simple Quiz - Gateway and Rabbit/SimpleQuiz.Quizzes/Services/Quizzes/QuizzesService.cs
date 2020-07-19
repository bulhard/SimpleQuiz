using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data;
using SimpleQuiz.Quizzes.Data.Models;
using SimpleQuiz.Quizzes.Models.Quizzes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleQuiz.Quizzes.Services.Quizzes
{
    public class QuizzesService : DataService<Quiz>, IQuizzesService
    {
        private readonly IMapper mapper;

        public QuizzesService(QuizzesDbContext db, IMapper mapper) : base(db)
        {
            this.mapper = mapper;
        }

        public async Task<Quiz> Find(int quizId)
        {
            return await Data.FindAsync<Quiz>(quizId);
        }

        public async Task<IEnumerable<QuizOutputModel>> GetAll()
        {
            try
            {
                var quizzes = this.All();

                var result = await mapper.ProjectTo<QuizOutputModel>(quizzes).ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                var s = ex.Message;
                return null;
            }
        }
    }
}