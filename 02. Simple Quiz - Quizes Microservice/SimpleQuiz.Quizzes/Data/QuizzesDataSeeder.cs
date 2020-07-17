using SimpleQuiz.Common.Services;
using SimpleQuiz.Quizzes.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleQuiz.Quizzes.Data
{
    public class QuizzesDataSeeder : IDataSeeder
    {
        private static IEnumerable<Quiz> GetData()
            => new List<Quiz>
            {
                new Quiz{
                    Title = "Sharks",
                    Description = "Sink your teeth into this quiz all about sharks." ,
                    Questions = new List<Question>
                    {
                        new Question {
                            Title = "Which is the largest of all sharks",
                            Answers = new List<Answer>
                            {
                                new Answer { Text = "Great while shark", Points= 0 },
                                new Answer { Text = "While shark", Points = 1 },
                                new Answer { Text = "Tiger shark", Points = 0 }
                            },
                            Text = ""
                        },
                        new Question {
                            Title = "Shark have existed for approximately how long?",
                            Answers = new List<Answer>
                            {
                                new Answer { Text = "350 million years", Points=1 },
                                new Answer { Text = "10 000 years", Points = 0 },
                                new Answer { Text = "1 million years", Points = 0 }
                            },
                            Text = ""
                        }
                    }
                },
                new Quiz{
                    Title = "Cats",
                    Description = "Poor pet pooches. Pet cats outnumber them in the United States! Prove you’re the meow-ster of cat trivia with this quiz about these fluffy but mysterious animals." ,
                    Questions = new List<Question>
                    {
                        new Question {
                            Title = "How many whiskers does the average cat have on each side of its face?",
                            Answers = new List<Answer>
                            {
                                new Answer { Text = "1", Points= 0 },
                                new Answer { Text = "4", Points = 1 },
                                new Answer { Text = "12", Points = 0 }
                            },
                            Text = ""
                        },
                        new Question {
                            Title = "The average can can spend two-thirds of its life sleeping?",
                            Answers = new List<Answer>
                            {
                                new Answer { Text = "True", Points=1 },
                                new Answer { Text = "False", Points = 0 }
                            },
                            Text = ""
                        }
                    }
                }};

        private readonly QuizzesDbContext db;

        public QuizzesDataSeeder(QuizzesDbContext db) => this.db = db;

        public void SeedData()
        {
            if (this.db.Quizzes.Any())
            {
                return;
            }

            foreach (var quiz in GetData())
            {
                this.db.Quizzes.Add(quiz);
            }

            this.db.SaveChanges();
        }
    }
}