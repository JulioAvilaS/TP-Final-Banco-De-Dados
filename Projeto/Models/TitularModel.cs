using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("titular")]
    public class TitularModel
    {
        [Key] 
        public int CodIdentificacao { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        [Column("Plano_ID")]
        public int PlanoID { get; set; }
    }
}
