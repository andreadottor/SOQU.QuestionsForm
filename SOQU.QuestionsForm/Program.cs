using SOQU.QuestionsForm.Questions;

var questions = new List<IQuestion>();
var responses = new Dictionary<int, string>();

// TODO: Add questions to the list



Console.WriteLine("START");
foreach (var question in questions)
{
    var response = question.AskQuestion();
    responses.Add(question.Id, response);
}
Console.WriteLine("END");

foreach (var item in responses)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
Console.ReadLine();
