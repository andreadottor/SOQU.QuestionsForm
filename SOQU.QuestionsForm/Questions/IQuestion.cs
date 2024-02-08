namespace SOQU.QuestionsForm.Questions;


interface IQuestion
{
    int Id { get; }
    string Text { get; }
    string AskQuestion();
}
