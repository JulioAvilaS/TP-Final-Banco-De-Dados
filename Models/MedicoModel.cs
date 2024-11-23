namespace AplicationTpDB.Models
{
    public class MedicoModel
    {
        public int CRM { get; set; }
        public string PessoaCPF { get; set; }
        public string Status { get; set; }
        public DateTime DataAdmissao { get; set; }

        public PessoaModel Pessoa { get; set; }
        public ICollection<EspecialidadeModel> Especialidades { get; set; }

    }
}
