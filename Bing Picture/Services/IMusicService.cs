using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Bing_Picture.Models.Music;

namespace Bing_Picture.Services
{
    public interface IMusicService
    {
        Task<Rootobject> GetAllAsync();
    }
}
