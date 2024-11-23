using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("medico_especialidade")]
    public class MedicoEspecialidadeModel
    {
        [Key]
        [Column("Especialidade_ID")]
        public int EspecialidadeID { get; set; }

        [Column("Medico_CRM")]
        [Required]
        public int MedicoCRM { get; set; }  

    }
}
