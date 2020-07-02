using System;
using System.Collections.Generic;
using System.Text;

namespace rich
{
    public class Cliente : Entity
    {       
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
