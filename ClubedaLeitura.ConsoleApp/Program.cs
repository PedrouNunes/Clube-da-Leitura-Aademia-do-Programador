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
                    Console.WriteLine("Digite a resposta de acordo com o cmomando que deseja executar!");
                    Console.WriteLine("1 - Adicionar revista");
                    Console.WriteLine("2 - Adicionar caixa");
                    Console.WriteLine("3 - Cadastrar amigo");
                    Console.WriteLine("4 - Fazer um emprestimo");
                    Console.WriteLine("5 - Exibir as revistas");
                    Console.WriteLine("6 - Exibir as caixas");


                    Console.Write("Resposta: ");
                    resposta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                } while (resposta != 1 && resposta != 2 && resposta != 3 && resposta != 4);
                #endregion

                Revista revista = new Revista();
                Caixa caixa = new Caixa();
                CadastroAmigo amigo = new CadastroAmigo();
                Emprestimo emprestimo = new Emprestimo();

                switch (resposta)
                {
                    case 1:
                        #region Revista
                        Console.Write("Digite o nome da revista");
                        revista.nomeRevista = Console.ReadLine();

                        Console.WriteLine();

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

                        revista.AdicionarRevistaAoVetor(revistas, revista);
                        Console.WriteLine();
                        #endregion
                        break;

                    case 2:
                        #region Caixa
                        Console.Write("Digite a cor da caixa: ");
                        caixa.cor = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite o núemro da caixa: ");
                        caixa.numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Digite a etiqueta da caixa: ");
                        caixa.etiqueta = Console.ReadLine();

                        Console.WriteLine();

                        #endregion

                        break;

                    case 3:
                        #region Cadastro do Amigo

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

                        #endregion

                        break;

                    case 4:
                        #region Emprestimo
                        Console.Write("Digite o nome do aluno que está emprestando a revista: ");
                        emprestimo.nomeAmigo = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite o número da revista a ser emprestada: ");
                        emprestimo.nRevista = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite a data de emprestimo: ");
                        emprestimo.dataEmprestimo = Console.ReadLine();

                        Console.WriteLine();

                        Console.Write("Digite a data de devolução: ");
                        emprestimo.dataDevolucao = Console.ReadLine();

                        Console.WriteLine();

                        #endregion
                        break;

                    case 5: revista.exibir(revistas, revista);
                        break;

                    case 6: caixa.exibirCaixa(caixas, caixa);
                        break;

                    case 7: amigo.exibirAmigos(amigos, amigo);
                        break;

                    case 8: emprestimo.exibirEmprestimos(emprestimos, emprestimo);
                        break;
                }


              

                revista.exibir(revistas, revista);

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
