public class Answer{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; }

    private Answer(string text, bool isCorrect, int questionId)
    {
        //Id = id;
        Text = text;
        IsCorrect = isCorrect;
        QuestionId = questionId;
    }

    public static Answer Create(string text, bool isCorrect, int questionId)
    {
        return new Answer(text, isCorrect, questionId);
    }
}