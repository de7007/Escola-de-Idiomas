using EscolaDeIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlCategoria
    {
        private Categoria categoria;
        private DAOCategoria dao;
        public ControlCategoria()
        {
            categoria = new Categoria();
        }//fim do construtor

        public ControlCategoria(string descricao)
        {
            this.dao = new DAOCategoria();
            this.dao.Inserir(descricao);
        }//fim do construtor

        //método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOCategoria();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOCategoria();
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //acionar o método consultar por código da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do método

        public void Atualizar()
        {
            //Criar a instancia no BD
            this.dao = new DAOCategoria();
            Console.WriteLine("Escolha o que deseja atualizar" +
                              "\n1. Descricao");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequena escolha
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n\nAtualizar descrição");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova descricao");
                    string descricao = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "descricao", descricao));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }
        }//fim do atualizar

        public void Excluir()
        {
            this.dao = new DAOCategoria();
            Console.WriteLine("informe o código que deseja excluir");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //chama o método para excluir
            Console.WriteLine(this.dao.Deletar(codigo));
        }


    }//fim da classe
}//fim do projeto