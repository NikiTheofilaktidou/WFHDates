using Newtonsoft.Json;
using System.Data;

namespace WFH.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "userId")]
        public long UserId { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string? FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string? LastName { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }

        public User()
        {
        }

        public User(DataRow row)
        {
            UserId = (long)row["UserID"];
            FirstName = row["FirstName"] != DBNull.Value? row["FirstName"].ToString(): string.Empty;
            LastName = row["FirstName"] != DBNull.Value? row["LastName"].ToString(): string.Empty;
            Country = row["Country"] != DBNull.Value? row["Country"].ToString(): string.Empty;
        }
    }
}
