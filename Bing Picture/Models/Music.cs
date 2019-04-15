using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bing_Picture.Models
{
    public class Music
    {

        public class Rootobject
        {
            public string result { get; set; }
            public int code { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public string songListId { get; set; }
            public string songListName { get; set; }
            public string songListPic { get; set; }
            public int songListCount { get; set; }
            public long songListPlayCount { get; set; }
            public string songListDescription { get; set; }
            public int songListUserId { get; set; }
            public Song[] songs { get; set; }
        }

        public class Song
        {
            public string id { get; set; }
            public string name { get; set; }
            public string singer { get; set; }
            public string pic { get; set; }
            public string lrc { get; set; }
            public string url { get; set; }
            public int time { get; set; }
        }

    }
}
