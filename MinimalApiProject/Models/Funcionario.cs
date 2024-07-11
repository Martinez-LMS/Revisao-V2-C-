namespace MinimalApiProject.Models
{
    public class Funcionario
    {
        public Funcionario()
        {
            Id = Guid.NewGuid().ToString();  // chave primaria usando GUID
        }

        public string Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
    }
}
