using BandBookerData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BandBooker.Data
{
    public class ApiService
    {
        static string baseURL = "https://localhost:44367/";

        public static async Task<List<Instrument>> GetInstruments()
        {
            using(var http = new HttpClient())
            {
                var uri = new Uri(baseURL + "api/instruments");
                string json = await http.GetStringAsync(uri);
                var instrumnets = JsonConvert.DeserializeObject<List<Instrument>>(json);
                return instrumnets;
            }
        }
    }
}
