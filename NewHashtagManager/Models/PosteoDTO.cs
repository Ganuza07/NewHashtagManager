using System;
using System.Text.Json.Serialization;

namespace NewHashtagManager.Models
{
    public class PosteoDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public DateTime DatePost { get; set; } = DateTime.Now;
        public string TextPost { get; set; }
        //[JsonIgnore]
        //public virtual UserDTO User { get; set; }
    }
}