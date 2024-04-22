class Program
{
    public static async Task Main(string[] args)
    {
        Console.Write("Informe o CEP: ");
        string cep = Console.ReadLine();

        EnderecoService enderecoService = new EnderecoService();

        Endereco enderecoEncontrado = await enderecoService.Integracao(cep);

        if (!enderecoEncontrado.Verificacao) 
        {
            Console.WriteLine(enderecoEncontrado.ToString());
        } else
        {
            Console.WriteLine($"CEP {cep} não encontrado");
        }
    } 
}