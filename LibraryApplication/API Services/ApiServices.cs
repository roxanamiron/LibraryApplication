using LibraryApplication.Domain.Entities;
using LibraryApplication.Repository.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryApplication.API_Services
{

    public class ApiServices
    {
        public static async Task<List<Book>> GetBooks(string searchTerm, int page)
        {
            Counter counter = new Counter();

            using (HttpClient client = new HttpClient())
            {
                // todo: change searchTerm in url to be the searchTerm parameter value not the string "searchTerm"
                var url = "https://chroniclingamerica.loc.gov/search/titles/results/?terms=" + searchTerm + "&format=json";

                // string format
                //String value = "searchTerm";
                //String stringFormat = String.Format("https://chroniclingamerica.loc.gov/search/titles/results/?terms={0}&format=json", value);
                //Console.WriteLine(stringFormat);



                // string interpolation
                //String value = "searchTerm";
                //String interpolation = ($"https://chroniclingamerica.loc.gov/search/titles/results/?terms={value}&format=json");
                //Console.WriteLine(interpolation);

                //var url = "https://chroniclingamerica.loc.gov/search/titles/results?format=json";
                var response = await client.GetAsync(url);

                var json = await response.Content.ReadAsStringAsync();
                   if(response.IsSuccessStatusCode)
                    {

                        var result = JsonConvert.DeserializeObject<Counter>(json, new
                            JsonSerializerSettings
                        { TypeNameHandling = TypeNameHandling.Auto });

                    return await Task.FromResult(result.books);
                    }
                   else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                    
            }
        }

        public static async Task<Counter> GetBooksNumber()
        {     



            Counter counter = new Counter();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://chroniclingamerica.loc.gov/search/titles/results?format=json");
                
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var results = JsonConvert.DeserializeObject<Counter>(json);
                    return await Task.FromResult(results);

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

        //public static async List<Book> DeleteBooksAsync()
        //{
        //    HttpResponseMessage response = await client.DeleteAsync();
        //    return response.StatusCode;
        //}   

    }
}
               
           

