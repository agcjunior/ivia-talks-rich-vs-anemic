using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace rich
{
    public class ServicoDeCliente : Notifiable
    {
        private readonly IRepositorio repositorio;

        public ServicoDeCliente(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Registrar(string nome, string email)
        {
            // verificar se o email ja existe
            if (repositorio.EmailExiste(email))
                AddNotification("Email", "Email já existe no cadastro");

            var emailCliente = new Email(email);
            var cliente = new Cliente(nome, emailCliente);

        }
    }
}
