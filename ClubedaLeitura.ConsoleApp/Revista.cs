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

