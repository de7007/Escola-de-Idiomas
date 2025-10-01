using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeIdioma
{
    class Categoria
    {
        //Declarei as Variaveis 
        private int codigo;
        private string nome;
        private int cargaHoraria;
        private double valor;

        public Curso()
        {
            this.codigo = 0;
            this.nome = "";
            this.cargaHoraria = 0;
            this.valor = 0.0;
        }//Fim do construtor

        public Categoria(int codigo, string nome, int cargaHoraria, double valor)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valor = valor;
        }//fim do construtor categoria

        //metodo get e set
        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }//fim do modificar codigo

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }//fim do modificar descricao

        public int ModificarCargaHoraria
        {
            get { return this.cargaHoraria; }
            set { this.cargaHoraria = value; }
        }//fim do modificar carga horaria

        public double ModificarValor
        {
            get { return this.valor; }
            set { this.valor = value; }
        }//fim do modificar valor

        public string Imprimir()
        {
            return "\nCódigo: " + ModificarCodigo +
                   "\nNome: " + ModificarNome +
                   "\n:Carga Horária: " + ModificarCargaHoraria +
                   "\nValor" + ModificarValor;
        }//fim do imprimir

    }//Fim da Classe
}//fim do projeto