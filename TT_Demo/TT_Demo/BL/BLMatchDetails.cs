using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TT_Demo.Model;

namespace TT_Demo.BL
{
    public class BLMatchDetails
    {                       
        public List<MyMatchInfo> MatchInfo { get; set; }
      
        public async Task GetMatchDetails()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("http://192.168.1.184:1214/api/values/getmymatchinfo?userid=1");
            var result = JsonConvert.DeserializeObject<RootObject>(json);
            MatchInfo = result.Message.ToList();
            
        }
    }
}
