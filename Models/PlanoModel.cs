using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("plano")]
    public class PlanoModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Column("Valor_Mensalidade")]
        public float ValorMensalidade { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [Column("Limite_Dependentes")]
        public int LimiteDependentes { get; set; }

    }
}
