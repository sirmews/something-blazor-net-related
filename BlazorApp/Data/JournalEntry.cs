using System;

namespace BlazorApp.Data
{
    public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Mood { get; set; }
        public string Entry { get; set; }
    }
}
