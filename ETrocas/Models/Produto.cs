using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Models
{
    public abstract class Produto
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Genero { get; set; }
        public string? Foto { get;set; }
        public bool Status { get; set; }

        public abstract string ExibirDados();
        public virtual string ExibirDadosProduto()
        {
            return $"Dados do Produto"
                 + $"\n---------------------------"
                 + $"\nNome: {Nome}"
                 + $"\nDescrição: {Descricao}"
                 + $"\nGenero: {Genero}"
                 + $"\nFoto: {Foto}" 
                 + $"\nStatus: {Status}";
        }

        public virtual string Mensagem() 
        {
            return "Por favor verifique o estado do produto antes de efetuar a troca";
        }
    }
}
