using Spectre.Console;

namespace SOQU.QuestionsForm.Questions;

public class NumericQuestion : IQuestion
{
    public int Id { get; set; }
    public string Text { get; set; }
    public string AskQuestion()
    {
        var response = AnsiConsole.Ask<int>(Text);
        return response.ToString();
    }
}