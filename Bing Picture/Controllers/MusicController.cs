using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bing_Picture.Services;
using Bing_Picture.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bing_Picture.Controllers
{
    [Authorize]
    public class MusicController : Controller
    {
        private readonly IMusicService musicService;

        public MusicController(IMusicService musicService)
        {
            this.musicService = musicService;
        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var music = await musicService.GetAllAsync();
            if (music == null)
            {
                return RedirectToAction("获取服务失败!");
            }
            if (music.code == 200 && music.result == "SUCCESS")
            {
                var list = music.data.songs.ToList();
                var menu = list.Select(x => new MusicViewModel{
                    id=x.id,
                    name=x.name,
                    time = $"{x.time/60}:{ x.time % 60 }",
                    lrc=x.lrc,
                    pic=x.pic,
                    singer=x.singer,
                    url=x.url
                });
                return View(menu);
            }
            return RedirectToAction("获取音乐列表失败!");
        }
    }
}
