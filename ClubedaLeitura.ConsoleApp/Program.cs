using System;

namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
       static Revista[] revistas = new Revista[100000];
       static Caixa[] caixas = new Caixa[100000];
       static CadastroAmigo[] amigos = new CadastroAmigo[100000];
       static Emprestimo[] emprestimos = new Emprestimo[100000];

        static void Main(string[] args)
        {
            int resposta;
            bool chamarMenu;
            char continuar;


            do
            {
                #region menu
                do
                {
                    Console.WriteLine();
                    Console.Write("1 - adicionar revista");

                    Console.WriteLine("2 - Adicionar caixa");

                    Console.WriteLine("3 - Cadastrar amigo");

                    Console.WriteLine("4 - Fazer um emprestimo");
                    resposta = Convert.ToInt32(Console.ReadLine());

                } while (resposta != 1 && resposta != 2 && resposta != 3 && resposta != 4);
                #endregion

                #region Revista
                Revista revista = new Revista();
                Console.Write("Digite o tipo da coleçaõ: ");
                revista.tipoColecao = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o numero da edição da revista: ");
                revista.nEdicao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite o ano da revista: ");
                revista.ano = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o numero da caixa revista: ");
                revista.nCaixa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i] == null)
                    {
                        revistas[i] = revista;
                        break;
                    }
                }

                #endregion

                #region Caixa
                Caixa caixa = new Caixa();
                Console.Write("Digite a cor da caixa: ");
                caixa.cor = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o núemro da caixa: ");
                caixa.numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite a etiqueta da caixa: ");
                caixa.etiqueta = Console.ReadLine();

                Console.WriteLine();

                for (int k = 0; k < caixas.Length; k++)
                {
                    if (caixas[k] == null)
                    {
                        caixas[k] = caixa;
                        break;
                    }
                }
                #endregion

                #region Cadastro do Amigo
                CadastroAmigo amigo = new CadastroAmigo();

                Console.Write("Digite o nome do amigo: ");
                amigo.nomeDoAmigo = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o nome do responsávl do amigo: ");
                amigo.nomeResponsavel = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o telefone do amigo: ");
                amigo.telefone = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o endereço: ");
                amigo.endereco = Console.ReadLine();

                Console.WriteLine();

                for (int l = 0; l < amigos.Length; l++)
                {
                    if (amigos[l] == null)
                    {
                        amigos[l] = amigo;
                        break;
                    }
                }

                #endregion

                #region Emprestimo
                Emprestimo emprestimo = new Emprestimo();
                Console.Write("Digite o nome do aluno que está emprestando a revista: ");
                emprestimo.nomeAmigo = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o número da revista a ser emprestada: ");
                emprestimo.nRevista = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite a data de emprestimo: ");
                emprestimo.dataEmprestimo = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a data de devolução: ");
                emprestimo.dataDevolucao = Console.ReadLine();

                Console.WriteLine();

                for (int j = 0; j < emprestimos.Length; j++)
                {
                    if (emprestimos[j] == null)
                    {
                        emprestimos[j] = emprestimo;
                        break;
                    }
                }

                #endregion

                do
                {
                    Console.Write("Deseja chamar o menu novamente? Digite S para sim e N para não: ");
                    continuar = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                } while (continuar != 'S' && continuar != 'N');

                chamarMenu = continuar == 'S';
            }while(chamarMenu == true);
        }
    }
}
