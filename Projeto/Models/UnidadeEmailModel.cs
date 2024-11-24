using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("unidade_email")]
    public class UnidadeEmailModel
    {
        [Key]
        [Column("Unidade_Medica_CNPJ")]
        public string UnidadeMedicaCNPJ { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Descricao { get; set; }  

    }
}
