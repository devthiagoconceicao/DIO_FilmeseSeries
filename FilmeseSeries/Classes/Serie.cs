using System;

namespace Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private int SerieFilme { get; set; }
        private string Ator { get; set; }
        private int Ano { get; set; }
        private string formato {get; set; } 

        private bool Excluido { get; set; }
            
        // Metodo
        public Serie(int id, Genero genero, int tipo, string titulo, string ator, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.SerieFilme = tipo;
            this.Titulo = titulo;
            this.Ator = ator;
            this.Ano = ano;
            this.Excluido = false;

            if(this.SerieFilme == 1)
                formato = "Serie";
            else if(this.SerieFilme == 2)
                formato = "Filme";
        }

        public override string ToString()
		{                       
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Formato: " + formato + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Ator principal: " + this.Ator + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}
        public string retornaTipo()
		{
			return this.formato;
		}
		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }

    }
}