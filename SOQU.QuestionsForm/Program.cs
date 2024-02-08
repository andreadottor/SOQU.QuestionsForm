using SOQU.QuestionsForm.Questions;

var questions = new List<IQuestion>();
var responses = new Dictionary<int, string>();

// TODO: Add questions to the list
var nameQuestion = new TextQuestion();
nameQuestion.Id = 1;
nameQuestion.Text = "inserire il nome";
nameQuestion.IsRequired = true;
questions.Add(nameQuestion);

var emailQuestion = new TextQuestion();
emailQuestion.Id = 2;
emailQuestion.Text = "inserisci l'email";
questions.Add(emailQuestion);

var ageQuestion = new NumericQuestion();
ageQuestion.Id = 3;
ageQuestion.Text = "inserisci l'età";
ageQuestion.IsRequired = false;
questions.Add(ageQuestion);

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
