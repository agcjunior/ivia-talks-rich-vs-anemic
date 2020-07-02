using System;
using System.Collections.Generic;
using System.Text;

namespace rich
{
    public class Aluguel : Entity
    {        
        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
        public DateTime Data { get; set; }
    }
}
