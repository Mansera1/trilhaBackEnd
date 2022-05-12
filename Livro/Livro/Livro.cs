using System;


namespace Livro
{
    internal class Livro
    {
        public string Nome;
        public string Autor;
        public string Genero;
        public int QtdPaginas;
        public int PaginasLidas;

        public int VerificarProgresso()
        {
             return PaginasLidas * 100/ QtdPaginas;
            
        }

    }
}
