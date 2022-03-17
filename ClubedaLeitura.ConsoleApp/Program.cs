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
            static void lerRevista(ref Revista revista, Caixa[] caixas)
            {
                Console.Write("Digite o nome da revista: ");
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

                Console.WriteLine("Opções de caixa: ");
                for(int i = 0; i < caixas.Length; i++)
                {
                    if (caixas[i] != null)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine();

                Console.Write("Digite o numero da caixa revista: ");
                revista.nCaixa = Convert.ToInt32(Console.ReadLine());

                Caixa.addRevistaNaCaixa(caixas, revista, revista.nCaixa);
                revista.disponivel = true;
            }
            static void lerCaixa(ref Caixa caixa)
            {
                Console.Write("Digite a cor da caixa: ");
                caixa.cor = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o número da caixa: ");
                caixa.numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite a etiqueta da caixa: ");
                caixa.etiqueta = Console.ReadLine();
            }
            static void cadastrarAmigos(ref CadastroAmigo amigo)
            {
                Console.Write("Digite o nome do amigo: ");
                amigo.nomeDoAmigo = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o nome do responsável do amigo: ");
                amigo.nomeResponsavel = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o telefone do amigo: ");
                amigo.telefone = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite o endereço: ");
                amigo.endereco = Console.ReadLine();

                Console.WriteLine();

            }
            static void lerEmprestimo(ref Emprestimo emprestimo, Revista[] revistas, CadastroAmigo[] amigos)
            {
                Console.WriteLine();

                Console.WriteLine("Opções de Id de amigo: ");

                for (int i = 0; i < amigos.Length; i++)
                {
                    if (amigos[i] != null)
                    {
                        Console.WriteLine(i + " - " + amigos[i].nomeDoAmigo);
                    }
                }

                Console.WriteLine();
                Console.Write("Digite o id do amigo que está emprestando a revista: ");
                emprestimo.idAmigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Opções de ID de revista: ");
                for(int i = 0;i < revistas.Length; i++)
                {
                    if(revistas[i] != null)
                    {
                        Console.WriteLine(i + " - " + revistas[i].nomeRevista);
                    }
                }

                Console.WriteLine();

                do {
                    Console.Write("Digite o id da revista a ser emprestada: ");
                    emprestimo.nRevista = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }while(revistas[emprestimo.nRevista].disponivel == false);

                Revista.indisponibilizarRevista(emprestimo.nRevista, revistas);

                Console.WriteLine();

                Console.Write("Digite a data de emprestimo: ");
                emprestimo.dataEmprestimo = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a data de devolução: ");
                emprestimo.dataDevolucao = Console.ReadLine();
            }

        string resposta;
        bool chamarMenu;
        char continuar;
        string excluirOuEditar;
        int excluir, editar;
        do
        {
            #region menu
            do
            {
                Console.WriteLine();
                Console.WriteLine("Digite a resposta de acordo com o cmomando que deseja executar!");
                Console.WriteLine("1 - Adicionar caixa");
                Console.WriteLine("2 - Adicionar revista");
                Console.WriteLine("3 - Cadastrar amigo");
                Console.WriteLine("4 - Fazer um emprestimo");
                Console.WriteLine("5 - Exibir as revistas");
                Console.WriteLine("6 - Exibir as caixas");
                Console.WriteLine("7 - Exibir os amigos");
                Console.WriteLine("8 - Exibir os emprestimos");
                Console.WriteLine("9 - Editar ou excluir uma revista");
                Console.WriteLine("10 - Editar ou excluir uma caixa");
                Console.WriteLine("11 - Editar ou excluir um amigo");
                Console.WriteLine("12 - Editar ou excluir um emprestimo");

                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                Console.WriteLine();
            } while (resposta != "1" && resposta != "2" && resposta != "3" && resposta != "4" && resposta != "5" && resposta != "6" && resposta != "7" && resposta != "8" && resposta != "9" && resposta != "10" && resposta != "11" && resposta != "12");
            #endregion

            Revista revista = new Revista();
            Caixa caixa = new Caixa();
            CadastroAmigo amigo = new CadastroAmigo();
            Emprestimo emprestimo = new Emprestimo();

            switch (resposta)
            {
                case "1":
                    #region Caixa
                        lerCaixa(ref caixa);
                        caixa.guardarCaixaemVetor(caixas, caixa);
                        Console.WriteLine();

                        #endregion
                 
                   break;

                case "2":
                     #region Revista
                        lerRevista(ref revista, caixas);
                        revista.AdicionarRevistaAoVetor(revistas, revista);
                        Console.WriteLine();
                        #endregion

                        break;

                case "3":
                    #region Cadastro do Amigo

                    cadastrarAmigos(ref amigo);

                    amigo.VetorDeAmigos(amigos, amigo);
                    Console.WriteLine();

                    #endregion

                    break;

                case "4":
                    #region Emprestimo
                    lerEmprestimo(ref emprestimo, revistas, amigos);

                    emprestimo.VetorDeEmprestimos(emprestimos, emprestimo);
                    

                    Console.WriteLine();

                    #endregion
                    break;

                case "5":
                    revista.exibir(revistas, revista);
                    break;

                case "6":
                    caixa.exibirCaixa(caixas, caixa);
                    break;

                case "7":
                    amigo.exibirAmigos(amigos, amigo);
                    break;

                case "8":
                    emprestimo.exibirEmprestimos(emprestimos, emprestimo);
                    break;

                case "9":
                        #region Excluir ou editar Revista
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");
                
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição da revista que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerRevista(ref revista, caixas);

                        revista.editarRevista(revistas, revista, editar);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição da revista que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            revista.excluirRevista(revistas, revista, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case "10":
                        #region Excluir ou editar Caixa
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");
           
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição da caixa que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerCaixa(ref caixa);

                        caixa.editarCaixa(caixas, caixa, editar);

                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição da caixa que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            caixa.excluirCaixa(caixas, caixa, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case "11":
                        #region Excluir ou editar Amigo
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição do cadastro do amigo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        cadastrarAmigos(ref amigo);

                        amigo.editarCadastro(amigos, amigo, editar);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição do cadastro do amigo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            amigo.excluirCadastro(amigos, amigo, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case "12":
                        #region Excluir ou editar Emprestimo
                    do
                    {
                        Console.Write("Digite E para editar ou EX para excluir: ");
                        excluirOuEditar = Console.ReadLine();
                        Console.WriteLine();
                    } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite a posição do emprestimo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerEmprestimo(ref emprestimo, revistas, amigos);
                        Console.WriteLine();

                        emprestimo.editarEmprestimo(emprestimos, emprestimo, editar);
                        Console.WriteLine();

                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite a posição do emprestimo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            Revista.disponibilizarRevista(emprestimo.nRevista, revistas);
                            emprestimo.excluirEmprestimo(emprestimos, emprestimo, excluir);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;
            }

                #region Chamar menu novamente
                do
                {
                Console.Write("Deseja chamar o menu novamente? Digite S para sim e N para não: ");
                continuar = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
            } while (continuar != 'S' && continuar != 'N');

            chamarMenu = continuar == 'S';
                #endregion
            } while (chamarMenu == true);
        }
    }
}
