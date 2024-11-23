using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("pessoa_telefone")]
    public class PessoaTelefoneModel
    {
        [Key]
        public string CPF { get; set; }

        [Required]
        public string NumeroTelefone { get; set; }
    }
}
