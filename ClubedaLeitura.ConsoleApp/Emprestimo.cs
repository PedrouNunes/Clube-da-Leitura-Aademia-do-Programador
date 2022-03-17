namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Emprestimo
        {
        public string nomeAmigo;
        public int idAmigo;
        public int nRevista;
        public string dataEmprestimo;
        public string dataDevolucao;
        public int contador = 0;
        private string[] posicoesNaoNulas = new string[10000];

        public void VetorDeEmprestimos(Emprestimo[] emprestimos, Emprestimo emprestimo)
        {
            for (int j = 0; j < amigos.Length; j++)
            {
                if (emprestimos[j] == null)
                {
                    emprestimos[j] = emprestimo;
                    break;
                }
            }
        }


        public void editarEmprestimo(Emprestimo[] emprestimos, Emprestimo emprestimo, int editar)
        {
            for (int j = 0; j < emprestimos.Length; j++)
            {
                if (j == editar)
                {
                    emprestimos[j] = emprestimo;
                    break;
                }
            }
        }

        public void excluirEmprestimo(Emprestimo[] emprestimos, Emprestimo emprestimo, int excluir)
        {
            for (int j = 0; j < emprestimos.Length; j++)
            {
                if (j == excluir)
                {
                    emprestimos[j] = null;
                        break;
                }
            }
        }


        public void exibirEmprestimos(Emprestimo[] emprestimos, Emprestimo emprestimo)
        {
            for (int j = 0; j < emprestimos.Length; j++)
            {
                if (emprestimos[j] != null)
                {
                    System.Console.WriteLine("Amigo que emprestou: " + emprestimos[j].nomeAmigo + ", revista emprestada: " + emprestimos[j].nRevista);
                    System.Console.WriteLine("Data do emprestimo: " + emprestimos[j].dataEmprestimo + ", data de devolução: " + emprestimos[j].dataDevolucao + ".");
                    System.Console.WriteLine();
                }
            }
        }


        }
    }
    }

