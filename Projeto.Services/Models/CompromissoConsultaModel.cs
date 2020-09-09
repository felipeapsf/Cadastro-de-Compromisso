using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services.Models
{
    public class CompromissoConsultaModel
    {
        public int IdCompromisso { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
    }
}
