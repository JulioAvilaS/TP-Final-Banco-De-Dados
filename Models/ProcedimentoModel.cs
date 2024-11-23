using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("procedimento")]
    public class ProcedimentoModel
    {
        [Key] 
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public float Valor { get; set; }

        [Required]
        public string Descrição { get; set; }
    }
}
