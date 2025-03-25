using ApplicationCore.Commons.Repository;
using ApplicationCore.Models.QuizAggregate;
using BackendLab01;

namespace WebAPI;
public static class SeedData
{
    // public static void Seed(this WebApplication app)
    // {
    //     using (var scope = app.Services.CreateScope())
    //     {
    //         var provider = scope.ServiceProvider;
    //         var quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
    //         var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();
    //         
    //         List<QuizItem> quizItems = new List<QuizItem>();
    //
    //         quizItems.Add(quizItemRepo.Add(new QuizItem(id: 1, correctAnswer: "6", question: "2 + 4",
    //             incorrectAnswers: new List<string>() {"5", "7", "8"})));
    //         quizItems.Add(quizItemRepo.Add(new QuizItem(id: 2, correctAnswer: "8", question: "2 * 4",
    //             incorrectAnswers: new List<string>() {"4", "6", "9"})));
    //         quizItems.Add(quizItemRepo.Add(new QuizItem(id: 3, correctAnswer: "4", question: "8 / 2",
    //             incorrectAnswers: new List<string>() {"5", "7", "8"})));
    //         quizRepo.Add(new Quiz(id: 1, items: quizItems, title: "Matematyka"));
    //         
    //         List<QuizItem> quizItems1 = new List<QuizItem>();
    //
    //         quizItems1.Add(quizItemRepo.Add(new QuizItem(id: 4, correctAnswer: "Polska", question: "Co to za kraj: Warszawa",
    //             incorrectAnswers: new List<string>() {"Albania", "Rosja", "Czechy"})));
    //         quizItems1.Add(quizItemRepo.Add(new QuizItem(id: 5, correctAnswer: "Malta", question: "Co to za kraj: Valetta",
    //             incorrectAnswers: new List<string>() {"Zanzibar", "Egipt", "Słowacja"})));
    //         quizRepo.Add(new Quiz(id: 2, items: quizItems1, title: "Geografia"));
    //     }
    // }
    public static void Seed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var provider = scope.ServiceProvider;
            var quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
            var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();
            List<QuizItem> quizItems = new List<QuizItem>();
            
            var item1 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 1,
                CorrectAnswer = "5",
                Question = "3 + 2",
                IncorrectAnswers = new List<string>() { "2", "3", "4" }
            });

            var item2 = quizItemRepo?.Add(new QuizItem()
            {
                Id = 2,
                CorrectAnswer = "8",
                Question = "4 * 2",
                IncorrectAnswers = new List<string>() { "10", "6", "4" }
            });

            quizRepo?.Add(new Quiz()
            {
                Id = 1,
                Items = new List<QuizItem>()
                {
                    item1,
                    item2
                }
            });
        }
    }
}