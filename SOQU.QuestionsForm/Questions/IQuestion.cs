namespace SOQU.QuestionsForm.Questions;


interface IQuestion
{
    int Id { get; }
    string Text { get; }
    public bool IsRequired { get; }
    string AskQuestion();
}
