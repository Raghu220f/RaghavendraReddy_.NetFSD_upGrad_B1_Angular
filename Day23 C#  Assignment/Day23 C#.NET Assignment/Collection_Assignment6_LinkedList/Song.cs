using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assignment6_LinkedList
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(int id, string title, string artist)
        {
            Id = id;
            Title = title;
            Artist = artist;
        }
    }
}
