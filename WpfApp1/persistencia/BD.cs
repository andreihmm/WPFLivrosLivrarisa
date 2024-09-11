using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using WpfApp1.model;


namespace WpfApp1.persistencia
{
    internal class BD
    {
        public static List<Livro> list_livros = new List<Livro>();

        public static void SalvarLivro(Livro l) => list_livros.Add(l);

        public static List<Livro> ExibirLivros() => list_livros;



        public static List<Livraria> list_livrarias = new List<Livraria>();

        public static void SalvarLivraria(Livraria l) => list_livrarias.Add(l);

        public static List<Livraria> ExibirLivrarias() => list_livrarias;

    }
}
