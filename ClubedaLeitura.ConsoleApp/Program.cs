using System;

namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
       static Revista[] revistas = new Revista[100000];
       static Caixa[] caixas = new Caixa[100000];
       static CadastroAmigo[] amigos = new CadastroAmigo[100000];
       static Emprestimo[] emprestimos = new Emprestimo[100000];
       static Categoria[] categorias = new Categoria[100000];

        static void Main(string[] args)
        {
            static void comprovarAcao(string mensagem, ConsoleColor cor)
            {
                Console.ForegroundColor = cor;
                Console.WriteLine(mensagem);
                Console.ResetColor();
            }
            static void lerRevista(ref Revista revista, Caixa[] caixas, Categoria[] categorias)
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

                Console.Write("Digite o ID da caixa da revista: ");
                revista.nCaixa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Digite o ID da categoria da revista: ");
                revista.nCategoria = Convert.ToInt32(Console.ReadLine());

                Categoria.addRevistaNaCategoria(categorias, revista, revista.nCategoria);

                Caixa.addRevistaNaCaixa(caixas, revista, revista.nCaixa);
                revista.disponivel = true;

                Console.WriteLine();
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

                Console.WriteLine();
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
                    Console.Write("Digite o ID da revista a ser emprestada: ");
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

                Console.WriteLine();
            }
            static void lerCategoria(ref Categoria categoria)
            {
                Console.Write("Digite o nome da categoria: ");
                categoria.nomeCategoria = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Digite a quantidade de dias do empréstimo: ");
                categoria.qntDiasEmprestimos = Convert.ToInt32(Console.Read());

                Console.WriteLine();
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
                Console.WriteLine("0 - Adicionar Categoria");
                Console.WriteLine("1 - Adicionar caixa");
                Console.WriteLine("2 - Adicionar revista");
                Console.WriteLine("3 - Cadastrar amigo");
                Console.WriteLine("4 - Fazer um empréstimo");
                Console.WriteLine("5 - Exibir as revistas");
                Console.WriteLine("6 - Exibir as caixas");
                Console.WriteLine("7 - Exibir os amigos");
                Console.WriteLine("8 - Exibir os empréstimos");
                Console.WriteLine("9 - Editar ou excluir uma revista");
                Console.WriteLine("10 - Editar ou excluir uma caixa");
                Console.WriteLine("11 - Editar ou excluir um amigo");
                Console.WriteLine("12 - Editar ou excluir um empréstimo");

                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                Console.WriteLine();
            } while (resposta != "0" && resposta != "1" && resposta != "2" && resposta != "3" && resposta != "4" && resposta != "5" && resposta != "6" && resposta != "7" && resposta != "8" && resposta != "9" && resposta != "10" && resposta != "11" && resposta != "12" && resposta != "13");
                #endregion

                #region Declaração de Objetos
                Revista revista = new Revista();
            Caixa caixa = new Caixa();
            CadastroAmigo amigo = new CadastroAmigo();
            Emprestimo emprestimo = new Emprestimo();
            Categoria categoria = new Categoria();
                #endregion

                switch (resposta)
            {
                case "0":
                        #region Categoria
                        lerCategoria(ref categoria);
                        categoria.CategoriaVetor(categorias, categoria);

                        break;
                        #endregion

                    case "1":
                    #region Caixa
                        lerCaixa(ref caixa);
                        caixa.guardarCaixaemVetor(caixas, caixa);
                        comprovarAcao("Caixa adicionada! ", ConsoleColor.Green);
                        Console.WriteLine();                                
                   break;
                    #endregion

                    case "2":
                     #region Revista
                        lerRevista(ref revista, caixas, categorias);
                        revista.AdicionarRevistaAoVetor(revistas, revista);
                        comprovarAcao("Revista adicionada! ", ConsoleColor.Green);
                        Console.WriteLine();                  
                        break;
                    #endregion

                    case "3":
                    #region Cadastro do Amigo

                    cadastrarAmigos(ref amigo);

                    amigo.VetorDeAmigos(amigos, amigo);
                    comprovarAcao("Cadastro adicionado! ", ConsoleColor.Green);
                    Console.WriteLine();                
                    break;
                    #endregion

                    case "4":
                    #region Emprestimo
                    lerEmprestimo(ref emprestimo, revistas, amigos);

                    emprestimo.VetorDeEmprestimos(emprestimos, emprestimo);
                    comprovarAcao("Emprestimo Realizado! ", ConsoleColor.Green);
                    Console.WriteLine();                  
                    break;
                    #endregion

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

                        Console.WriteLine("Opções de ID de revista: ");
                        for (int i = 0; i < revistas.Length; i++)
                        {
                            if (revistas[i] != null)
                            {
                                Console.WriteLine(i + " - " + revistas[i].nomeRevista);
                            }
                        }

                        Console.WriteLine();
                        if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite o ID da revista que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerRevista(ref revista, caixas, categorias);

                        revista.editarRevista(revistas, revista, editar);
                        comprovarAcao("Revista editada! ", ConsoleColor.Blue);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite o ID da revista que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            revista.excluirRevista(revistas, revista, excluir);
                            comprovarAcao("Revista excluida! ", ConsoleColor.Red);
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

                    Console.WriteLine("Opções de caixa: ");
                    for (int i = 0; i < caixas.Length; i++)
                    {
                        if (caixas[i] != null)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine();

                        if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite o ID da caixa que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerCaixa(ref caixa);

                        caixa.editarCaixa(caixas, caixa, editar);
                        comprovarAcao("Caixa editada! ", ConsoleColor.Blue);

                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite o ID da caixa que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            caixa.excluirCaixa(caixas, caixa, excluir);
                            comprovarAcao("Caixa excluida! ", ConsoleColor.Red);
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

                    Console.WriteLine("Opções de Id de amigo: ");

                    for (int i = 0; i < amigos.Length; i++)
                    {
                        if (amigos[i] != null)
                        {
                            Console.WriteLine(i + " - " + amigos[i].nomeDoAmigo);
                        }
                    }

                        Console.WriteLine();

                        if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite o ID do cadastro do amigo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        cadastrarAmigos(ref amigo);

                        amigo.editarCadastro(amigos, amigo, editar);
                        comprovarAcao("Cadastro editado! ", ConsoleColor.Blue);
                        Console.WriteLine();
                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite o ID do cadastro do amigo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            amigo.excluirCadastro(amigos, amigo, excluir);
                            comprovarAcao("Amigo excluido! ", ConsoleColor.Red);
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

                    Console.WriteLine("Opções de emprestimo: ");

                        for(int i = 0; i < emprestimos.Length; i++)
                        {
                            if(emprestimos[i] != null)
                            {
                                Console.WriteLine(i);
                            }
                        }

                        Console.WriteLine();
                    if (excluirOuEditar == "E")
                    {
                        Console.Write("Digite o ID do emprestimo que deseja editar: ");
                        editar = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        lerEmprestimo(ref emprestimo, revistas, amigos);
                        Console.WriteLine();

                        emprestimo.editarEmprestimo(emprestimos, emprestimo, editar);
                        comprovarAcao("Emprestimo editado! ", ConsoleColor.Blue);
                        Console.WriteLine();

                    }
                    else
                    {
                        if (excluirOuEditar == "EX")
                        {
                            Console.Write("Digite o ID do emprestimo que deseja excluir: ");
                            excluir = Convert.ToInt32(Console.ReadLine());

                            Revista.disponibilizarRevista(emprestimo.nRevista, revistas);
                            emprestimo.excluirEmprestimo(emprestimos, emprestimo, excluir);
                            comprovarAcao("Emprestimo excluido! ", ConsoleColor.Red);
                            Console.WriteLine();
                        }
                    }
                    #endregion
                    break;

                case "13":
                        #region Excluir ou editar categoria
                        do
                        {
                            Console.Write("Digite E para editar ou EX para excluir: ");
                            excluirOuEditar = Console.ReadLine();
                            Console.WriteLine();
                        } while (excluirOuEditar != "E" && excluirOuEditar != "EX");

                        Console.WriteLine("Opções de ID de categoria: ");

                        for (int i = 0; i > categorias.Length; i++)
                        {
                            if (categorias[i] != null)
                            {
                                Console.WriteLine(i + " - " + categorias[i].nomeCategoria);
                            }
                        }
                        
                        if (excluirOuEditar == "E")
                        {
                            Console.Write("Digite o ID da categoria que deseja editar: ");
                            editar = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine();

                            lerCategoria(ref categoria);
                            Console.WriteLine();

                            categoria.editarCategoria(categorias, categoria, editar);
                            comprovarAcao("Categoria editada! ", ConsoleColor.Blue);
                            Console.WriteLine();
                        }
                        else
                        {
                            if (excluirOuEditar == "EX")
                            {
                                Console.Write("Digite o ID da Categoria que deseja excluir: ");
                                excluir = Convert.ToInt32(Console.ReadLine());

                                Revista.disponibilizarRevista(emprestimo.nRevista, revistas);
                                categoria.excluirCategoria(categorias, excluir);
                                comprovarAcao("Categoria excluida! ", ConsoleColor.Red);
                                Console.WriteLine();
                            }
                        }
                 
                        break;
                        #endregion
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
