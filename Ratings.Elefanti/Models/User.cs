using System.Text.Json.Serialization;

namespace Ratings.Elefanti.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
    }
}
