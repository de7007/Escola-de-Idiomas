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
        private int opcaoPrincipal;
        private int opcaoGeral;

        public ControlMenu()
        {
            controleCurso = new ControlCurso();
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
        }
    }
}