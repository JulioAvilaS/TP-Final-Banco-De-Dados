using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicationTpDB.Models
{
    [Table("consulta")]
    public class ConsultaModel
    {
        [Key] 
        public int ID { get; set; }

        [Column("Medico_CRM")]
        public int MedicoCRM { get; set; }

        [Column("Titular_Cod_Identificacao")]
        public int TitularCodIdentificacao { get; set; }

        [Column("Procedimento_ID")]
        public int ProcedimentoID { get; set; }

        [Column("CPF_Paciente")]
        public string CPFPaciente { get; set; }

        [Column("Unidade_Medica_CNPJ")]
        public string UnidadeMedicaCNPJ { get; set; }

        [Required]
        public string Sala { get; set; }

        [Required]
        public string Andar { get; set; }

        [Required]
        public string Bloco { get; set; }

        [Required]
        [Column("Prédio")]
        public string Predio { get; set; }

        [Required]
        [Column("Tempo_Estimado")]
        public int TempoEstimado { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public float Valor { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        public DateTime Agendamento { get; set; }


    }
}
