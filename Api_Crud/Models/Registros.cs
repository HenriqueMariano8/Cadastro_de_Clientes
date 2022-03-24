using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Crud.Models
{
    public class Registros
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public List<string> TipoDeTelefone { get; set; }
        public List<string> Telefone { get; set; }
        public List<string> Endereco { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Instagran { get; set; }

    }
}