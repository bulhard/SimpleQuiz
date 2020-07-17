using AutoMapper;
using SimpleQuiz.Common.Models;
using SimpleQuiz.Quizzes.Data.Models;
using System.Linq;

namespace SimpleQuiz.Quizzes.Models.Quizzes
{
    public class QuizOutputModel : IMapFrom<Quiz>
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int TotalQuestionsCount { get; set; }

        public void Mapping(Profile profile)
            => profile
                .CreateMap<Quiz, QuizOutputModel>()
                .ForMember(c => c.TotalQuestionsCount, cfg => cfg
                    .MapFrom(c => c.Questions.Count()));
    }
}