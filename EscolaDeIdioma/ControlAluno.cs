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
    class ControlAluno
    {
        private DAOAluno dao;
        public ControlAluno()
        {
            dao = new DAOAluno();
        }//fim do construtor

        public ControlAluno(string nome, long CPF, string email, string telefone, DateTime dtDeNasc, int cursoCodigo)
        {
            this.dao = new DAOAluno();
            this.dao.Inserir(nome, CPF, email, telefone, dtDeNasc, cursoCodigo);
        }//fim do construtor

        //método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOAluno();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOAluno();
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //acionar o método consultar por código da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do método

        public void Atualizar()
        {
            //Criar a instancia no BD
            this.dao = new DAOAluno();
            Console.WriteLine("Escolha o que deseja atualizar" +
                              "\n1. Nome" +
                              "\n2. CPF" +
                              "\n3. Email" +
                              "\n4. Telefone" +
                              "\n5. Data de nascimento" +
                              "\n6. Codigo do Curso");
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
                    Console.WriteLine(this.dao.Atualizar(codigo, "nome", nome));
                    break;
                case 2:
                    Console.WriteLine("\n\nAtualizar CPF");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo CPF");
                    long CPF = Convert.ToInt64(Console.ReadLine());
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "CPF", CPF));
                    break;
                case 3:
                    Console.WriteLine("\n\nAtualizar Email");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe o novo Email");
                    string email = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "email", email));
                    break;
                case 4:
                    Console.WriteLine("\n\nAtualizar Telefone");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descrição
                    Console.WriteLine("Informe o novo telefone");
                    string telefone = Console.ReadLine();
                    //atualizando
                    Console.WriteLine(this.dao.Atualizar(codigo, "telefone", telefone));
                    break;
                case 5:
                    Console.WriteLine("\n\nAtualizar Data de Nascimento");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe a nova data de nascimento");
                    DateTime dtDeNasc = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine(this.dao.Atualizar(codigo, "dtDeNasc", dtDeNasc));
                    break;
                case 6:
                    Console.WriteLine("\n\nAtualizar Codigo do Curso");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo codigo do curso");
                    int cursoCodigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(this.dao.Atualizar(codigo, "cursoCodigo", cursoCodigo));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }
        }//fim do atualizar

        public void Excluir()
        {
            this.dao = new DAOAluno();
            Console.WriteLine("informe o código que deseja excluir");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //chama o método para excluir
            Console.WriteLine(this.dao.Deletar(codigo));
        }


    }//fim da classe
}//fim do projeto