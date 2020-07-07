using System;

namespace rich
{
    public class Aluguel : Entity
    {        
        public Cliente Cliente { get; private set; }
        public Filme Filme { get; private set; }
        public DateTime Data { get; private set; }

        public Aluguel(Cliente cliente, Filme filme)
        {
            this.Data = DateTime.Now.Date;
            this.Cliente = cliente;
            this.Filme = filme;
        }
    }
}
