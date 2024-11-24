using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("unidade_telefone")]
    public class UnidadeTelefoneModel
    {
        [Key]
        [Column("Unidade_Medica_CNPJ")]
        public string UnidadeMedicaCNPJ { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Descrição { get; set; }

    }
}
