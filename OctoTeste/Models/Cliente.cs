using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OctoTeste.Models
{
    public class Cliente : Entity
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string dataNascimento { get; set; }
        public string Telefone { get; set; }
        public string tipoTelefone { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string tipoEndereco { get; set; }
        public int Numero { get; set; }
    }
}
