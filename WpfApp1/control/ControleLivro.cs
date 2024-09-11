using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.model;

namespace WpfApp1.control
{
    internal class ControleLivro
    {
        private Livro ModeloPersistenciaLivro = new();
        private Livro ModeloPersistenciaLivraria = new();

        public Boolean ControleCadastrarLivro(string Titulo, string Isbn, string Autor, int Idade)
        {
            Livro nl = new()
            {
                titulo = Titulo,
                isbn = Isbn,
                autor = Autor,
                idade = Idade
            };

            if (ModeloPersistenciaLivro.Cadastr)

                return true;
        }
    }
}
