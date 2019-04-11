using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static Bing_Picture.Models.BingPicture;

namespace Bing_Picture.Data
{
    public class PictureContext
    {

        public async Task<Rootobject> picture()
        {
            HttpClient httpClient = new HttpClient();
            string url = String.Format($"https://cn.bing.com/HPImageArchive.aspx?format=js&idx=-1&n=8&mkt=zh-CN");
            var respone = await httpClient.GetAsync(url);
            var result = await respone.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Rootobject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Rootobject)serializer.ReadObject(ms);
            return data;
            
        }
    }
}
