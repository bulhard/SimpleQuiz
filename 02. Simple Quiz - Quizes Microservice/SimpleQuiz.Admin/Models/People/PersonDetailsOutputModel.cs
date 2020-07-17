namespace SimpleQuiz.Admin.Models.People
{
    public class PersonDetailsOutputModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TotalQuizzes { get; set; }
    }
}