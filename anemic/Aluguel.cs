using System;

namespace anemic
{
    public class Aluguel 
    {
        public int Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public Filme Filme { get; private set; }
        public DateTime Data { get; private set; }

        public Aluguel()
        {

        }
    }
}