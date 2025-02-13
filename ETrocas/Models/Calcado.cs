using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models
{
    public class Calcado: Produto
    {
        public string? Material{ get; set; }
        public TamanhoCalcadosEnum Tamanho{ get; set; }
        public ECategoriaCalcados Categoria { get; set; }
        public TipoAjusteEnum TipoAjuste { get; set; }

        public override string ExibirDados()
        {
            return $"Dados do Calçado"
                 + $"\n---------------------------"
                 + $"\nNome: {Nome}"
                 + $"\nDescrição: {Descricao}"
                 + $"\nGenero: {Genero}"
                 + $"\nFoto: {Foto}"
                 + $"\nStatus: {Status}"
                 + $"\nMaterial: {Material}"
                 + $"\nTamanho: {Tamanho}"
                 + $"\nCategoria: {Categoria}"
                 + $"\nTipoAjuste: {TipoAjuste}";
        }

        public override string ExibirDadosProduto()
        {
            string mensagem = base.ExibirDadosProduto();
            return mensagem = $"Dados do Calçado"
                            + $"\n---------------------------"
                            + $"\nNome: {Nome}"
                            + $"\nDescrição: {Descricao}"
                            + $"\nGenero: {Genero}"
                            + $"\nFoto: {Foto}"
                            + $"\nStatus: {Status}"
                            + $"\nMaterial: {Material}"
                            + $"\nTamanho: {Tamanho}"
                            + $"\nCategoria: {Categoria}"
                            + $"\nTipoAjuste: {TipoAjuste}";
        }


    }
}
