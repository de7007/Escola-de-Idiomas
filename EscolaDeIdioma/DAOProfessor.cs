using MySql.Data;//Import fo MySql
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;//Import do MySql - Com métodos do CRUD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeIdioma
{
    internal class DAOProfessor
    {
        public MySqlConnection conexao;//criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] nome;
        public string[] idioma;
        public string[] formacao;
        public string[] telefone;
        public int[] cursoCodigo;
        public int i;
        public int contador;
        public string msg;
        public DAOProfessor()
        {
            //conectar com o banco
            conexao = new MySqlConnection("server=localhost;Database=escolaidioma;UId=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//tenta abrir a conexão com o banco de dados
                Console.WriteLine("Conectado com Sucesso!");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo está errado!\n\n" + erro);
                conexao.Close();//Fechar a conexao
            }//fim do try/catch

        }//fim do construtor
        public void Inserir(string nome, string idioma, string formacao, string telefone, int cursoCodigo)
        {
            try
            {
                dados = $"('','{nome}', '{idioma}', '{formacao}', '{telefone}', '{cursoCodigo}')";
                comando = $"Insert into professor(codigo, nome, idioma, formacao, telefone, cursoCodigo) values{dados}";
                //lançar os dados no banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();//comando de inserção/Ações
                Console.WriteLine($"Inserido com sucesso :) {resultado}");//visualizando o resultado 
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Algo deu errado :(\n\n {erro}");
            }
        }//fim do inserir

        //método para preencher o vetor
        public void PreencherVetor()
        {
            string query = "select * from professor";//comando SQL para acesso de dados
            //Instanciar os vetores
            codigo = new int[100];
            nome = new string[100];
            idioma = new string[100];
            formacao = new string[100];
            telefone = new string[100];
            cursoCodigo = new int[100];

            //reafirmar que eu quero preencher com 0 e "" os vetores
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
                idioma[i] = "";
                formacao[i] = "";
                telefone[i] = "";
                cursoCodigo[i] = 0;
            }//fim do for

            //executar o comando no BD 
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //leitura dos dados do Banco - Por Linha
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            //buscar os dados no banco e preencher o vetor
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                idioma[i] = leitura["idioma"] + "";
                formacao[i] = leitura["formacao"] + "";
                telefone[i] = leitura["telefone"] + "";
                cursoCodigo[i] = Convert.ToInt32(leitura["cursoCodigo"]);
                i++;//anda plelo vetor 
                contador++;//conta exatamente quantos dados foram inseridos
            }//fim do while

            //fechar a leitura dos dados com banco de dados
            leitura.Close();
        }//fim do preencher

        public string ConsultarTudo()
        {
            //Prencher o vetor
            PreencherVetor();
            msg = "";//instanciando variavel
            for (i = 0; i < contador; i++)
            {
                msg += $"\nCódigo: {codigo[i]} \n Nome: {nome[i]} \n Idioma: {idioma[i]} \n Formacao: {formacao[i]} \n Telefone:{telefone[i]} \n Curso Codigo: {cursoCodigo[i]}";
            }//fim do for 
            //Mostrar todos os dados do BD
            return msg;
        }//fim do método

        public string ConsultarPorCodigo(int codigo)
        {
            PreencherVetor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    msg = $"\nCódigo: {this.codigo[i]} \nNome: {nome[i]} \n Idioma: {idioma[i]} \n Formacao: {formacao[i]} \n  Telefone:{telefone[i]} Curso Codigo: {cursoCodigo[i]}";
                    return msg;
                }//fim do if
            }//fim do for 
            return "\n\nCódigo informado não foi encontrado!";
        }//fim do método

        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update professor set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso :)";
            }
            catch (Exception erro)
            {
                return $"\n Algo deu errado :( \n\n {erro}";
            }//fim do catch

        }//fim do método

        public string Atualizar(int codigo, string campo, int novoDado)
        {
            try
            {
                string query = $"update professor set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso :)";
            }
            catch (Exception erro)
            {
                return $"\n Algo deu errado :( \n\n {erro}";
            }//fim do catch

        }//fim do método

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from professor where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado excluido!";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }//fim do try/catch
        }//fim do método


    }//fim da classe
}//fim do projeto