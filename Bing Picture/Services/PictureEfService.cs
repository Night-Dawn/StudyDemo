using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bing_Picture.Data;
using Bing_Picture.Models;
using Bing_Picture.ViewModels;
using static Bing_Picture.Models.BingPicture;

namespace Bing_Picture.Services
{
    public class PictureEfService:IPictureService
    {
        private readonly PictureContext _context;

        public PictureEfService(PictureContext context)
        {
            _context = context;
        }

        //获取图片
        public async  Task<Rootobject> GetAllAsync()
        {

            var rootobject = await _context.picture();
            return rootobject;
        }

        public Task<Rootobject> GetByDateAsync(int date)
        {
            throw new NotImplementedException();
        }

        public async Task<PictureViewModel> GetByUrlAsync(string imgurl)
        {
            var roobject = await _context.picture();
            var list = roobject.images.ToList();
            var picture = list.Find(x=>x.url==imgurl);
            var pictureviewmodel = new PictureViewModel() {
                url=picture.url,
                startdate=picture.startdate,
                copyright=picture.copyright
            };
            return pictureviewmodel;
        }
    }
}
