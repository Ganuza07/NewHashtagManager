using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NewHashtagManager.Models
{
    public class UserDTO
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string userMail { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<PosteoDTO> PostsList { get; set; } = new List<PosteoDTO>();
    }
}