namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Caixa
        {
            public string cor;
            public int numero;
            public string etiqueta;


            public void guardarCaixaemVetor(Caixa[] caixas, Caixa caixa)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (caixas[k] == null)
                    {
                        caixas[k] = caixa;
                        break;
                    }
                }
            }

            public void editarCaixa(Caixa[] caixas, Caixa caixa, int editar)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (k == editar)
                    {
                        caixas[k] = caixa;
                        break;
                    }
                }
            }

            public void excluirCaixa(Caixa[] caixas, Caixa caixa, int excluir)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (k == excluir)
                    {
                        caixas[k] = null;
                        break;
                    }
                }
            }

            public void exibirCaixa(Caixa[] caixas, Caixa caixa)
            {
                for (int k = 0; k < caixas.Length; k++)
                {
                    if (caixas[k] != null)
                    {
                        System.Console.WriteLine("Cor da caixa: " + caixas[k].cor + ", etiqueta da caixa: " + caixas[k].etiqueta + ", numero da caixa: " + caixas[k].numero + ".");
                        System.Console.WriteLine();
                    }
                }
            }


        }


        }
    }

