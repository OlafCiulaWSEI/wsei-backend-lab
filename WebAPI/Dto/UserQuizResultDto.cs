namespace WebAPI.Dto;

public class UserQuizResultDto
{
    public int UserId { get; set; }
    public int QuizId { get; set; }
    public int CorrectAnswersCount { get; set; }
}
