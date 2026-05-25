using Cambios2026.Modelos;
using System.Net;

namespace Cambios2026.Servicos
{
    public class NetworkService
    {

        public Response CheckConnection()
        {
            var client = new WebClient();

            try
            {
                using(client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Response
                    {
                        IsSucccess = true,
                    };
                }
            }
            catch
            {
                return new Response
                {
                    IsSucccess = false,
                    Message = "Configure a sua ligação á Internet"
                };
            }
        }

        //    private static readonly HttpClient client = new HttpClient();

        //    public async Task<Response> CheckConnection()
        //    {
        //        try
        //        {
        //            var response = await client.GetAsync("http://clients3.google.com/generate_204");

        //            return new Response
        //            {
        //                IsSucccess = response.IsSuccessStatusCode
        //            };
        //        }
        //        catch
        //        {
        //            return new Response
        //            {
        //                IsSucccess = false,
        //                Message = "Configure a sua ligação á Internet"
        //            };
        //        }
        //    }
    }
}
