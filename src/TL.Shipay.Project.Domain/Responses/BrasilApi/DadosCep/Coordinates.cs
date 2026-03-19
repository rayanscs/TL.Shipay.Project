using Newtonsoft.Json;

namespace TL.Shipay.Project.Domain.Responses.BrasilApi.DadosCep
{
    public class Coordinates
    {
        [JsonProperty("longitude")]
        public string? Longitude { get; set; }

        [JsonProperty("latitude")]
        public string? Latitude { get; set; }
    }
}
