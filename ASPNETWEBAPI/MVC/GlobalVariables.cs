using System.Net.Http.Headers;

namespace MVC
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

        GlobalVariables() 
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:5108/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
