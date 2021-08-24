using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_http_simplified.Models.JsonPlaceholder.ReadModels
{
    public class GetUsers
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public GetUsersAddress Address { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("website")]
        public string Website { get; set; }

        [JsonPropertyName("company")]
        public GetUsersCompany Company { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}; Name: {Name}; Username: {Username}; Address.Geo.Lat: {Address.Geo.Lat}; Company.Bs: {Company.Bs}\n";
        }
    }
}