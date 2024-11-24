using AplicationTpDB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MedicoEspecialidadeModel
{
    [Key]
    [Column("Especialidade_ID")]
    public int EspecialidadeID { get; set; }

    [Column("Medico_CRM")]
    [Required]
    public int MedicoCRM { get; set; }

    public MedicoModel Medico { get; set; }
    public EspecialidadeModel Especialidade { get; set; }

    // Chave composta
    public MedicoEspecialidadeModel()
    {
        // Garantir a chave composta entre MedicoCRM e EspecialidadeID
        var key = new { MedicoCRM, EspecialidadeID };
    }
}

