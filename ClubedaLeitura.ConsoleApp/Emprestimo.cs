namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Emprestimo
        {
            public string nomeAmigo;
            public string nRevista;
            public string dataEmprestimo;
            public string dataDevolucao;

            public void VetorDeEmprestimos(Emprestimo[] emprestimos, Emprestimo emprestimo)
            {
                for (int j = 0; j < emprestimos.Length; j++)
                {
                    if (emprestimos[j] == null)
                    {
                        emprestimos[j] = emprestimo;
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

