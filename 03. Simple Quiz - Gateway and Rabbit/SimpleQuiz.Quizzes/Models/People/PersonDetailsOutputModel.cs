using AutoMapper;
using SimpleQuiz.Quizzes.Data.Models;
using System.Linq;

namespace SimpleQuiz.Quizzes.Models.People
{
    public class PersonDetailsOutputModel : PersonOutputModel
    {
        public int TotalQuizzes { get; set; }

        public void Mapping(Profile mapper)
            => mapper
                .CreateMap<Person, PersonDetailsOutputModel>()
                .IncludeBase<Person, PersonOutputModel>()
                .ForMember(d => d.TotalQuizzes, cfg => cfg
                    .MapFrom(d => d.Quizzes.Count()));
    }
}