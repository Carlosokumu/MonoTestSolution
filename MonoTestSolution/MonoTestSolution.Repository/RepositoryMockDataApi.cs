using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MonoTestSolution.Repository
{

    public class RepositoryMockDataApi : IRepositoryMockDataApi
    {
        

        public async Task<List<VehicleModelDto>> GetVehicleModels(string make)
        {
            String BASE_URL = "https://api.api-ninjas.com/v1/cars";
            var VehicleModels = new List<VehicleModelDto>();
            //var make = "Bmw";
            String url = BASE_URL + $"?make={make}";
            Debug.WriteLine("Fetching data");
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", "4eO2Qi1Epso4naEyhHbvPw==yDDMYH6nGC9axHyZ");
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                Debug.WriteLine("Successfully fetched Data..");
                var content = await response.Content.ReadAsStringAsync();
                var fetchedmodels = JsonConvert.DeserializeObject<List<ModelsResponse>>(content);
                foreach (var vehiclemodel in fetchedmodels)
                    VehicleModels.Add(new VehicleModelDto {
                        Id = new Guid(),
                        Name = vehiclemodel.model,
                        Abbr = GenerateAbbreviation(vehiclemodel.model),
                        Year = vehiclemodel.year.ToString()

                    }); ;

                return VehicleModels;


            }
            catch (HttpRequestException e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public string GenerateAbbreviation(string model){
           var pattern = @"((?<=^|\s)(\w{1})|([A-Z]))";
           return string.Join(string.Empty, Regex.Matches(model, pattern).OfType<Match>().Select(x => x.Value.ToUpper()));
          
        }
        
    }
 }

