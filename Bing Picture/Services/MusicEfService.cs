using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bing_Picture.Data;
using Bing_Picture.Models;
using static Bing_Picture.Models.Music;

namespace Bing_Picture.Services
{
    public class MusicEfService : IMusicService
    {
        private readonly MusicContext context;

        public MusicEfService(MusicContext context)
        {
            this.context = context;
        }
        public async Task<Rootobject> GetAllAsync()
        {
            var rootobject = await context.music();
            return rootobject;
        }
    }
}
