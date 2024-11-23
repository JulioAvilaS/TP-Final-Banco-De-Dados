using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("pessoa_email")]
    public class PessoaEmailModel
    {
        [Key]
        public string CPF { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
