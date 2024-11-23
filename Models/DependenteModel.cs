using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("dependente")]
    public class DependenteModel
    {
        [Key]
        public string CPF { get; set; }

        [Column("Titular_Cod_Identificacao")]
        [Required]
        public int TitularCodIdentificacao { get; set; }

    }
}
