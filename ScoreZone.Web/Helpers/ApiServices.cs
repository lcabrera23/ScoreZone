using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ScoreZone.Web.Data.NoticiasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScoreZone.Web.Helpers
{
    public class ApiServices : IApiServices
    {

        public async Task<Root> getFirtsNews(string url)
        {
          

            try
            {
                using (var htpClient = new HttpClient())
                {
                    htpClient.BaseAddress = new Uri(url);
                    var postTask = htpClient.GetAsync(url);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = await result.Content.ReadAsStringAsync();
                        var resultados = JsonConvert.DeserializeObject<Root>(readTask);

                            return resultados;
                    }

                }
                return null;

            }
            catch (Exception)
            {

                return null;
            }

            
        }


        public async Task<Root2> getSecondNews(string url)
        {
            try
            {
                using (var htpClient = new HttpClient())
                {
                    htpClient.BaseAddress = new Uri(url);
                    var postTask = htpClient.GetAsync(url);
                    postTask.Wait();
                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = await result.Content.ReadAsStringAsync();
                        var resultados = JsonConvert.DeserializeObject<Root2>(readTask);

                        return resultados;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }
    }
}
