﻿using ApplicationCore.Models.QuizAggregate;
namespace ApplicationCore.Interfaces.AdminService;

public interface IQuizAdminService
{
    public QuizItem AddQuizItem(string question, List<string> incorrectAnswers, string correctAnswer, int points);
    public void UpdateQuizItem(int id, string question, List<string> incorrectAnswers, string correctAnswer, int points);
    public Quiz AddQuiz(string title, List<QuizItem> items);
    public Quiz AddQuiz(Quiz quiz);
    public bool DeleteQuiz(int id);
    public List<QuizItem> FindAllQuizItems();
    public List<Quiz> FindAllQuizzes();
    public QuizItem AddQuizItemToQuiz(int quizId, QuizItem item);
    Quiz UpdateQuiz(int quizId, Quiz updatedQuiz);
    
}