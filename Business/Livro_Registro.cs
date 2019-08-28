using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Livro_Registro
    {
        private String nomeLivroRegistro;
        private int numeroLivro;
        private int numeroPagina;
        private int numeroRegistro;
        private int idTipoLivro;

        public Livro_Registro()
        {

        }

        public Livro_Registro(string nomeLivroRegistro, int numeroLivro, int numeroPagina, int numeroRegistro)
        {
            this.NomeLivroRegistro = nomeLivroRegistro;
            this.NumeroLivro = numeroLivro;
            this.NumeroPagina = numeroPagina;
            this.NumeroRegistro = numeroRegistro;
            this.IdTipoLivro = idLivro(nomeLivroRegistro);
        }

        public int idLivro(String tipo)
        {
            int id;
            if(tipo == "A")
            {
                id = 1;
            }
            else
            {
                id = 2;
            }
            return id;
        }

        public string NomeLivroRegistro { get => nomeLivroRegistro; set => nomeLivroRegistro = value; }
        public int NumeroLivro { get => numeroLivro; set => numeroLivro = value; }
        public int NumeroPagina { get => numeroPagina; set => numeroPagina = value; }
        public int NumeroRegistro { get => numeroRegistro; set => numeroRegistro = value; }
        public int IdTipoLivro { get => idTipoLivro; set => idTipoLivro = value; }
    }
}
