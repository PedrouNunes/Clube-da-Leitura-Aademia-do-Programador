namespace ClubedaLeitura.ConsoleApp
{
    internal partial class Program
    {
        public class Categoria
        {
            public string nomeCategoria;
            public int qntDiasEmprestimos;
            public Revista[] revistasCategorias;

            public void CategoriaVetor(Categoria[] categorias, Categoria categoria)
            {
                for (int i = 0; i < categorias.Length; i++)
                {
                    if (categorias[i] == null)
                    {
                        categorias[i] = categoria;
                        break;
                    }
                }
            }

            public static void addRevistaNaCategoria(Categoria[] categorias, Revista revista, int id)
            {
                for (int k = 0; k < categorias[id].revistasCategorias.Length; k++)
                {
                    if (categorias[id].revistasCategorias[k] == null)
                    {
                        categorias[id].revistasCategorias[k] = revista;
                        break;
                    }
                }
            }

            public void editarCategoria(Categoria[] categorias, Categoria categoria, int editar)
            {
                for (int k = 0; k < categorias.Length; k++)
                {
                    if (k == editar)
                    {
                        categorias[k] = categoria;
                        break;
                    }
                }
            }

            public void excluirCategoria(Categoria[] categorias, int excluir)
            {
                for (int k = 0; k < categorias.Length; k++)
                {
                    if (k == excluir)
                    {
                        categorias[k] = null;
                        break;
                    }
                }
            }
        }

    }
}