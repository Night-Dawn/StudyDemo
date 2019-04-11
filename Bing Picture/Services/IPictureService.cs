using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bing_Picture.Models;
using Bing_Picture.ViewModels;
using static Bing_Picture.Models.BingPicture;

namespace Bing_Picture.Services
{
    public interface IPictureService
    {
        Task<Rootobject> GetAllAsync();
        Task<Rootobject> GetByDateAsync(int date);
        Task<PictureViewModel> GetByUrlAsync(string imgurl);
    }
}
