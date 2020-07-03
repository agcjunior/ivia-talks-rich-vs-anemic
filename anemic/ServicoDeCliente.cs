namespace anemic
{
    public class ServicoDeCliente
    {
        public void Registrar(string nome, string email)
        {
            // Validar nome
            // Validar email
            // Verificar se email já está em uso

            // Criar objeto cliente
            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Email = "";
            cliente.Tipo = TipoCliente.Normal;
            
            // Gravar no BD
        }
    }
}