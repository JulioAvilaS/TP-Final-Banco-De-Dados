using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("especialidade")]
    public class EspecialidadeModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        public ICollection<MedicoEspecialidadeModel> MedicoEspecialidades { get; set; }
    }
}
