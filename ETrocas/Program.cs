using ETrocas.Models;

namespace ETrocas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Roupa roupa = new Roupa();
           roupa.Categoria = ECategoriaRoupa.Jeans;

            Console.WriteLine("Selecione o tipo da Roupa a ser trocada: "
                             + "\n1 - Jeans\n2 - Vestidos\n3 - Blusas" );

            int opcao = Convert.ToInt32( Console.ReadLine() );
            if (opcao == 1) 
            {
                roupa.Categoria = ECategoriaRoupa.Jeans;
            }
            else if (opcao == 2)
            {
                roupa.Categoria = ECategoriaRoupa.Vestidos;
            }
            else if (opcao == 3)
            {
                roupa.Categoria = ECategoriaRoupa.Blusas;
            }

            Console.WriteLine(roupa.Categoria );
        }
    }
}
