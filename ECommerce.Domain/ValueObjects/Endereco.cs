namespace ECommerce.Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string NumeroResidencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}