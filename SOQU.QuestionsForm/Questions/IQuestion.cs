namespace SOQU.QuestionsForm.Questions;


interface IQuestion
{
    int Id { get; }
    string Text { get; }
    bool IsRequired { get; }
    string AskQuestion();
}
