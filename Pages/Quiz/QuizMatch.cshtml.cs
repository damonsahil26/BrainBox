using BrainBox.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace BrainBox.Pages.Quiz
{
    public class QuizMatchModel : PageModel
    {
        public string Category { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public string NoOfQuestions { get; set; } = string.Empty;

        public async Task OnGet(string category, string type, string difficulty, string noOfQuestions)
        {
            Category = category;
            Type = type;
            Difficulty = difficulty;
            NoOfQuestions = noOfQuestions;

            HttpClient httpClient = new HttpClient();
            var quizUri = GetQuizUrl(category, type, difficulty, noOfQuestions);
            var response = await httpClient.GetAsync(quizUri);

            if (response != null && response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var quizResponse = JsonSerializer.Deserialize<QuizResponseDto>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = false });
                if (quizResponse.ResponseCode != 0)
                {
                    response = await httpClient.GetAsync($"https://opentdb.com/api.php?amount={noOfQuestions}&category={category}");
                    if (response != null && response.IsSuccessStatusCode)
                    {
                        jsonString = await response.Content.ReadAsStringAsync();
                        quizResponse = JsonSerializer.Deserialize<QuizResponseDto>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = false });
                    }
                }

                if (quizResponse != null)
                {
                    Console.WriteLine($"Response Code: {quizResponse.ResponseCode}");

                    foreach (var question in quizResponse.Results)
                    {
                        Console.WriteLine($"Category: {question.Category}");
                        Console.WriteLine($"Question: {question.Description}");
                        Console.WriteLine($"Correct Answer: {question.CorrectAnswer}");
                        Console.WriteLine($"Incorrect Answers: {string.Join(", ", question.IncorrectAnswers)}");
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Failed to fetch data.");
            }
        }

        private string GetQuizUrl(string category, string type, string difficulty, string noOfQuestions)
        {
            var baseUrl = $"https://opentdb.com/api.php?amount={noOfQuestions}";
            if(category.ToLower().Trim() != "any")
            {
                baseUrl += $"&category={category}";
            }

            if (difficulty.ToLower().Trim() != "any")
            {
                baseUrl += $"&difficulty={difficulty}";
            }

            if (type.ToLower().Trim() != "any")
            {
                baseUrl += $"&type={type}";
            }

            return baseUrl ;
        }
    }
}
