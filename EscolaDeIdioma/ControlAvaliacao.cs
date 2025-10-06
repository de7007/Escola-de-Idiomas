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
    class ControlAvaliacao
    {
        private DAOAvaliacao dao;
        public ControlAvaliacao()
        {
            dao = new DAOAvaliacao();
        }//fim do construtor

        public ControlAvaliacao(double nota, DateTime dataAvaliacao, string observacao, int alunoCodigo)
        {
            this.dao = new DAOAvaliacao();
            this.dao.Inserir(nota, dataAvaliacao, observacao, alunoCodigo);
        }//fim do construtor

        //método que realiza o consultar tudo
        public void Imprimir()
        {
            this.dao = new DAOAvaliacao();
            Console.WriteLine(this.dao.ConsultarTudo());
        }//fim do imprimir

        //Método para consulta por código
        public void ConsultarPorCodigo()
        {
            this.dao = new DAOAvaliacao();
            Console.WriteLine("Informe o código que deseja buscar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //acionar o método consultar por código da DAO
            Console.WriteLine(this.dao.ConsultarPorCodigo(codigo));
        }//fim do método

        public void Atualizar()
        {
            //Criar a instancia no BD
            this.dao = new DAOAvaliacao();
            Console.WriteLine("Escolha o que deseja atualizar" +
                              "\n1. Nota" +
                              "\n2. Data de avaliação" +
                              "\n3. observacao" +
                              "\n4. Codigo do Aluno");
            int escolha = Convert.ToInt32(Console.ReadLine());
            //Pequena escolha
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\n\nAtualizar nota");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova nota");
                    double nota = Convert.ToDouble(Console.ReadLine());
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "nota ", nota));
                    break;
                case 2:
                    Console.WriteLine("\n\nAtualizar Data de avaliação");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova data de avalição");
                    DateTime dataAvaliacao = Convert.ToDateTime(Console.ReadLine());
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "dataAvaliacao", dataAvaliacao));
                    break;
                case 3:
                    Console.WriteLine("\n\nAtualizar Observação");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    //nova descricao
                    Console.WriteLine("Informe a nova observação");
                    string observacao = Console.ReadLine();
                    //atualizar
                    Console.WriteLine(this.dao.Atualizar(codigo, "observacao", observacao));
                    break;
                case 4:
                    Console.WriteLine("\n\nAtualizar Codigo do Aluno");
                    Console.WriteLine("Informe o código de onde irá atualizar");
                    codigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o novo codigo do aluno");
                    int alunoCodigo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(this.dao.Atualizar(codigo, "alunoCodigo", alunoCodigo));
                    break;
                default:
                    Console.WriteLine("Impossível atualizar, algo deu errado!");
                    break;
            }
        }//fim do atualizar

        public void Excluir()
        {
            this.dao = new DAOAvaliacao();
            Console.WriteLine("informe o código que deseja excluir");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //chama o método para excluir
            Console.WriteLine(this.dao.Deletar(codigo));
        }


    }//fim da classe
}//fim do projeto