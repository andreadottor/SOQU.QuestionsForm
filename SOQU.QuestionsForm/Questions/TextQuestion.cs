

namespace SOQU.QuestionsForm.Questions
{
    internal class TextQuestion : IQuestion
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public bool IsRequired { get; set; }

        public string AskQuestion()
        {
            Console.WriteLine(Text);
            string? input=Console.ReadLine();
            while(IsRequired && string.IsNullOrWhiteSpace(input)) 
            {
                Console.WriteLine("Risposta obbligatoria");
                input = Console.ReadLine();
            }
            return input ?? string.Empty;
        }
    }
}
