using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NewHashtagManager.Models
{
    public class User
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string userMail { get; set; }
        [JsonIgnore]
        public IEnumerable<Posteo> PostsList { get; set; } = new List<Posteo>();
        public virtual string Password { get; set; }
    }
}