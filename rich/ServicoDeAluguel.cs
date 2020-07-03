using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace rich
{
    public class ServicoDeAluguel
    {
        public void Alugar(int idCliente, int idFilme)
        {
            var filme = new Filme("Star Wars");
            var email = new Email("aj@ivia.com.br");
            var cliente = new Cliente("fulano", email);
            cliente.AlugarFilme(filme);
        }
    }
}
