﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace csharp_http_simplified.Models.JsonPlaceholder.ReadModels
{
    public class GetTodos
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{UserId}, {Id}, {Title}, {Completed}";
        }
    }
}