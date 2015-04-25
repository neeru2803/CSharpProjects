using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;



namespace WeatherApp
{
    public class Weather
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your zipcode");
            var zipcode = Console.ReadLine();
            var url = String.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&mode=xml&units=metric&cnt=2",zipcode);
            var Client = new HttpClient();
            var response = Client.GetAsync(url).Result;
            var responseContent = response.Content;

            string responsestring = responseContent.ReadAsStringAsync().Result;
            Console.WriteLine( responsestring);
            Console.ReadLine();
            
        }
    }
}
