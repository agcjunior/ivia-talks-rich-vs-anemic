using System;
using Xunit;

namespace rich.tests
{
    public class DominioTests
    {
        [Fact]
        public void nao_posso_criar_um_filme_sem_nome()
        {
            var filme = new rich.Filme("");
            Assert.True(filme.Invalid);
        }

        [Fact]
        public void so_posso_criar_um_filme_com_nome()
        {
            var filme = new rich.Filme("Tubarão");
            Assert.True(filme.Valid);
        }
    }
}
