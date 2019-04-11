using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bing_Picture.Models;
using static Bing_Picture.Models.BingPicture;

namespace Bing_Picture.ViewModels
{
    public class PictureViewModel
    {
        [Display(Name = "图片地址")]
        public string url { get; set; }
        [Display(Name = "图片日期")]
        public string startdate { get; set; }
            [Display(Name = "版权声明")]
        public string copyright { get; set; }

        
    }
}