using CountryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace CountryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        public CountryController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet("{countryName}")]
        public async Task<IActionResult> GetCountryDetails(string countryName)
        {
            var client = _clientFactory.CreateClient("CountryDetails");
            var response = await client.GetAsync($"name/{countryName}");

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                var countryDetails = await JsonSerializer.DeserializeAsync<CountryDetail[]>(contentStream);

                if (countryDetails.Length > 0)
                {
                    return Ok(countryDetails);
                }
            }
            return NotFound();
        }
        [HttpPost("CountryStates")]
        public async Task<IActionResult> GetCountryStates([FromBody] PostData request)
        {
            var client = _clientFactory.CreateClient("CountryStates");
            var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("countries/states", content);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var parsedResponse = JsonSerializer.Deserialize<object>(responseBody);


            return Ok(parsedResponse);
        }

        [HttpPost("CountryCities")]
        public async Task<IActionResult> GetStateAndCities([FromBody] PostData request)
        {
            var client = _clientFactory.CreateClient("CountryCities");
            var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("countries/cities", content);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            var parsedResponse = JsonSerializer.Deserialize<object>(responseBody);


            return Ok(parsedResponse);

        }
    }

}
