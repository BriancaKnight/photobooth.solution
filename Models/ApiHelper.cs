using System.Threading.Tasks;
using RestSharp;

namespace PhotoBooth.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5001/");
      RestRequest request = new RestRequest($"api/booths", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    
  }
}