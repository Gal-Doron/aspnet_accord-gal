using System.Collections.Generic;
using Newtonsoft.Json;

namespace RealWorld.Domain
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        [JsonIgnore]
        public List<Article> Favorites { get; set; }

        [JsonIgnore]
        public List<Person> Following { get; set; }

        [JsonIgnore]
        public byte[] Hash { get; set; }

        [JsonIgnore]
        public byte[] Salt { get; set; }
    }
}