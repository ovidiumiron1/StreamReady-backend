using System;

namespace StreamReady_backend.Models
{
    public class Song
    {
        public string SongId { get; set; }
        public int SongLength { get; set; }
        public string Photo { get; set; }
        public int Size { get; set; }
    }
}