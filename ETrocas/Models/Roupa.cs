using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models
{
    public class Roupa: Produto
    {
        public string? Material { get; set; }
        public ECategoriaRoupa Categoria {  get; set; }
        public TamanhoRoupaEnum Tamanho { get; set; }
        public EComprimentoRoupa Comprimento { get; set; }
             

        public override string ExibirDados()
        {
            return $"{ExibirDadosProduto()}"
                 + $"\nMaterial: {Material}"
                 + $"\nCategoria: {Categoria}"
                 + $"\nTamanho: {Tamanho}"
                 + $"\nComprimento: {Comprimento}";
        }

        public override string Mensagem()
        {
            return base.Mensagem() + "\nRoupas furadas, rasgadas e manchadas não serão aceitas.";
        }
    }
}
