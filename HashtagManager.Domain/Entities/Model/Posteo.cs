using System;
using System.Text.Json.Serialization;

namespace NewHashtagManager.Domain.Entities.Models
{
    public class Posteo
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public DateTime DatePost { get; set; } = DateTime.Now;
        public string TextPost { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}