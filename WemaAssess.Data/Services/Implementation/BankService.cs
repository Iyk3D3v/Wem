using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WemaAssess.Data.Dtos;
using WemaAssess.Data.Services.Interfaces;

namespace WemaAssess.Data.Services.Implementation
{
    public class BankService : IBankService
    {
        private readonly string base_url = "https://wema-alatdev-apimgt.azure-api.net/";

        private readonly string sub_key = "138a7b73e40c4903b06d550ca1f8c961";

        public async Task<BankWrapperDto> GetBanks()
        {
            try
            {
                using(var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(base_url);
                    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{sub_key}");
                    var res = await client.GetAsync($"alat-test/api/Shared/GetAllBanks");

                    var resp = await res.Content.ReadAsStringAsync();
                    //convert to paystack structure instead
                    var data = JsonConvert.DeserializeObject<BankWrapperDto>(resp);

                    return data;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
