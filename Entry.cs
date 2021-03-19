using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Journaling
{
    public class Entry
    {
        // Dictionary
        Dictionary<DateTime, Entry> dictionary = new Dictionary<DateTime, Entry>
        {
            // empty
        };

        // constructor
        public Entry(DateTime aDate)
        {
            Title = "Untitled";
            Date = aDate;
            Content = "";
            Bookmarked = false;
            Tags = new List<string>();
            Pages = 1;
        }

        // properties
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("Bookmarked")]
        public bool Bookmarked { get; set; }

        [JsonProperty("Tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("Pages")]
        public int Pages { get; set; }
    }

    // who are you
    public class Root
    {
        [JsonProperty("Entry")]
        public Entry Entry { get; set; }
    }
}

