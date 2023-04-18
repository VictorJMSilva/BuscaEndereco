using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace CEPBLL
{
    public class ConsultaCep
    {
        private readonly HttpClient _httpClient;
        public ConsultaCep()
        {
            _httpClient = new HttpClient();
        }
        public CEP Consultar (string CepConsulta)
        {
            //CEP cepReturn = new CEP();
            //cepReturn.Bairro = "Boqueirao";
            //cepReturn.Logradouro = "Rua Oswaldo Cruz";
            //cepReturn.Complemento = "lado par";
            //cepReturn.Ddd = "13";
            //cepReturn.Localidade = "Santos";
            //cepReturn.Cep = "11045-907";
            //cepReturn.Uf = "SP";

            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
            
        }
    }
}
