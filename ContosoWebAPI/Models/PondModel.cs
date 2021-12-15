using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoWebAPI.Models
{
    //test comment
    public class PondModel
    {
        [JsonProperty(PropertyName = "HarvestYear")]
        public string harvestYear { get; set; }  


    "HarvestYear": "2021",
    "HarvestMonth": "2",
    "LocationName": "XYZ",
    "PondCode": "2004",
    "PondName": "Ps 04",
    "Hectareas": "38.78",
    "StartDate": "06/11/2020",
    "SeedSize": "0.47",
    "HarvestDate": "26/02/2021",
    "Survival": "50.47",
    "HarvestSize": "25.44",
    "HarvestedKg": "54729",
    "JuvenileCost": "52043.56",
    "FoodCost": "125861.84",
    "OperativeCost": "102771.62",
    "TotalCost": "295771.76",
    "Income": "256862.28",
    "YearMonth_key": "2021-2",
    "InitialAverageWeight": "0.47",
    "EstimatedEndDate": "26/02/2021",
    "EstimatedHarvestAverageWeight": "25.44",
    "EstimatedSurvival": "50.47",
    "AverageWeight": "25.44",
    "InitialPopulation": null,
    "FoodType": null,
    "DailyFeed": null,
    "Observation": null,



        //[JsonProperty(PropertyName = "id")]
        //public string Id { get; set; }  //working

        //[JsonProperty(PropertyName = "pondID")]
        //public int PondID { get; set; }

        //[JsonProperty(PropertyName = "start_date")] //working
        //public DateTimeOffset Start_date { get; set; }

        //[JsonProperty(PropertyName = "initial_population")]  //working
        //public int Initial_population { get; set; }

        //[JsonProperty(PropertyName = "initial_average_weight")]
        //public int Initial_average_weight { get; set; }

        //[JsonProperty(PropertyName = "estimated_end_date")]
        //public DateTimeOffset Estimated_end_date { get; set; }

        //[JsonProperty(PropertyName = "estimated_harvest_average_weight")]
        //public double Estimated_harvest_average_weight { get; set; }

        //[JsonProperty(PropertyName = "estimated_survival")]
        //public double Estimated_survival { get; set; }

        //[JsonProperty(PropertyName = "food_type")]
        //public string Food_type { get; set; } //working
    }
}
