using System;
using System.Collections.Generic;
using System.Text;

namespace rich
{
    public interface IRepositorio
    {
        bool EmailExiste(string Email);
    }
}
