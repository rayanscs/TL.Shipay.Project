using Newtonsoft.Json;

namespace TL.Shipay.Project.Domain.Responses.BrasilApi.DadosCnpj
{
    public class CnaesSecundario
    {
        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        [JsonProperty("descricao")]
        public string? Descricao { get; set; }
    }
}
