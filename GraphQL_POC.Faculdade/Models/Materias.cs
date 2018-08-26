namespace GraphQL_POC.Faculdade.Models
{
    public class Materias
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Materias(string nome)
        {
            this.Nome = nome;
        }
    }
}