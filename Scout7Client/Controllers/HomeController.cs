using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Scout7Client.Helpers;
using Scout7Client.Models;

namespace Scout7Client.Controllers
{
    public class HomeController : Controller
    {
        Scout7Api _scout7Api = new Scout7Api();

        public async Task<IActionResult> Index(int page=1)
        {
            List<Players> players = new List<Players>();
            try
            {
                WebClient client = _scout7Api.InitializeClient();
                const string url = "http://localhost:47285/api/values";

                var res = await client.DownloadStringTaskAsync(new Uri(url));

                players = JsonConvert.DeserializeObject<List<Players>>(res);

                int pageSize = 10;
                var count = players.Count();
                var items = players.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
                IndexViewModel viewModel = new IndexViewModel
                {
                    PageViewModel = pageViewModel,
                    Players = items
                };

                return View(viewModel);
            }
            catch
            {
                return View("Error");
            }
        }

    }
}
