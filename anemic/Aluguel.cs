using System;

namespace anemic
{
    public class Aluguel
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
        public DateTime Data { get; set; }
    }
}