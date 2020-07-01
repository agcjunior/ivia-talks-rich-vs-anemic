using System;
using System.Collections.Generic;

namespace anemic
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public TipoCliente Tipo { get; set; }
        public List<Aluguel> Alugueis { get; set; }

        public Cliente()
        {
            Alugueis = new List<Aluguel>();
        }
    }
}
