public class Question{
    public int Id { get; set; } 
    public string Title { get; set; }

    public List<Answer>? Answers { get; set; } 


    private Question(string title)
    {
     //Id = id;
     Title = title;   
    }

    public static Question Create(string text){
        return new Question(text);
    }
    public void AddAnswer(string text, bool isCorrect){
        Answers.Add(Answer.Create(text, isCorrect, this.Id));
    }

}