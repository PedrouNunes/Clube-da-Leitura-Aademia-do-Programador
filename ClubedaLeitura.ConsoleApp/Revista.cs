namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Revista
        {
            public string tipoColecao;
            public int nEdicao;
            public string ano;
            public int nCaixa;
            public string nomeRevista;
            public bool disponivel;

            public void AdicionarRevistaAoVetor(Revista[] revistas, Revista revista)
            {
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i] == null)
                    {
                        revistas[i] = revista;
                        break;
                    }
                }
            }

            public static void indisponibilizarRevista(int id, Revista[] revistas)
            {
                revistas[id].disponivel = false;
            }

            public static void disponibilizarRevista(int id, Revista[] revistas)
            {
                revistas[id].disponivel = true;
            }

            public void editarRevista(Revista[] revistas, Revista revista, int editar)
            {
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (i == editar)
                    {
                        revistas[i] = revista;
                        break;
                    }
                }
            }

            public void excluirRevista(Revista[] revistas, Revista revista, int excluir)
            {
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (i == excluir)
                    {
                        revistas[i] = null;
                        break;
                    }
                }
            }

            public void exibir(Revista[] revistas, Revista revista)
            {
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i] != null)
                    {
                        System.Console.WriteLine("Nome da revista: " + revistas[i].nomeRevista);
                        System.Console.WriteLine("Tipo de coleção: " + revistas[i].tipoColecao + ", numero da edição: " + revistas[i].nEdicao);
                        System.Console.WriteLine("Ano da revista: " + revistas[i].ano + ", caixa em que está guardada: " + revistas[i].nCaixa);
                        System.Console.WriteLine();
                    }
                }
            }
        }


        }
    }

