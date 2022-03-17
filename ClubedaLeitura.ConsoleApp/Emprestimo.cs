namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Emprestimo
        {
        public int idAmigo;
        public int nRevista;
        public string dataEmprestimo;
        public string dataDevolucao;

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
            for (int j = 0; j < amigos.Length; j++)
            {
                if (emprestimos[j] != null)
                {
                    System.Console.WriteLine(" Revista emprestada: " + emprestimos[j].nRevista + ", data do emprestimo: " + emprestimos[j].dataEmprestimo + ", data de devolução: " + emprestimos[j].dataDevolucao + ".");
                    System.Console.WriteLine();
                }
            }
        }


        }
    }
    }

