using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static Bing_Picture.Models.Music;

namespace Bing_Picture.Data
{
    public class MusicContext
    {
        public async Task<Rootobject> music()
        {
            HttpClient httpClient = new HttpClient();
            string url = "https://api.itooi.cn/music/netease/songList?key=579621905&id=3778678&limit=10&offset=0";
            var respone = await httpClient.GetAsync(url);
            var result = await respone.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Rootobject));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Rootobject)serializer.ReadObject(ms);
            return data;
        }
    }
}
