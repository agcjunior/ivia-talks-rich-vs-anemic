using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rich
{
    public class Cliente : Entity
    {       
        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public TipoCliente Tipo { get; private set; }
        private readonly List<Aluguel> _alugueis = new List<Aluguel>();
        public IReadOnlyList<Aluguel> Alugueis => _alugueis.ToList();

        public Cliente() { }
        public Cliente(string nome, Email email )
        {
            if (string.IsNullOrEmpty(nome))
            {
                AddNotification("Nome", "Nome é requerido");
            }

            this.Nome = nome;
        }

        public void AlugarFilme(Filme filme)
        {
            // regras de validação
            // regras de negócio
            var aluguel = new Aluguel(this, filme);
            
        }
    }
}
