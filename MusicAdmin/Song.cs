using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAdmin
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public long Album { get; set; }
        public int Track { get; set; }
        public string Language { get; set; }
    }
}
