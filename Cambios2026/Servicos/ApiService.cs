using Cambios2026.Modelos;
using Newtonsoft.Json;

namespace Cambios2026.Servicos
{
    public class ApiService
    {
        public async Task<Response> GetRates(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSucccess = false,
                        Message = result
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Response
                {
                    IsSucccess = true,
                    Result = rates!
                };
            }
            catch(Exception ex)
            {
                return new Response
                {
                    IsSucccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
