using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bing_Picture.ViewModels
{
    public class MusicViewModel
    {

        [Display(Name ="歌曲Id")]
        public string id { get; set; }
        [Display(Name ="歌曲标题")]
        public string name { get; set; }
        [Display(Name ="歌手")]
        public string singer { get; set; }
        [Display(Name = "歌曲封面")]
        public string pic { get; set; }
        [Display(Name = "歌词")]
        public string lrc { get; set; }
        [Display(Name = "歌曲地址")]
        public string url { get; set; }
        [Display(Name = "歌曲时长")]
        public string time { get; set; }
    }
}
