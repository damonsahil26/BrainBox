using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BrainBox.Models
{
    public class Question
    {
        [JsonPropertyName("category")]
        public string Category { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("difficulty")]
        public string Difficulty { get; set; } = string.Empty;

        // Fix: Map the "question" field to Description in your C# model
        [JsonPropertyName("question")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("correct_answer")]
        public string CorrectAnswer { get; set; } = string.Empty;

        [JsonPropertyName("incorrect_answers")]
        public string[] IncorrectAnswers { get; set; } = { };
    }
}
