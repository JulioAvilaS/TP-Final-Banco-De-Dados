using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("cobertura_plano")]
    public class CoberturaPlanoModel
    {
        [Key]
        [Column("Plano_ID")]
        public int PlanoID { get; set; }

        [Column("Especialidade_ID")]
        public int EspecialidadeID { get; set; }
    }
}
