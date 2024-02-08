

namespace SOQU.QuestionsForm.Questions
{
    internal class TextQuestion : IQuestion
    {
        public int Id { get; set; }

        public string Text { get; set; }
        public string AskQuestion()
        {
            Console.WriteLine(Text);
            string input=Console.ReadLine();
            return input;
        }
    }
}
