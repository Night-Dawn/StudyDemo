using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bing_Picture.Models;
using Bing_Picture.Services;
using Bing_Picture.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Bing_Picture.Models.BingPicture;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bing_Picture.Controllers
{
    public class PictureController : Controller
    {
        private readonly IPictureService pictureService;

        public PictureController(IPictureService pictureService)
        {
            this.pictureService = pictureService;
        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var images = await pictureService.GetAllAsync();
            var list= images.images.ToList();
            var picture = list.Select(x => new PictureViewModel {
                url = x.url,
                startdate = x.startdate,
                copyright=x.copyright
            });
            return View(picture);
        }
        public async  Task<ActionResult> Details(string url)
        {
            var picture = await pictureService.GetByUrlAsync(url);
            if (picture == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return  View(picture);
        }
    }
}
