using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebServiceAPI;

namespace FluencyNow.API
{
    public static class ApiService
    {
        public const string uRl = "https://webapplication1-eh3.conveyor.cloud/";

        public static async Task<List<tbl_Register>> ObterCliente()
        {
            //Estudar => Try and Cath/  throw  /  async
            try
            {
                HttpClient client = new HttpClient();
                string url = uRl + "api/tbl_Register";
                string response = await client.GetStringAsync(url);
                List<tbl_Register> Register = JsonConvert.DeserializeObject<List<tbl_Register>>(response);
                return Register;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
