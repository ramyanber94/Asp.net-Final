using BoardGames_FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceStack;
using ServiceStack.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BoardGames_FinalProject.Services
{
    public static class Service
    {
     
        public static Games GetBoardGames()
        {
            var url = "https://api.boardgameatlas.com/api/search?order_by=rank&ascending=false&pretty=true&client_id=JLBr5npPhV";
            using (WebClient client = new WebClient())
            {
                var json = client.DownloadString(url);
                var game = JsonConvert.DeserializeObject<Games>(json);
               
                return game;
            }
        }
    }
}
