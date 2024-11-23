using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("medico")]
    public class MedicoModel
    {

        [Key]
        public int CRM { get; set; }

        [Column("Pessoa_CPF")]
        public string PessoaCPF { get; set; }

        [Required]
        public string Status { get; set; }

        [Column("Data_Admissao")]
        public DateTime DataAdmissao { get; set; }


        public PessoaModel Pessoa { get; set; }
        public ICollection<EspecialidadeModel> Especialidades { get; set; }

    }
}
