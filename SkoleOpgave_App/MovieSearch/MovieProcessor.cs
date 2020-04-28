using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using System.Threading.Tasks;

namespace MovieSearch
{
    public class MovieProcessor
    {
        public async Task<Movie> LoadMovie(string search = "simpsons")
        {
            string url = $"http://www.omdbapi.com/?i=tt3896198&apikey=51485f25&t={ search}";

            using (HttpResponseMessage response = await ApiStart.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string movie = await response.Content.ReadAsStringAsync();
                    Movie movie1 = JsonConvert.DeserializeObject<Movie>(movie);
                    return movie1;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<Movie> LoadImage(string search = "simpsons")
        {
            string url = $"http://img.omdbapi.com/?i=tt3896198&apikey=51485f25&t={search}";
            Movie movie = null;
            return movie;
        }
    }
}
