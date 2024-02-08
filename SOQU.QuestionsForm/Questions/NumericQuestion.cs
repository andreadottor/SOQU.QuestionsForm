using Spectre.Console;

namespace SOQU.QuestionsForm.Questions;

public class NumericQuestion : IQuestion
{
    public int Id { get; set; }
    public string Text { get; set; }

    public bool IsRequired { get; set; }


    public string AskQuestion()
    {
        Console.WriteLine(Text);
        string? input = Console.ReadLine();

        while ((IsRequired && (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out _))) ||
              (!IsRequired && !string.IsNullOrWhiteSpace(input) && !int.TryParse(input, out _)))
        {
            Console.WriteLine("Risposta obbligatoria o formato errato");
            input = Console.ReadLine();
        }
        return input ?? string.Empty;
        
    }
}