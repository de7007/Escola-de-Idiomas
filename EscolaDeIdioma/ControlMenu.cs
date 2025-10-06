using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDeIdioma
{
    class ControlMenu
    {
        //Declarar variavel que representara as classes control
        private ControlCurso controleCurso;
        private ControlProfessor controleProfessor;
        private ControlAluno controleAluno;
        private ControlAvaliacao controleAvaliacao;
        private int opcaoPrincipal;
        private int opcaoGeral;

        public ControlMenu()
        {
            controleCurso = new ControlCurso();
            controleProfessor = new ControlProfessor();
            controleAluno = new ControlAluno();
            controleAvaliacao = new ControlAvaliacao();
        }//fim do construtor

        //metodo GET e SET
        public int ModificarOpcaoPrincipal
        {
            get { return opcaoPrincipal; }
            set { opcaoPrincipal = value; }
        }//fim do metodo

        public int ModificarOpcaoGeral
        {
            get { return opcaoGeral; }
            set { opcaoGeral = value; }
        }

        //mostrar menu
        public void MostrarMenu()
        {
            Console.Clear();//Limpa o Console
            Console.WriteLine("\n\n Menu Principal \n\n" +
                              "Escolha uma das opções abaixo:" +
                              "\n0.Sair" +
                              "\n1. Curso" +
                              "\n2. Professor" +
                              "\n3. Aluno" +
                              "\n4. Avaliação");
            ModificarOpcaoPrincipal = Convert.ToInt32(Console.ReadLine());
        }//fim do metodo

        public void ExecutarMenuPrincipal()
        {
            do
            {
                //Mostrar menu - Chamar o metodo do menu
                MostrarMenu();
                switch (ModificarOpcaoPrincipal)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;// fim de cada caso

                    case 1:
                        Console.WriteLine("Curso");
                        ExecutarCurso();
                        break;
                    case 2:
                        Console.WriteLine("Professor");
                        ExecutarProfessor();
                        break;
                    case 3:
                        Console.WriteLine("Aluno");
                        ExecutarAluno();
                        break;
                    case 4:
                        Console.WriteLine("Avaliação");
                        ExecutarAvaliacao();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }//fim do escolha
            } while (ModificarOpcaoPrincipal != 0);//fim do while
        }//fim do executar

        public void MenuGeral()
        {
            Console.WriteLine("\n\n Escolha uma das ações do CRUD" +
                              "\n0. Voltar ao Menu Anterior" +
                              "\n1. Cadastrar" +
                              "\n2. Consultar" +
                              "\n3. Consultar por código" +
                              "\n4. Atualizar" +
                              "\n5. Excluir");
            ModificarOpcaoGeral = Convert.ToInt32(Console.ReadLine());//Coleta a opção do usuario
        }//fim do metodo

        public void ExecutarCurso()
        {
            do
            {
                Console.WriteLine("\n\nMenu Curso");
                MenuGeral();
                switch (ModificarOpcaoGeral)
                {
                    case 0:
                        Console.WriteLine("Voltar ao menu anterior");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar curso: ");
                        //solicitar os dados
                        Console.WriteLine("Informe o nome do curso: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe à carga horária: ");
                        int cargaHoraria = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o valor: ");
                        double valor = Convert.ToDouble(Console.ReadLine());
                        //criar a estrutura
                        this.controleCurso= new ControlCurso(nome, cargaHoraria, valor);
                        break;
                    case 2:
                        Console.WriteLine("Consultar Curso");
                        this.controleCurso.Imprimir();
                        break;
                    case 3:
                        Console.WriteLine("Consultar curso por código");
                        this.controleCurso.ConsultarPorCodigo();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar curso");
                        this.controleCurso.Atualizar();
                        break;
                    case 5:
                        Console.WriteLine("Excluir curso");
                        this.controleCurso.Excluir();
                        break;
                    default:
                        Console.WriteLine("Codigo informado não é válido!");
                        break;
                }//fim do switch
            } while (ModificarOpcaoGeral != 0);
        }//fim do Curso
        public void ExecutarProfessor()
        {
            do
            {
                Console.WriteLine("\n\nMenu Professor");
                MenuGeral();
                switch (ModificarOpcaoGeral)
                {
                    case 0:
                        Console.WriteLine("Voltar ao menu anterior");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Professor: ");
                        //solicitar os dados
                        Console.WriteLine("Informe o nome do professor: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o idioma: ");
                        string idioma = Console.ReadLine();
                        Console.WriteLine("Informe a formação: ");
                        string formacao = Console.ReadLine();
                        Console.WriteLine("Informe o telefone");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe o codigo do curso");
                        int cursoCodigo = Convert.ToInt32(Console.ReadLine());
                        //criar a estrutura
                        this.controleProfessor = new ControlProfessor(nome, idioma, formacao, telefone, cursoCodigo);
                        break;
                    case 2:
                        Console.WriteLine("Consultar Professor");
                        this.controleProfessor.Imprimir();
                        break;
                    case 3:
                        Console.WriteLine("Consultar professor por código");
                        this.controleProfessor.ConsultarPorCodigo();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar professor");
                        this.controleProfessor.Atualizar();
                        break;
                    case 5:
                        Console.WriteLine("Excluir professor");
                        this.controleProfessor.Excluir();
                        break;
                    default:
                        Console.WriteLine("Codigo informado não é válido!");
                        break;
                }//fim do switch
            } while (ModificarOpcaoGeral != 0);
        }//fim do executar Professor

        public void ExecutarAluno()
        {
            do
            {
                Console.WriteLine("\n\nMenu Aluno");
                MenuGeral();
                switch (ModificarOpcaoGeral)
                {
                    case 0:
                        Console.WriteLine("Voltar ao menu anterior");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Aluno: ");
                        //solicitar os dados
                        Console.WriteLine("Informe o nome do aluno: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe o CPF: ");
                        long CPF = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Informe o email: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Informe o telefone");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe a data de nascimento");
                        DateTime dtDeNasc = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe o codigo do curso");
                        int cursoCodigo = Convert.ToInt32(Console.ReadLine());
                        //criar a estrutura
                        this.controleAluno = new ControlAluno(nome, CPF, email, telefone, dtDeNasc, cursoCodigo);
                        break;
                    case 2:
                        Console.WriteLine("Consultar aluno");
                        this.controleAluno.Imprimir();
                        break;
                    case 3:
                        Console.WriteLine("Consultar aluno por código");
                        this.controleAluno.ConsultarPorCodigo();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar aluno");
                        this.controleAluno.Atualizar();
                        break;
                    case 5:
                        Console.WriteLine("Excluir aluno");
                        this.controleAluno.Excluir();
                        break;
                    default:
                        Console.WriteLine("Codigo informado não é válido!");
                        break;
                }//fim do switch
            } while (ModificarOpcaoGeral != 0);
        }//fim do executar Aluno

        public void ExecutarAvaliacao()
        {
            do
            {
                Console.WriteLine("\n\nMenu Avaliação");
                MenuGeral();
                switch (ModificarOpcaoGeral)
                {
                    case 0:
                        Console.WriteLine("Voltar ao menu anterior");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Avaliação: ");
                        //solicitar os dados
                        Console.WriteLine("Informe a nota do aluno: ");
                        double nota = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a data de avaliação: ");
                        DateTime dataAvaliacao = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Informe a observação");
                        string observacao = Console.ReadLine();
                        Console.WriteLine("Informe o codigo do aluno");
                        int alunoCodigo = Convert.ToInt32(Console.ReadLine());
                        //criar a estrutura
                        this.controleAvaliacao = new ControlAvaliacao(nota, dataAvaliacao, observacao, alunoCodigo);
                        break;
                    case 2:
                        Console.WriteLine("Consultar avaliação");
                        this.controleAvaliacao.Imprimir();
                        break;
                    case 3:
                        Console.WriteLine("Consultar avaliação por código");
                        this.controleAvaliacao.ConsultarPorCodigo();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar avaliação");
                        this.controleAvaliacao.Atualizar();
                        break;
                    case 5:
                        Console.WriteLine("Excluir avaliação");
                        this.controleAvaliacao.Excluir();
                        break;
                    default:
                        Console.WriteLine("Codigo informado não é válido!");
                        break;
                }//fim do switch
            } while (ModificarOpcaoGeral != 0);
        }//fim do executar Avaliacao
    }//fim da classe
}//fim do projeto