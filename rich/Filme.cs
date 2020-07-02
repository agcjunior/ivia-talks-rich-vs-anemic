namespace rich
{
    public class Filme : Entity
    {
        public string Nome { get; private set; }

        public Filme(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                AddNotification("Nome", "O nome é requerido");
            }

            this.Nome = nome;
        }
    }
}