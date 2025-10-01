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
    class ControlProfessor
    {
        private Professor professor;
        private DAOProfessor dao;
        public ControlProfessor()
        {
            professor = new Professor();
        }//fim do construtor

        public ControlProfessor(string nome, string idioma, string formacao, string telefone, int cursoCodigo)
        {
            this.dao = new DAOProfessor();
            this.dao.Inserir(nome, idioma, formacao, telefone, cursoCodigo);
        }//fim do construtor

        //método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOProfessor();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOProfessor();
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //acionar o método consultar por código da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do método

        public void Atualizar()
        {
            //Criar a instancia no BD
            this.dao = new DAOProfessor();
            Console.WriteLine("Escolha o que deseja atualizar" +
                              "\n1. Nome" +
                              "\n2. Idioma" +
                              "\n3. Formação" +
                              "\n4. Telefone");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequena escolha
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n\nAtualizar nome");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo nome");
                    string nome = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "nome ", nome));
                    break;
                case 2:
                    Console.WriteLine("\n\nAtualizar Idioma");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo idioma");
                    string idioma = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "Idioma ", idioma));
                    break;
                case 3:
                    Console.WriteLine("\n\nAtualizar Formação");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova formação");
                    string formacao = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "Formação ", formacao));
                    break;
                case 4:
                    Console.WriteLine("\n\nAtualizar Telefone");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descrição
                    Console.WriteLine("Informe o novo telefone");
                    string telefone = Console.ReadLine();
                    //atualizando
                    Console.WriteLine(this.dao.Atualizar(codigo, "Telefone ", telefone));
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