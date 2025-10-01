using EscolaDeIdioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeIdioma
{
    class ControlCurso
    {
        private Curso curso;
        private DAOCurso dao;
        public ControlCurso()
        {
            curso = new Curso();
        }//fim do construtor

        public ControlCurso(string nome, int cargaHoraria, double valor)
        {
            this.dao = new DAOCurso();
            this.dao.Inserir(nome, cargaHoraria, valor);
        }//fim do construtor

        //método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOCurso();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOCurso();
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //acionar o método consultar por código da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do método

        public void Atualizar()
        {
            //Criar a instancia no BD
            this.dao = new DAOCurso();
            Console.WriteLine("Escolha o que deseja atualizar" +
                              "\n1. nome" +
                              "\n2. Carga Horária" +
                              "\n3. Valor");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequena escolha
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n\nAtualizar nome");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo nome");
                    string nome = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "nome", nome));
                    break;
                case 2:
                    Console.WriteLine("\n\nAtualizar Carga Horária");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova carga horária");
                    int cargaHoraria = Convert.ToInt32(Console.ReadLine());
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "carga Horaria", cargaHoraria));
                    break;
                case 3:
                    Console.WriteLine("\n\nAtualizar Valor");
                    Console.WriteLine("Informe o código de onde vai atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo valor");
                    double valor = Convert.ToInt32(Console.ReadLine());
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "carga Horaria", valor));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }
        }//fim do atualizar

        public void Excluir()
        {
            this.dao = new DAOCurso();
            Console.WriteLine("informe o código que deseja excluir");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //chama o método para excluir
            Console.WriteLine(this.dao.Deletar(codigo));
        }


    }//fim da classe
}//fim do projeto