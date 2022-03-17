namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class CadastroAmigo
        {
            public string nomeDoAmigo;
            public string nomeResponsavel;
            public string telefone;
            public string endereco;
            public bool jaEmprestou;

            public void VetorDeAmigos(CadastroAmigo[] amigos, CadastroAmigo amigo)
            {
                for (int l = 0; l < amigos.Length; l++)
                {
                    if (amigos[l] == null)
                    {
                        amigos[l] = amigo;
                        break;
                    }
                }
            }


            public void editarCadastro(CadastroAmigo[] amigos, CadastroAmigo amigo, int editar)
            {
                for (int i = 0; i < amigos.Length; i++)
                {
                    if (i == editar)
                    {
                        amigos[i] = amigo;
                        break;
                    }
                }
            }

            public void excluirCadastro(CadastroAmigo[] amigos, CadastroAmigo amigo, int excluir)
            {
                for (int i = 0; i < amigos.Length; i++)
                {
                    if (i == excluir)
                    {
                        amigos[i] = null;
                        break;
                    }
                }
            }


            public void exibirAmigos(CadastroAmigo[] amigos, CadastroAmigo amigo)
            {
                for (int l = 0; l < amigos.Length; l++)
                {
                    if (amigos[l] != null)
                    {
                        System.Console.WriteLine("Amigo: " + amigos[l].nomeDoAmigo + ", nome do responsável: " + amigos[l].nomeResponsavel + ".");
                        System.Console.WriteLine("Endereço: " + amigos[l].endereco + ", telefone: " + amigos[l].telefone + ".");
                        System.Console.WriteLine();
                    }
                }

            }

        }
    }

 }
    

