using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BrainBox.Models.Dtos
{
    public class QuizResponseDto
    {
        [JsonPropertyName("response_code")]
        public int ResponseCode { get; set; }

        // Fix: Use lowercase "results" to match the JSON field
        [JsonPropertyName("results")]
        public Question[] Results { get; set; }
    }
}
