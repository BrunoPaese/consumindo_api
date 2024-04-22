using Newtonsoft.Json;
class EnderecoService
{
    public async Task<Endereco> Integracao(string cep)
    {
        HttpClient httpClient = new HttpClient();
        var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
        var jsonString = await response.Content.ReadAsStringAsync();
        var jsonObect = JsonConvert.DeserializeObject<Endereco>(jsonString);

        if (jsonObect != null)
        {
            return jsonObect;
        } else
        {
            return new Endereco(cep) {
                Verificacao = true
            };
        }
    }

}
