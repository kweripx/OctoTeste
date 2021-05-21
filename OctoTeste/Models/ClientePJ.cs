using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OctoTeste.Models
{
    public class ClientePJ : Entity
    {
        [Required]
        public string Nome { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        [DisplayName("Data de Nascimento")]
        public string dataNascimento { get; set; }
        [Required]
        public string Telefone { get; set; }
        [DisplayName("Tipo de Telefone")]
        public string tipoTelefone { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }
        [Required]
        public string Endereco { get; set; }
        [DisplayName("Tipo de Cobrança")]
        public string tipoEndereco { get; set; }
        public int Numero { get; set; }
    }
}
